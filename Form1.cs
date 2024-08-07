namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (double i = 0.01; i <= 0.101; i += 0.001)
            {
                CbLaisuat.Items.Add(String.Format("{0:P1}", Math.Round(i, 3)));
            }
            TxtTien.Text = "10000000";
            CbLaisuat.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BttnTinh_Click(object sender, EventArgs e)
        {
            LbKq.Items.Clear();
            double soTien = Convert.ToInt64(TxtTien.Text);
            int soNam = (int)Numsonam.Value;
            double laiSuat = double.Parse(CbLaisuat.SelectedItem.ToString().Replace("%", "")) / 100;
            for (int i = 1; i <= soNam; i++)
            {
                double tienLai = soTien + laiSuat;
                LbKq.Items.Add("Năm " + i + " Tiền gốc :" + soTien.ToString() + "- Lãi " + tienLai.ToString());
                soTien += tienLai;
            }

        }
    }
}
