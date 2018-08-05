using Tiger.PdrCommon.Basic;

namespace Tiger.PdrCommon
{
    partial class FrmUpdateDeptNameChild
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        private void Dispose(bool disposing)
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
            this.components = new System.ComponentModel.Container();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbDeptNameList = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dstEmployee = new DstEmployee();
            this.tCOM_DEPTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cmbDeptNameList.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCOM_DEPTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnCancel.Location = new System.Drawing.Point(221, 61);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(58, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "取消";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(127, 61);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(58, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确定";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 14);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "请选择部门名：";
            // 
            // cmbDeptNameList
            // 
            this.cmbDeptNameList.Location = new System.Drawing.Point(103, 23);
            this.cmbDeptNameList.Name = "cmbDeptNameList";
            this.cmbDeptNameList.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDeptNameList.Size = new System.Drawing.Size(176, 21);
            this.cmbDeptNameList.TabIndex = 3;
            // 
            // dstEmployee
            // 
            this.dstEmployee.DataSetName = "DstEmployee";
            this.dstEmployee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tCOM_DEPTBindingSource
            // 
            this.tCOM_DEPTBindingSource.DataMember = "TCOM_DEPT";
            this.tCOM_DEPTBindingSource.DataSource = this.dstEmployee;
            // 
            // FrmUpdateDeptNameChild
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(301, 96);
            this.Controls.Add(this.cmbDeptNameList);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Name = "FrmUpdateDeptNameChild";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "重置部门名";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HyForm_FormClosing);
            this.Load += new System.EventHandler(this.HyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbDeptNameList.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCOM_DEPTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbDeptNameList;
        private DstEmployee dstEmployee;
        private System.Windows.Forms.BindingSource tCOM_DEPTBindingSource;

    }
}