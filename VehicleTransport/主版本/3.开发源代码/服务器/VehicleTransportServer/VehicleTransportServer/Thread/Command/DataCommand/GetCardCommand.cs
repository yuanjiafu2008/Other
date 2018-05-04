﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Interface;
using Common.Model;
using VehicleTransportServer.BLL;
using VehicleTransportServer.Manage;
using Common.Model.DataCommand.OutDataComand;
using Common.Model.DataCommand.InDataCommand;
using Common.Model.DataCommand.OutDataCommand;

namespace VehicleTransportServer.Thread.Command.DataCommand
{
    public class GetCardCommand : ICommand
    {
        public void DoWork(Common.Model.CommandObjectModel cmdModel)
        {
            try
            {
                CommandObjectModel cm = new CommandObjectModel();
                InGetCardModel indep = Common.XmlManage<InGetCardModel>.XmlToModel(cmdModel.CmdModelXml);

                DateTime dt = DateTime.Now;
                try
                {
                    dt = Convert.ToDateTime(new DB_VehicleTransportManage.BLL.m_SystemConfig().GetValue(DB_VehicleTransportManage.BLL.EnumSystemConfigKeys.LastUpdateCardTable));
                }
                catch (Exception)
                {
                }
                
                if (dt != indep.LastUpdateTime)
                {
                    List<DB_VehicleTransportManage.Model.m_Card> lstCard = new DB_VehicleTransportManage.BLL.m_Card().GetModelList("i_Flag=0");
                    OutGetCardModel oModel = new OutGetCardModel();
                    oModel.Listm_Card = lstCard;
                    oModel.LastUpdateTime = dt;
                    cm.CmdModelXml = Common.XmlManage<OutGetCardModel>.ModelToXml(oModel);
                }
                
                cm.Result = true;
                cm.CmdType = Common.Enum.EnumCommandType.Data_GetCard;
                cm.DateTime = DateTime.Now;
                cm.CmdID = cmdModel.CmdID;
                string xml = Common.XmlManage<CommandObjectModel>.ModelToXml(cm);
                bool b = SocketManage.Current.Send(cmdModel.ClientIP, cmdModel.ClientPort, xml);
                Pub.CommandLogList.Enqueue(LogMessageBLL.GetModel(Model.EnumLogType.Send, "", cm, b));
            }
            catch (Exception ex)
            {
                Pub.CommandLogList.Enqueue(LogMessageBLL.GetModel(Model.EnumLogType.Server, "取卡信息列表出错：" + ex.Message, null, true));
            }
        }
    }
}
