namespace OOP_Buoi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            string gt = "Nam";
            if (rdbNu.Checked == true)
            {
                gt = "Nữ";
            }
            else gt = "Nam";

            sv.SetSinhVien(txtMSV.Text, txtTSV.Text, dtNS.Value, txtSDT.Text, gt);
            //sv.GetSinhVien();
            lsbSV.Items.Clear();
            lsbSV.Items.Add(sv.getMaSV());
            lsbSV.Items.Add(sv.getTenSV());
            lsbSV.Items.Add(sv.getTuoi());
            lsbSV.Items.Add(sv.getGioiTinh());
        
        }
    }
}
