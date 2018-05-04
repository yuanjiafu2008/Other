﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL = DB_VehicleTransportManage.BLL;
using Model = DB_VehicleTransportManage.Model;
using System.Collections;
namespace VehicleTransportClient.UI
{
    public partial class FrmGISArea : Common.frmBase
    {
        BLL.m_Vehicle bllcar = new BLL.m_Vehicle();
        BLL.m_VehicleType bllcartype = new BLL.m_VehicleType();
        BLL.m_Address blladdress = new BLL.m_Address();
        string _DWStationIDs = "";
        public FrmGISArea(string locaids)
        {
            InitializeComponent();
            _DWStationIDs = locaids;
        }
        private void InitCarType()
        {

            List<Model.m_Vehicle> listnormarlcar = bllcar.GetModelList("i_LocalizerStationID in (" + _DWStationIDs + ") and i_State=" + (int)Common.Enum.EnumVehicleState.Normal + " and i_Flag=0");
            List<Model.m_Vehicle> listusecar = bllcar.GetModelList("i_LocalizerStationID in (" + _DWStationIDs + ") and i_State=" + (int)Common.Enum.EnumVehicleState.Using + " and i_Flag=0");
            if (listnormarlcar == null || listnormarlcar.Count == 0)
                tabItemNormal.Visible = false;
            else
            {
                Hashtable hstype = new Hashtable();
                foreach (Model.m_Vehicle entity in listnormarlcar)
                {
                    Model.m_VehicleType type = bllcartype.GetModel(entity.VehicleTypeID.Value);
                    if (hstype.Contains(type.ID))
                    {
                        hstype[type.ID] = int.Parse(hstype[type.ID].ToString()) + 1;
                    }
                    else
                    {
                        hstype.Add(type.ID, 1);
                    }
                }
                foreach (DictionaryEntry de in hstype)
                {
                    dgvList.Rows.Add(dgvList.Rows.Count + 1, bllcartype.GetModel(int.Parse(de.Key.ToString())).vc_Name, de.Value.ToString());
                }

            }
            if (listusecar == null || listusecar.Count == 0)
                tabItemUsing.Visible = false;
            else
            {
                Hashtable hstype = new Hashtable();
                foreach (Model.m_Vehicle entity in listusecar)
                {
                    Model.m_VehicleType type = bllcartype.GetModel(entity.VehicleTypeID.Value);
                    if (hstype.Contains(type.ID))
                    {
                        hstype[type.ID] = int.Parse(hstype[type.ID].ToString()) + 1;
                    }
                    else
                    {
                        hstype.Add(type.ID, 1);
                    }
                }
                foreach (DictionaryEntry de in hstype)
                {
                    dgvCar.Rows.Add(dgvCar.Rows.Count + 1, bllcartype.GetModel(int.Parse(de.Key.ToString())).vc_Name, de.Value.ToString());
                }
            }
        }

        private void FrmGISArea_Load(object sender, EventArgs e)
        {
            InitCarType();
        }
    }
}
