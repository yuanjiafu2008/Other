﻿namespace VehicleTransportClient
{
    partial class FormVehicleType
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVehicleType));
            this.btnNo = new DevComponents.DotNetBar.ButtonX();
            this.btnOK = new DevComponents.DotNetBar.ButtonX();
            this.txtMemo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label5 = new System.Windows.Forms.Label();
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label10 = new System.Windows.Forms.Label();
            this.panelWorkArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWorkArea
            // 
            this.panelWorkArea.Controls.Add(this.label10);
            this.panelWorkArea.Controls.Add(this.btnNo);
            this.panelWorkArea.Controls.Add(this.btnOK);
            this.panelWorkArea.Controls.Add(this.txtName);
            this.panelWorkArea.Controls.Add(this.txtMemo);
            this.panelWorkArea.Controls.Add(this.label2);
            this.panelWorkArea.Controls.Add(this.label5);
            this.panelWorkArea.Dock = System.Windows.Forms.DockStyle.None;
            this.panelWorkArea.Location = new System.Drawing.Point(0, 27);
            this.panelWorkArea.Size = new System.Drawing.Size(389, 231);
            this.panelWorkArea.TabIndex = 0;
            // 
            // panelTitle
            // 
            this.panelTitle.Size = new System.Drawing.Size(232, 28);
            // 
            // btnNo
            // 
            this.btnNo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNo.Location = new System.Drawing.Point(219, 182);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNo.TabIndex = 3;
            this.btnNo.Text = "取消";
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnOK
            // 
            this.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOK.Location = new System.Drawing.Point(91, 182);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "保存";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtMemo
            // 
            // 
            // 
            // 
            this.txtMemo.Border.Class = "TextBoxBorder";
            this.txtMemo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMemo.Location = new System.Drawing.Point(87, 89);
            this.txtMemo.MaxLength = 50;
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(273, 74);
            this.txtMemo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(24, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 63;
            this.label5.Text = "备  注：";
            // 
            // balloonTip1
            // 
            this.balloonTip1.AlertAnimation = DevComponents.DotNetBar.eAlertAnimation.LeftToRight;
            this.balloonTip1.DefaultBalloonWidth = 100;
            this.balloonTip1.MinimumBalloonWidth = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(24, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 63;
            this.label2.Text = "名  称：";
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.Border.Class = "TextBoxBorder";
            this.txtName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtName.Location = new System.Drawing.Point(87, 41);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(145, 21);
            this.txtName.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(238, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 69;
            this.label10.Text = "*";
            // 
            // FormVehicleType
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnNo;
            this.ClientSize = new System.Drawing.Size(391, 263);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FormVehicleType";
            this.NeedMax = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "车辆类型设置";
            this.panelWorkArea.ResumeLayout(false);
            this.panelWorkArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnNo;
        private DevComponents.DotNetBar.ButtonX btnOK;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMemo;
        private System.Windows.Forms.Label label5;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
    }
}