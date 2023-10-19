namespace Kafe
{
    partial class SiparisForm
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
            btnDetayEkle = new Button();
            dgvDetaylar = new DataGridView();
            nudAdet = new NumericUpDown();
            cboUrun = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            btnAnasayfayaDon = new Button();
            btnOdemeAl = new Button();
            btnSiparisIptal = new Button();
            label1 = new Label();
            cboMasaNo = new ComboBox();
            btnMasaTasi = new Button();
            lblMasaNo = new Label();
            label5 = new Label();
            label6 = new Label();
            lblOdemeTutari = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAdet).BeginInit();
            SuspendLayout();
            // 
            // btnDetayEkle
            // 
            btnDetayEkle.Location = new Point(429, 36);
            btnDetayEkle.Margin = new Padding(4);
            btnDetayEkle.Name = "btnDetayEkle";
            btnDetayEkle.Size = new Size(141, 41);
            btnDetayEkle.TabIndex = 4;
            btnDetayEkle.Text = "EKLE";
            btnDetayEkle.UseVisualStyleBackColor = true;
            // 
            // dgvDetaylar
            // 
            dgvDetaylar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetaylar.Location = new Point(13, 83);
            dgvDetaylar.Margin = new Padding(4);
            dgvDetaylar.Name = "dgvDetaylar";
            dgvDetaylar.RowHeadersWidth = 51;
            dgvDetaylar.RowTemplate.Height = 29;
            dgvDetaylar.Size = new Size(557, 534);
            dgvDetaylar.TabIndex = 2;
            // 
            // nudAdet
            // 
            nudAdet.Location = new Point(251, 41);
            nudAdet.Margin = new Padding(4);
            nudAdet.Name = "nudAdet";
            nudAdet.Size = new Size(170, 34);
            nudAdet.TabIndex = 3;
            nudAdet.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cboUrun
            // 
            cboUrun.FormattingEnabled = true;
            cboUrun.Location = new Point(13, 41);
            cboUrun.Margin = new Padding(4);
            cboUrun.Name = "cboUrun";
            cboUrun.Size = new Size(224, 36);
            cboUrun.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 13);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 28);
            label2.TabIndex = 1;
            label2.Text = "Adet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 9);
            label3.Margin = new Padding(7, 0, 7, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 28);
            label3.TabIndex = 0;
            label3.Text = "Ürün";
            // 
            // btnAnasayfayaDon
            // 
            btnAnasayfayaDon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnasayfayaDon.Location = new Point(644, 489);
            btnAnasayfayaDon.Margin = new Padding(7, 6, 7, 6);
            btnAnasayfayaDon.Name = "btnAnasayfayaDon";
            btnAnasayfayaDon.Size = new Size(519, 112);
            btnAnasayfayaDon.TabIndex = 13;
            btnAnasayfayaDon.Text = "ANASAYFAYA DÖN";
            btnAnasayfayaDon.UseVisualStyleBackColor = true;
            // 
            // btnOdemeAl
            // 
            btnOdemeAl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOdemeAl.Location = new Point(910, 371);
            btnOdemeAl.Margin = new Padding(7, 6, 7, 6);
            btnOdemeAl.Name = "btnOdemeAl";
            btnOdemeAl.Size = new Size(252, 106);
            btnOdemeAl.TabIndex = 12;
            btnOdemeAl.Text = "ÖDEME AL";
            btnOdemeAl.UseVisualStyleBackColor = true;
            // 
            // btnSiparisIptal
            // 
            btnSiparisIptal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSiparisIptal.Location = new Point(644, 371);
            btnSiparisIptal.Margin = new Padding(7, 6, 7, 6);
            btnSiparisIptal.Name = "btnSiparisIptal";
            btnSiparisIptal.Size = new Size(252, 106);
            btnSiparisIptal.TabIndex = 11;
            btnSiparisIptal.Text = "SİPARİŞ İPTAL";
            btnSiparisIptal.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(783, 13);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 28);
            label1.TabIndex = 14;
            label1.Text = "Masa No:";
            // 
            // cboMasaNo
            // 
            cboMasaNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboMasaNo.FormattingEnabled = true;
            cboMasaNo.Location = new Point(783, 54);
            cboMasaNo.Margin = new Padding(4);
            cboMasaNo.Name = "cboMasaNo";
            cboMasaNo.Size = new Size(158, 36);
            cboMasaNo.TabIndex = 15;
            // 
            // btnMasaTasi
            // 
            btnMasaTasi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMasaTasi.Location = new Point(988, 54);
            btnMasaTasi.Margin = new Padding(4);
            btnMasaTasi.Name = "btnMasaTasi";
            btnMasaTasi.Size = new Size(138, 36);
            btnMasaTasi.TabIndex = 16;
            btnMasaTasi.Text = "TAŞI";
            btnMasaTasi.UseVisualStyleBackColor = true;
            // 
            // lblMasaNo
            // 
            lblMasaNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMasaNo.BackColor = Color.Tomato;
            lblMasaNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Millimeter);
            lblMasaNo.ForeColor = SystemColors.ButtonHighlight;
            lblMasaNo.Location = new Point(821, 121);
            lblMasaNo.Name = "lblMasaNo";
            lblMasaNo.Size = new Size(224, 159);
            lblMasaNo.TabIndex = 17;
            lblMasaNo.Text = "00";
            lblMasaNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(824, 302);
            label5.Name = "label5";
            label5.Size = new Size(146, 28);
            label5.TabIndex = 18;
            label5.Text = "Ödeme Tutarı:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(980, 302);
            label6.Name = "label6";
            label6.Size = new Size(0, 28);
            label6.TabIndex = 19;
            // 
            // lblOdemeTutari
            // 
            lblOdemeTutari.Anchor = AnchorStyles.Right;
            lblOdemeTutari.AutoSize = true;
            lblOdemeTutari.Location = new Point(980, 302);
            lblOdemeTutari.Margin = new Padding(7, 0, 7, 0);
            lblOdemeTutari.Name = "lblOdemeTutari";
            lblOdemeTutari.Size = new Size(65, 28);
            lblOdemeTutari.TabIndex = 20;
            lblOdemeTutari.Text = "₺0,00";
            // 
            // SiparisForm
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 630);
            Controls.Add(lblOdemeTutari);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblMasaNo);
            Controls.Add(btnMasaTasi);
            Controls.Add(cboMasaNo);
            Controls.Add(label1);
            Controls.Add(btnAnasayfayaDon);
            Controls.Add(btnOdemeAl);
            Controls.Add(btnSiparisIptal);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(cboUrun);
            Controls.Add(nudAdet);
            Controls.Add(dgvDetaylar);
            Controls.Add(btnDetayEkle);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "SiparisForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "00";
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAdet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnDetayEkle;
        private DataGridView dgvDetaylar;
        private NumericUpDown nudAdet;
        private ComboBox cboUrun;
        private Label label2;
        private Label label3;
        private Button btnAnasayfayaDon;
        private Button btnOdemeAl;
        private Button btnSiparisIptal;
        private Label label1;
        private ComboBox cboMasaNo;
        private Button btnMasaTasi;
        private Label lblMasaNo;
        private Label label5;
        private Label label6;
        private Label lblOdemeTutari;
    }
}