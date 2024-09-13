using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Buoi1
{
    internal class SinhVien
    {

        private string maSV;
        private string tenSV;
        private DateTime ngaySinh;
        private string soDienThoai;
        private string gioiTinh;
        private int tuoi;


        public void setMaSV(string maSV) { this.maSV = maSV;}
        public string getMaSV() { return this.maSV; }

        public void setTenSV(string tenSV) { this.tenSV = tenSV; }
        public string getTenSV() { return this.tenSV;}

        public void setNgaySinh(DateTime ngaySinh){ this.ngaySinh = ngaySinh;}
        public DateTime getNgaySinh() {return this.ngaySinh;}

        public void setSoDienThoai(string soDienThoai){this.soDienThoai = soDienThoai;}
        public string getSoDienThoai(){return this.soDienThoai;}

        public void setGioiTinh(string gioiTinh){ this.gioiTinh = gioiTinh;}
        public string getGioiTinh(){return this.gioiTinh;}

        public void setTuoi(DateTime ngaySinh){ this.tuoi = DateTime.Now.Year -  ngaySinh.Year;}
        public int getTuoi() { return this.tuoi; }

        internal void SetSinhVien(string maSV, string tenSv, DateTime ngaySinh, string soDienThoai, string gioiTinh)
        {
            setMaSV(maSV);
            setTenSV(tenSv);
            setNgaySinh(ngaySinh);
            setSoDienThoai(soDienThoai);
            setGioiTinh(gioiTinh);
            setTuoi(ngaySinh);
        }

        internal void GetSinhVien()
        {
            //getMaSV();
            //getTenSV();
            //getNgaySinh();
            //getSoDienThoai();
            //getGioiTinh();
            //MessageBox.Show(getMaSV() + "\n" + getTenSV() + "\n" + getNgaySinh() + "\n" + getSoDienThoai() + "\n" + getGioiTinh());
            MessageBox.Show(maSV + "\n" + tenSV + "\n" + ngaySinh + "\n" + soDienThoai + "\n" + gioiTinh + "\n" + tuoi, "Thông tin sinh viên");
        }
    }
}
