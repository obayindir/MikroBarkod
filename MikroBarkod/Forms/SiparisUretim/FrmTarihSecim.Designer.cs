namespace MikroBarkod
{
    partial class FrmTarihSecim
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
            this.dateUretimTarihi = new DevExpress.XtraEditors.DateEdit();
            this.dateSKT = new DevExpress.XtraEditors.DateEdit();
            this.btnBarkodBas = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.spnAdet = new DevExpress.XtraEditors.SpinEdit();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dateUretimTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateUretimTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSKT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSKT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnAdet.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dateUretimTarihi
            // 
            this.dateUretimTarihi.EditValue = null;
            this.dateUretimTarihi.EnterMoveNextControl = true;
            this.dateUretimTarihi.Location = new System.Drawing.Point(198, 80);
            this.dateUretimTarihi.Name = "dateUretimTarihi";
            this.dateUretimTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateUretimTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateUretimTarihi.Size = new System.Drawing.Size(204, 26);
            this.dateUretimTarihi.TabIndex = 2;
            // 
            // dateSKT
            // 
            this.dateSKT.EditValue = null;
            this.dateSKT.EnterMoveNextControl = true;
            this.dateSKT.Location = new System.Drawing.Point(198, 129);
            this.dateSKT.Name = "dateSKT";
            this.dateSKT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSKT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSKT.Size = new System.Drawing.Size(204, 26);
            this.dateSKT.TabIndex = 3;
            // 
            // btnBarkodBas
            // 
            this.btnBarkodBas.Location = new System.Drawing.Point(102, 194);
            this.btnBarkodBas.Name = "btnBarkodBas";
            this.btnBarkodBas.Size = new System.Drawing.Size(260, 47);
            this.btnBarkodBas.TabIndex = 4;
            this.btnBarkodBas.Text = "YAZDIR";
            this.btnBarkodBas.Click += new System.EventHandler(this.btnBarkodBas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "ÜRETİM TARİHİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "S.K.T.";
            // 
            // spnAdet
            // 
            this.spnAdet.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnAdet.EnterMoveNextControl = true;
            this.spnAdet.Location = new System.Drawing.Point(198, 30);
            this.spnAdet.Name = "spnAdet";
            this.spnAdet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnAdet.Properties.MaskSettings.Set("mask", "N0");
            this.spnAdet.Size = new System.Drawing.Size(204, 28);
            this.spnAdet.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "ADET";
            // 
            // FrmTarihSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 280);
            this.Controls.Add(this.spnAdet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBarkodBas);
            this.Controls.Add(this.dateSKT);
            this.Controls.Add(this.dateUretimTarihi);
            this.MaximizeBox = false;
            this.Name = "FrmTarihSecim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmTarihSecim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateUretimTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateUretimTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSKT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSKT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnAdet.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dateUretimTarihi;
        private DevExpress.XtraEditors.DateEdit dateSKT;
        private DevExpress.XtraEditors.SimpleButton btnBarkodBas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SpinEdit spnAdet;
        private System.Windows.Forms.Label label3;
    }
}