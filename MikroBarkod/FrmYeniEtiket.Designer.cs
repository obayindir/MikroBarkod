namespace MikroBarkod
{
    partial class FrmYeniEtiket
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
            this.btnStokKodu = new DevExpress.XtraEditors.ButtonEdit();
            this.txtStokAdi = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBarkod = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateSKT = new DevExpress.XtraEditors.DateEdit();
            this.dateUretimTarihi = new DevExpress.XtraEditors.DateEdit();
            this.btnYazdir = new DevExpress.XtraEditors.SimpleButton();
            this.spnAdet = new DevExpress.XtraEditors.SpinEdit();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnStokKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSKT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSKT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateUretimTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateUretimTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnAdet.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStokKodu
            // 
            this.btnStokKodu.EnterMoveNextControl = true;
            this.btnStokKodu.Location = new System.Drawing.Point(186, 12);
            this.btnStokKodu.Name = "btnStokKodu";
            this.btnStokKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnStokKodu.Size = new System.Drawing.Size(314, 26);
            this.btnStokKodu.TabIndex = 1;
            this.btnStokKodu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnStokKodu_ButtonClick);
            // 
            // txtStokAdi
            // 
            this.txtStokAdi.EnterMoveNextControl = true;
            this.txtStokAdi.Location = new System.Drawing.Point(186, 65);
            this.txtStokAdi.Name = "txtStokAdi";
            this.txtStokAdi.Size = new System.Drawing.Size(314, 26);
            this.txtStokAdi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stok Kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stok Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Barkodu";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(186, 119);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Properties.ReadOnly = true;
            this.txtBarkod.Size = new System.Drawing.Size(314, 26);
            this.txtBarkod.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "S.K.T.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Üretim Tarihi";
            // 
            // dateSKT
            // 
            this.dateSKT.EditValue = null;
            this.dateSKT.EnterMoveNextControl = true;
            this.dateSKT.Location = new System.Drawing.Point(186, 217);
            this.dateSKT.Name = "dateSKT";
            this.dateSKT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSKT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSKT.Size = new System.Drawing.Size(314, 26);
            this.dateSKT.TabIndex = 5;
            // 
            // dateUretimTarihi
            // 
            this.dateUretimTarihi.EditValue = null;
            this.dateUretimTarihi.EnterMoveNextControl = true;
            this.dateUretimTarihi.Location = new System.Drawing.Point(186, 168);
            this.dateUretimTarihi.Name = "dateUretimTarihi";
            this.dateUretimTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateUretimTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateUretimTarihi.Size = new System.Drawing.Size(314, 26);
            this.dateUretimTarihi.TabIndex = 4;
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(361, 266);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(139, 56);
            this.btnYazdir.TabIndex = 6;
            this.btnYazdir.Text = "YAZDIR";
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // spnAdet
            // 
            this.spnAdet.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnAdet.Location = new System.Drawing.Point(186, 270);
            this.spnAdet.Name = "spnAdet";
            this.spnAdet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnAdet.Size = new System.Drawing.Size(150, 28);
            this.spnAdet.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(48, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "MİKTAR";
            // 
            // FrmYeniEtiket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 334);
            this.Controls.Add(this.spnAdet);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateSKT);
            this.Controls.Add(this.dateUretimTarihi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.txtStokAdi);
            this.Controls.Add(this.btnStokKodu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmYeniEtiket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmYeniEtiket_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmYeniEtiket_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnStokKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSKT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSKT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateUretimTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateUretimTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnAdet.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ButtonEdit btnStokKodu;
        private DevExpress.XtraEditors.TextEdit txtStokAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtBarkod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.DateEdit dateSKT;
        private DevExpress.XtraEditors.DateEdit dateUretimTarihi;
        private DevExpress.XtraEditors.SimpleButton btnYazdir;
        private DevExpress.XtraEditors.SpinEdit spnAdet;
        private System.Windows.Forms.Label label6;
    }
}