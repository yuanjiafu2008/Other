﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BW.MMS.BLL;
using BW.MMS.Model;
using BW.MMS.Web.HtmlExtension.Easyui;
using BW.MMS.Web.Filters;
using BW.MMS.Web.Common;
using System.IO;
using System.Data;
using System.ComponentModel;

namespace BW.MMS.Web.Controllers
{
    public class UserController : BaseController
    {
        private readonly sys_UserBLL bll = new sys_UserBLL();

        private List<List<DataGridColumn>> GetColumns()
        {
            List<DataGridColumn> column = new List<DataGridColumn>();
            column.Add(new DataGridColumn { field = "cbk", columnAttributes = new { checkbox = true } });
            column.Add(new DataGridColumn { title = "人员编号", field = "ID", columnAttributes = new { align = "center", width = 80, sortable = true } });
            column.Add(new DataGridColumn { title = "用户名", field = "vc_UserName", columnAttributes = new { align = "center", width = 100, sortable = true } });
            column.Add(new DataGridColumn { title = "姓名", field = "vc_RealName", columnAttributes = new { align = "center", width = 120, sortable = true } });
            column.Add(new DataGridColumn { title = "状态", field = "i_Flag", columnAttributes = new { align = "center", width = 100, formatter = new { function = "formatFlag" } } });
            column.Add(new DataGridColumn { title = "描述", field = "vc_Description", columnAttributes = new { align = "center", width = 150 } });
            List<List<DataGridColumn>> columns = new List<List<DataGridColumn>>();
            columns.Add(column);
            return columns;
        }
        /// <summary>
        /// 首页视图
        /// </summary>
        /// <returns></returns>
        [ExceptionFilter]
        public ActionResult Index()
        {
            ViewData["GridColumn"] = GetColumns();
            return View();
        }
        /// <summary>
        /// 编辑视图
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ExceptionFilter]
        public ActionResult Edit(int id = 0)
        {
            return View(bll.GetModel(id));
        }
        /// <summary>
        /// 获取DataGrid数据
        /// </summary>
        /// <param name="page">起始页</param>
        /// <param name="rows">每页条数</param>
        /// <param name="sort">排序字段</param>
        /// <param name="order">排序方式(DESC/ASC)</param>
        /// <returns></returns>
        [HttpPost]
        [ExceptionFilter(IsAjax = true)]
        public JsonResult GetGridList(int page, int rows, string sort, string order)
        {
            int record = 0;
            List<sys_UserEntity> list = bll.GetPagingList(Texthelper.SqlFilter(Request["name"]), page, rows, sort, order, out record);
            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("total", record);
            data.Add("rows", list);
            return Json(data);
        }
        /// <summary>
        /// 编辑数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        [HttpPost]
        [ExceptionFilter(IsAjax = true)]
        public JsonResult Edit(sys_UserEntity entity)
        {
            if (entity.ID == 0)
            {
                List<sys_UserEntity> users = bll.GetModelList(string.Format("vc_UserName='{0}'", entity.vc_UserName));
                if (users.Count > 0)
                {
                    return Json(new { success = false, message = "用户名已经存在！" });
                }
                entity.vc_Password = Texthelper.GetMd5Hash(entity.vc_Password);
                if (bll.Add(entity) > 0)
                {
                    return Json(new { success = true, message = "添加成功！" });
                }
                else
                {
                    return Json(new { success = true, message = "添加失败！" });
                }
            }
            else
            {
                List<sys_UserEntity> users = bll.GetModelList(string.Format("vc_UserName='{0}' and ID<>{1}", entity.vc_UserName, entity.ID));
                if (users.Count > 0)
                {
                    return Json(new { success = false, message = "用户名已经存在！" });
                }
                sys_UserEntity user = bll.GetModel(entity.ID);
                if (!user.vc_Password.Equals(entity.vc_Password))
                {
                    entity.vc_Password = Texthelper.GetMd5Hash(entity.vc_Password);
                }
                if (bll.Update(entity))
                {
                    return Json(new { success = true, message = "修改成功！" });
                }
                else
                {
                    return Json(new { success = true, message = "修改失败！" });
                }
            }
        }
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [ExceptionFilter(IsAjax = true)]
        public JsonResult Delete(string id)
        {
            if (bll.DeleteList(id))
            {
                return Json(new { success = true, message = "删除成功！" });
            }
            else
            {
                return Json(new { success = false, message = "删除失败！" });
            }
        }

        [ExceptionFilter]
        public ActionResult Authorized(int id = 0)
        {
            ViewData["UserID"] = id;
            return View();
        }
        [HttpPost]
        [ExceptionFilter(IsAjax = true)]
        public JsonResult SaveAuthority()
        {
            string userid = Request["id"];
            string[] modules = Request["data"].Split(',');
            sys_AuthorityBLL auth = new sys_AuthorityBLL();
            auth.Delete(string.Format("UserID={0}", userid));
            foreach (string id in modules)
            {
                if (!string.IsNullOrEmpty(id))
                {
                    sys_AuthorityEntity entity = new sys_AuthorityEntity();
                    entity.UserID = int.Parse(userid);
                    entity.ModuleID = int.Parse(id);
                    auth.Add(entity);
                }
            }
            return Json(new { success = true, message = "保存成功！" });
        }
    }
}
