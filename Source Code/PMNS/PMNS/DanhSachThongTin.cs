using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMNS.Services.Abstract;
using PMNS.Entities.Models;

namespace PMNS
{
    public partial class DanhSachThongTin : Form
    {
        protected readonly IThongTinServices _thongTinServices;
        protected readonly string _loaiThongTin;
        public DanhSachThongTin(IThongTinServices thongTinServices, string loaiThongTin)
        {
            this._thongTinServices = thongTinServices;
            this._loaiThongTin = loaiThongTin;
            InitializeComponent();
        }

        private void DanhSachThongTin_Load(object sender, EventArgs e)
        {
            txtLenh.Text = _loaiThongTin;
            txtLenh.ReadOnly = true;
            InitGridView();
        }

        private void InitGridView()
        {
            dataGridThongTin.DataSource = _thongTinServices.GetAllThongTin().Where(x => x.noiDung.Equals(_loaiThongTin)).ToList()
                .Select(x => new 
                    {
                        id = x.idTDDDBNTV,
                        MaNhanVien = x.ThongTinNhanVIen.MaNV,
                        TenNhanVien = x.ThongTinNhanVIen.hoTen,
                        NguoiKyQuyetDinh = x.hoTenDD,
                        NamThucHien = x.namThucHien.Year,
                        NgayKy = x.ngayKyQD,
                        NgayHieuLuc = x.ngayHieuLuc,
                        SoQuyetDinh = x.soQuyetDinh,
                        ViTriCu = x.viTriCu,
                        ViTriMoi = x.viTriMoi
                    }).ToList();
            dataGridThongTin.Columns[0].Visible = false;
            dataGridThongTin.CurrentCell = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datetimeNgayKy_ValueChanged(object sender, EventArgs e)
        {
            datetimeNgayKy.Format = DateTimePickerFormat.Custom;
            datetimeNgayKy.CustomFormat = "dd/MM/yyyy";
            txtNamThucHien.Text = datetimeNgayKy.Text;
        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTenNV.Text.Trim()))
            {
                dataGridThongTin.DataSource = _thongTinServices.GetAllThongTin().Where(x => x.noiDung.Equals(_loaiThongTin)).ToList()
                    .Where(x=>x.ThongTinNhanVIen.hoTen.Contains(txtTenNV.Text.Trim())).ToList().Select(x => new
                    {
                        id = x.idTDDDBNTV,
                        MaNhanVien = x.ThongTinNhanVIen.MaNV,
                        TenNhanVien = x.ThongTinNhanVIen.hoTen,
                        NguoiKyQuyetDinh = x.hoTenDD,
                        NamThucHien = x.namThucHien.Year,
                        NgayKy = Convert.ToDateTime(x.ngayKyQD).ToString("dd/MM/yyyy"),
                        NgayHieuLuc = Convert.ToDateTime(x.ngayHieuLuc).ToString("dd/MM/yyyy"),
                        SoQuyetDinh = x.soQuyetDinh,
                        ViTriCu = x.viTriCu,
                        ViTriMoi = x.viTriMoi
                    }).ToList();
                dataGridThongTin.Columns[0].Visible = false;
                dataGridThongTin.CurrentCell = null;
            }
        }
    }
}
