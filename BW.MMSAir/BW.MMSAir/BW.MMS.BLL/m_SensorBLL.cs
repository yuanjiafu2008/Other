﻿using System;
using System.Data;
using System.Collections.Generic;

using BW.MMS.Model;
namespace BW.MMS.BLL
{
	/// <summary>
	/// 传感器信息表
	/// </summary>
	public partial class m_SensorBLL
	{
		private readonly BW.MMS.DAL.m_SensorDAL dal=new BW.MMS.DAL.m_SensorDAL();
		public m_SensorBLL()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			return dal.Exists(ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(BW.MMS.Model.m_SensorEntity model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(BW.MMS.Model.m_SensorEntity model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ID)
		{
			
			return dal.Delete(ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			return dal.DeleteList(IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public BW.MMS.Model.m_SensorEntity GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<BW.MMS.Model.m_SensorEntity> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<BW.MMS.Model.m_SensorEntity> DataTableToList(DataTable dt)
		{
			List<BW.MMS.Model.m_SensorEntity> modelList = new List<BW.MMS.Model.m_SensorEntity>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				BW.MMS.Model.m_SensorEntity model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new BW.MMS.Model.m_SensorEntity();
					if(dt.Rows[n]["ID"]!=null && dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["vc_Code"]!=null && dt.Rows[n]["vc_Code"].ToString()!="")
					{
					model.vc_Code=dt.Rows[n]["vc_Code"].ToString();
					}
					if(dt.Rows[n]["TypeID"]!=null && dt.Rows[n]["TypeID"].ToString()!="")
					{
						model.TypeID=int.Parse(dt.Rows[n]["TypeID"].ToString());
					}
					if(dt.Rows[n]["vc_Address"]!=null && dt.Rows[n]["vc_Address"].ToString()!="")
					{
					model.vc_Address=dt.Rows[n]["vc_Address"].ToString();
					}
					if(dt.Rows[n]["AreaID"]!=null && dt.Rows[n]["AreaID"].ToString()!="")
					{
						model.AreaID=int.Parse(dt.Rows[n]["AreaID"].ToString());
					}
					if(dt.Rows[n]["DeptID"]!=null && dt.Rows[n]["DeptID"].ToString()!="")
					{
						model.DeptID=int.Parse(dt.Rows[n]["DeptID"].ToString());
					}
					if(dt.Rows[n]["EnergyType"]!=null && dt.Rows[n]["EnergyType"].ToString()!="")
					{
						model.EnergyType=int.Parse(dt.Rows[n]["EnergyType"].ToString());
					}
					if(dt.Rows[n]["vc_Memo"]!=null && dt.Rows[n]["vc_Memo"].ToString()!="")
					{
					model.vc_Memo=dt.Rows[n]["vc_Memo"].ToString();
					}
					if(dt.Rows[n]["i_Flag"]!=null && dt.Rows[n]["i_Flag"].ToString()!="")
					{
						model.i_Flag=int.Parse(dt.Rows[n]["i_Flag"].ToString());
					}
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}
        /// <summary>
        /// 分页数据
        /// </summary>
        /// <param name="name">用户名</param>
        /// <param name="page">当前页</param>
        /// <param name="rows">每页显示条数</param>
        /// <param name="sort">提序字段</param>
        /// <param name="order">排序方式</param>
        /// <param name="total">返回总条数</param>
        /// <returns></returns>
        public List<BW.MMS.Model.m_SensorEntity> GetPagingList(string name, int page, int rows, string sort, string order, out int total)
        {
            DataTable dt = dal.GetPagingList(name, page, rows, sort, order, out total);
            return DataTableToList(dt);
        }
		#endregion  Method
	}
}

