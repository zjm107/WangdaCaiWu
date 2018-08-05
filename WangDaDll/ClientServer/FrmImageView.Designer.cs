namespace WangDaDll
{
    partial class FrmImageView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImageView));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnZoom100 = new DevExpress.XtraEditors.SimpleButton();
            this.btnZoomMinus = new DevExpress.XtraEditors.SimpleButton();
            this.btnZoomAdd = new DevExpress.XtraEditors.SimpleButton();
            this.imageView = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageView.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnZoom100);
            this.panelControl1.Controls.Add(this.btnZoomMinus);
            this.panelControl1.Controls.Add(this.btnZoomAdd);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 569);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(829, 40);
            this.panelControl1.TabIndex = 1;
            // 
            // btnZoom100
            // 
            this.btnZoom100.Image = ((System.Drawing.Image)(resources.GetObject("btnZoom100.Image")));
            this.btnZoom100.Location = new System.Drawing.Point(93, 9);
            this.btnZoom100.Name = "btnZoom100";
            this.btnZoom100.Size = new System.Drawing.Size(75, 23);
            this.btnZoom100.TabIndex = 2;
            this.btnZoom100.Text = "100%";
            this.btnZoom100.Click += new System.EventHandler(this.btnZoom100_Click);
            // 
            // btnZoomMinus
            // 
            this.btnZoomMinus.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomMinus.Image")));
            this.btnZoomMinus.Location = new System.Drawing.Point(174, 9);
            this.btnZoomMinus.Name = "btnZoomMinus";
            this.btnZoomMinus.Size = new System.Drawing.Size(75, 23);
            this.btnZoomMinus.TabIndex = 1;
            this.btnZoomMinus.Text = "缩小";
            this.btnZoomMinus.Click += new System.EventHandler(this.btnZoomMinus_Click);
            // 
            // btnZoomAdd
            // 
            this.btnZoomAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomAdd.Image")));
            this.btnZoomAdd.Location = new System.Drawing.Point(12, 9);
            this.btnZoomAdd.Name = "btnZoomAdd";
            this.btnZoomAdd.Size = new System.Drawing.Size(75, 23);
            this.btnZoomAdd.TabIndex = 0;
            this.btnZoomAdd.Text = "放大";
            this.btnZoomAdd.Click += new System.EventHandler(this.btnZoomAdd_Click);
            // 
            // imageView
            // 
            this.imageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageView.Location = new System.Drawing.Point(0, 0);
            this.imageView.Name = "imageView";
            this.imageView.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.True;
            this.imageView.Size = new System.Drawing.Size(829, 569);
            this.imageView.TabIndex = 3;
            // 
            // FrmImageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 609);
            this.Controls.Add(this.imageView);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmImageView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图片查看";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmImageView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageView.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnZoom100;
        private DevExpress.XtraEditors.SimpleButton btnZoomMinus;
        private DevExpress.XtraEditors.SimpleButton btnZoomAdd;
        private DevExpress.XtraEditors.PictureEdit imageView;

    }
}