namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            soTien = new Label();
            TxtTien = new TextBox();
            laiSuat = new Label();
            CbLaisuat = new ComboBox();
            soNam = new Label();
            Numsonam = new NumericUpDown();
            Kq = new Label();
            BttnTinh = new Button();
            LbKq = new ListBox();
            ((System.ComponentModel.ISupportInitialize)Numsonam).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tekton Pro Ext", 30F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(138, 37);
            label1.Name = "label1";
            label1.Size = new Size(1093, 98);
            label1.TabIndex = 0;
            label1.Text = "TÍNH LÃI SUẤT TIẾT KIỆM";
            // 
            // soTien
            // 
            soTien.AutoSize = true;
            soTien.Font = new Font("Tahoma", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            soTien.Location = new Point(219, 179);
            soTien.Name = "soTien";
            soTien.Size = new Size(173, 45);
            soTien.TabIndex = 1;
            soTien.Text = "Số tiền :";
            // 
            // TxtTien
            // 
            TxtTien.Font = new Font("Tahoma", 13F, FontStyle.Bold);
            TxtTien.Location = new Point(580, 179);
            TxtTien.Name = "TxtTien";
            TxtTien.Size = new Size(435, 49);
            TxtTien.TabIndex = 2;
            // 
            // laiSuat
            // 
            laiSuat.AutoSize = true;
            laiSuat.Font = new Font("Tahoma", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            laiSuat.Location = new Point(219, 284);
            laiSuat.Name = "laiSuat";
            laiSuat.Size = new Size(189, 45);
            laiSuat.TabIndex = 1;
            laiSuat.Text = "Lãi suất :";
            // 
            // CbLaisuat
            // 
            CbLaisuat.Font = new Font("Tahoma", 13F, FontStyle.Bold);
            CbLaisuat.FormattingEnabled = true;
            CbLaisuat.Location = new Point(580, 284);
            CbLaisuat.Name = "CbLaisuat";
            CbLaisuat.Size = new Size(435, 50);
            CbLaisuat.TabIndex = 3;
            // 
            // soNam
            // 
            soNam.AutoSize = true;
            soNam.Font = new Font("Tahoma", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            soNam.Location = new Point(219, 369);
            soNam.Name = "soNam";
            soNam.Size = new Size(253, 45);
            soNam.TabIndex = 1;
            soNam.Text = "Số năm gửi :";
            // 
            // Numsonam
            // 
            Numsonam.Font = new Font("Tahoma", 13.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Numsonam.Location = new Point(580, 379);
            Numsonam.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            Numsonam.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            Numsonam.Name = "Numsonam";
            Numsonam.Size = new Size(435, 50);
            Numsonam.TabIndex = 4;
            Numsonam.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Kq
            // 
            Kq.AutoSize = true;
            Kq.Font = new Font("Tahoma", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Kq.Location = new Point(62, 458);
            Kq.Name = "Kq";
            Kq.Size = new Size(187, 45);
            Kq.TabIndex = 1;
            Kq.Text = "Kết quả :";
            // 
            // BttnTinh
            // 
            BttnTinh.Font = new Font("Tahoma", 15F, FontStyle.Bold);
            BttnTinh.Location = new Point(1164, 272);
            BttnTinh.Name = "BttnTinh";
            BttnTinh.Size = new Size(150, 66);
            BttnTinh.TabIndex = 5;
            BttnTinh.Text = "TÍNH";
            BttnTinh.UseVisualStyleBackColor = true;
            BttnTinh.Click += BttnTinh_Click;
            // 
            // LbKq
            // 
            LbKq.FormattingEnabled = true;
            LbKq.Location = new Point(62, 565);
            LbKq.Name = "LbKq";
            LbKq.Size = new Size(1252, 452);
            LbKq.TabIndex = 6;
            LbKq.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1449, 1029);
            Controls.Add(LbKq);
            Controls.Add(BttnTinh);
            Controls.Add(Numsonam);
            Controls.Add(CbLaisuat);
            Controls.Add(TxtTien);
            Controls.Add(soNam);
            Controls.Add(laiSuat);
            Controls.Add(Kq);
            Controls.Add(soTien);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Numsonam).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label soTien;
        private TextBox TxtTien;
        private Label laiSuat;
        private ComboBox CbLaisuat;
        private Label soNam;
        private NumericUpDown Numsonam;
        private Label Kq;
        private Button BttnTinh;
        private ListBox LbKq;
    }
}
