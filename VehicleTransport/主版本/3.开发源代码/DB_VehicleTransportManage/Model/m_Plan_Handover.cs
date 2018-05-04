﻿/**  版本信息模板在安装目录下，可自行修改。
* m_Plan_Handover.cs
*
* 功 能： N/A
* 类 名： m_Plan_Handover
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/10/16 13:27:32   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace DB_VehicleTransportManage.Model
{
	/// <summary>
	/// m_Plan_Handover:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class m_Plan_Handover
	{
		public m_Plan_Handover()
		{}
		#region Model
		private int _id;
		private int? _planid;
		private int? _vehicleid;
		private DateTime? _dt_handoverdatetime;
		private int? _receivevehiclepersonid;
		private int? _i_handovercount;
		private string _vc_memo;
		private int? _i_flag=0;
		private int? _addressid;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PlanID
		{
			set{ _planid=value;}
			get{return _planid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? VehicleID
		{
			set{ _vehicleid=value;}
			get{return _vehicleid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_HandoverDateTime
		{
			set{ _dt_handoverdatetime=value;}
			get{return _dt_handoverdatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ReceiveVehiclePersonID
		{
			set{ _receivevehiclepersonid=value;}
			get{return _receivevehiclepersonid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? i_HandoverCount
		{
			set{ _i_handovercount=value;}
			get{return _i_handovercount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string vc_Memo
		{
			set{ _vc_memo=value;}
			get{return _vc_memo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? i_Flag
		{
			set{ _i_flag=value;}
			get{return _i_flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? AddressID
		{
			set{ _addressid=value;}
			get{return _addressid;}
		}
		#endregion Model

	}
}

