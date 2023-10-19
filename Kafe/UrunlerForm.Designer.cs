namespace Kafe
{
    partial class UrunlerForm
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
            txtUrunAd = new TextBox();
            label1 = new Label();
            dgvUrunler = new DataGridView();
            nudBirimFiyat = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            btnEkle = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBirimFiyat).BeginInit();
            SuspendLayout();
            // 
            // txtUrunAd
            // 
            txtUrunAd.Location = new Point(24, 58);
            txtUrunAd.Margin = new Padding(4, 4, 4, 4);
            txtUrunAd.Name = "txtUrunAd";
            txtUrunAd.Size = new Size(185, 34);
            txtUrunAd.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 1;
            label1.Text = "Ürün Adı";
            // 
            // dgvUrunler
            // 
            dgvUrunler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunler.Location = new Point(24, 100);
            dgvUrunler.Margin = new Padding(4, 4, 4, 4);
            dgvUrunler.Name = "dgvUrunler";
            dgvUrunler.RowHeadersWidth = 51;
            dgvUrunler.RowTemplate.Height = 29;
            dgvUrunler.Size = new Size(552, 589);
            dgvUrunler.TabIndex = 3;
            // 
            // nudBirimFiyat
            // 
            nudBirimFiyat.Location = new Point(236, 58);
            nudBirimFiyat.Margin = new Padding(4, 4, 4, 4);
            nudBirimFiyat.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudBirimFiyat.Name = "nudBirimFiyat";
            nudBirimFiyat.Size = new Size(154, 34);
            nudBirimFiyat.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 26);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(153, 28);
            label2.TabIndex = 8;
            label2.Text = "Birim Fiyatı (₺)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(838, 9);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 28);
            label3.TabIndex = 9;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(419, 58);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(157, 34);
            btnEkle.TabIndex = 10;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // UrunlerForm
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 712);
            Controls.Add(btnEkle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(nudBirimFiyat);
            Controls.Add(dgvUrunler);
            Controls.Add(label1);
            Controls.Add(txtUrunAd);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "UrunlerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ürünler";
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBirimFiyat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUrunAd;
        private Label label1;
        private DataGridView dgvUrunler;
        private NumericUpDown nudBirimFiyat;
        private Label label2;
        private Label label3;
        private Button btnEkle;
    }
}