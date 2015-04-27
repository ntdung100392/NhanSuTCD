﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace PMNS
{
    public partial class ThemNV : Form
    {
        public ThemNV()
        {
            InitializeComponent();
        }

        string gioitinh = "";

        #region DateTimePicker

        private void datetimeNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            datetimeNgaySinh.Format = DateTimePickerFormat.Custom;
            datetimeNgaySinh.CustomFormat = "dd/MM/yyyy";
            txtNgaySinh.Text = datetimeNgaySinh.Text;
        }
        private void datetimeCMND_ValueChanged(object sender, EventArgs e)
        {
            datetimeCMND.Format = DateTimePickerFormat.Custom;
            datetimeCMND.CustomFormat = "dd/MM/yyyy";
            txtNgayCapCMND.Text = datetimeCMND.Text;
        }
        private void datetimeNgayVaoCang_ValueChanged(object sender, EventArgs e)
        {
            datetimeNgayVaoCang.Format = DateTimePickerFormat.Custom;
            datetimeNgayVaoCang.CustomFormat = "dd/MM/yyyy";
            txtNgayVaoCang.Text = datetimeNgayVaoCang.Text;
        }
        private void datetimeNgayNhapNgu_ValueChanged(object sender, EventArgs e)
        {
            datetimeNgayNhapNgu.Format = DateTimePickerFormat.Custom;
            datetimeNgayNhapNgu.CustomFormat = "dd/MM/yyyy";
            txtNgayNhapNgu.Text = datetimeNgayNhapNgu.Text;
        }

        private void datetimeNamVaoST_ValueChanged(object sender, EventArgs e)
        {
            datetimeNamVaoST.Format = DateTimePickerFormat.Custom;
            datetimeNamVaoST.CustomFormat = "dd/MM/yyyy";
            txtNamVaoST.Text = datetimeNamVaoST.Text;
        }
        #endregion
        private void ThemNV_Load(object sender, EventArgs e)
        {
            txtPass.Visible = false;
            txtPQ.Visible = false;
            textBox1.Enabled = false;
            PhongBan();
            Doi();
            To();
            LoaiTo();
            ThanhPho();
            dropChucVu();
            cbHonNhan();
            NoiCapCMND();
            loadgridview();
            cbTo.SelectedIndex = -1;
            cbDoi.SelectedIndex = -1;
            cbLoaiTo.SelectedIndex = -1;
        }
        void loadgridview()
        {
            Connection.moketnoi();
            SqlDataAdapter datagridNLD = new SqlDataAdapter("select * from _ThongTinNguoiLaoDong", Connection.cnn);
            DataTable gridTTNLD = new DataTable();
            datagridNLD.Fill(gridTTNLD);
            dataGridView1.DataSource = gridTTNLD;
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (rbtnNam.Checked == true)
            {
                gioitinh = "Nam";
            }
            if (rBtnNu.Checked == true)
            {
                gioitinh = "Nữ";
            }
            try
            {
                SqlCommand cmd = new SqlCommand("insert into _ThongTinNguoiLaoDong  (MaNV, MaPhongBan, MaDoi, MaTo, MaLoaiTo, ID, Password, PhanQuyen, BienChe, CapBac, MaChucVu, CongViecDangLam, HoTen, GioiTinh, NamSinh, NguyenQuan, NoiOHienNay, HoKhau, CMND, NgayCapCMND, NoiCapCMND, SDTDD, NguoiBaoLanh, MoiQuanHeNBL, NgayVaoCang, NamVaoST, NgayNhapNgu, TinhTrangHonNhan, MaTP) values (@MaNV, @MaPhongBan, @MaDoi, @MaTo, @MaLoaiTo, @ID, @Password, @PhanQuyen, @BienChe, @CapBac, @MaChucVu, @CongViecDangLam, @HoTen, @GioiTinh, @NamSinh, @NguyenQuan, @NoiOHienNay, @HoKhau, @CMND, @NgayCapCMND, @NoiCapCMND, @SDTDD, @NguoiBaoLanh, @MoiQuanHeNBL, @NgayVaoCang, @NamVaoST, @NgayNhapNgu, @TinhTrangHonNhan, @MaTP)", Connection.cnn);
                cmd.Parameters.AddWithValue("@MaNV", txtManv.Text);
                if (cbPhongBan.SelectedIndex == -1 || cbPhongBan.Text.ToString() == "")
                {
                    cmd.Parameters.AddWithValue("@MaPhongBan", null);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@MaPhongBan", cbPhongBan.SelectedValue.ToString());
                }
                cmd.Parameters.AddWithValue("@MaDoi", cbDoi.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@MaTo", cbTo.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@MaLoaiTo", cbLoaiTo.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@ID", textBox1.Text);
                cmd.Parameters.AddWithValue("@Password", txtPass.Text);
                cmd.Parameters.AddWithValue("@PhanQuyen", txtPQ.Text);
                cmd.Parameters.AddWithValue("@BienChe", txtBienche.Text);
                cmd.Parameters.AddWithValue("@CapBac", txtcapbac.Text);
                cmd.Parameters.AddWithValue("@CongViecDangLam", txtCongViecDangLam.Text);
                cmd.Parameters.AddWithValue("@HoTen", txtTennv.Text);
                cmd.Parameters.AddWithValue("@GioiTinh", gioitinh);
                string date = datetimeNgaySinh.Value.ToString("yyyy-MM-dd");
                cmd.Parameters.AddWithValue("@NamSinh", date);
                cmd.Parameters.AddWithValue("@NguyenQuan", txtNguyenquan.Text);
                cmd.Parameters.AddWithValue("@NoiOHienNay", txtdiachi.Text);
                cmd.Parameters.AddWithValue("@HoKhau", txtHoKhau.Text);
                cmd.Parameters.AddWithValue("@CMND", txtCMND.Text);
                string dateNgayCapCMND = datetimeCMND.Value.ToString("yyyy-MM-dd");
                cmd.Parameters.AddWithValue("@NgayCapCMND", dateNgayCapCMND);
                cmd.Parameters.AddWithValue("@NoiCapCMND", cbNoiCapCMND.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@NguoiBaoLanh", txtNguoiBaoLanh.Text);
                cmd.Parameters.AddWithValue("@MoiQuanHeNBL", txtMoiQuanHeNBL.Text);
                string dateNgayVaoCang = datetimeNgayVaoCang.Value.ToString("yyyy-MM-dd");
                cmd.Parameters.AddWithValue("@NgayVaoCang", dateNgayVaoCang);
                string dateNamVaoST = datetimeNamVaoST.Value.ToString("yyyy-MM-dd");
                cmd.Parameters.AddWithValue("@NamVaoST", dateNamVaoST);
                string dateNgayNhapNgu = datetimeNgayNhapNgu.Value.ToString("yyyy-MM-dd");
                cmd.Parameters.AddWithValue("@NgayNhapNgu", dateNgayNhapNgu);
                cmd.Parameters.AddWithValue("@TinhTrangHonNhan", cbTinhTrangHonNhan.SelectedText.ToString());
                cmd.Parameters.AddWithValue("@SDTDD", txtSdt.Text);
                cmd.Parameters.AddWithValue("@MaChucVu", cbMaCV.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@MaTP", cbThanhPho.SelectedValue.ToString());
                Connection.moketnoi();
                cmd.ExecuteNonQuery();
                Connection.dongketnoi();
                MessageBox.Show("Bạn đã thêm nhân viên thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtManv.Clear();
                txtTennv.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }
        #region ComBoBox
        void PhongBan()
        {
            Connection.moketnoi();
            SqlDataAdapter dropPhong = new SqlDataAdapter("Select * from _Phong", Connection.cnn);
            DataTable dt = new DataTable();
            dropPhong.Fill(dt);
            cbPhongBan.DataSource = dt;
            cbPhongBan.DisplayMember = "TenPhong";
            cbPhongBan.ValueMember = "MaPhong";
            cbPhongBan.SelectedIndex = -1;
            txtChucVu.Enabled = false;
            Connection.dongketnoi();

        }
        void NoiCapCMND()
        {
            Connection.moketnoi();
            SqlDataAdapter dropNoiCapCMND = new SqlDataAdapter("Select * from _ThanhPho", Connection.cnn);
            DataTable dt = new DataTable();
            dropNoiCapCMND.Fill(dt);
            cbNoiCapCMND.DataSource = dt;
            cbNoiCapCMND.DisplayMember = "TenTP";
            cbNoiCapCMND.ValueMember = "MaTP";
            cbNoiCapCMND.SelectedIndex = -1;
            Connection.dongketnoi();
        }
        void dropChucVu()
        {
            Connection.moketnoi();
            SqlDataAdapter dropChucVu = new SqlDataAdapter("Select * from ChucVu", Connection.cnn);
            DataTable dt = new DataTable();
            dropChucVu.Fill(dt);
            cbMaCV.DataSource = dt;
            cbMaCV.DisplayMember = "ChucVu";
            cbMaCV.ValueMember = "MaChucVu";
            cbMaCV.SelectedIndex = -1;
            Connection.dongketnoi();
        }
        void Doi()
        {
            Connection.moketnoi();
            SqlDataAdapter dropDoi = new SqlDataAdapter("Select * from _Doi", Connection.cnn);
            DataTable dt = new DataTable();
            dropDoi.Fill(dt);
            cbDoi.DataSource = dt;
            cbDoi.DisplayMember = "TenDoi";
            cbDoi.ValueMember = "MaDoi";
            cbDoi.SelectedIndex = -1;
            Connection.dongketnoi();
        }
        void To()
        {
            Connection.moketnoi();
            SqlDataAdapter dropTo = new SqlDataAdapter("Select * from _To", Connection.cnn);
            DataTable dt = new DataTable();
            dropTo.Fill(dt);
            cbTo.DataSource = dt;
            cbTo.DisplayMember = "TenTo";
            cbTo.ValueMember = "MaTo";
            cbTo.SelectedIndex = -1;
            Connection.dongketnoi();
        }
        void LoaiTo()
        {
            Connection.moketnoi();
            SqlDataAdapter dropLoaiTo = new SqlDataAdapter("Select * from _LoaiTo", Connection.cnn);
            DataTable dt = new DataTable();
            dropLoaiTo.Fill(dt);
            cbLoaiTo.DataSource = dt;
            cbLoaiTo.DisplayMember = "TenLoaiTo";
            cbLoaiTo.ValueMember = "MaLoaiTo";
            cbLoaiTo.SelectedIndex = -1;
            Connection.dongketnoi();
        }
        void ThanhPho()
        {
            Connection.moketnoi();
            SqlDataAdapter dropThanhPho = new SqlDataAdapter("Select * from _ThanhPho", Connection.cnn);
            DataTable dt = new DataTable();
            dropThanhPho.Fill(dt);
            cbThanhPho.DataSource = dt;
            cbThanhPho.DisplayMember = "TenTP";
            cbThanhPho.ValueMember = "MaTP";
            cbThanhPho.SelectedIndex = -1;
            Connection.dongketnoi();
        }
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        void cbHonNhan()
        {
            ComboboxItem item = new ComboboxItem();
            item.Text = "";
            //item.Value = 0;
            ComboboxItem item1 = new ComboboxItem();
            item1.Text = "Độc Thân";
            //item1.Value = 1;
            ComboboxItem item2 = new ComboboxItem();
            item2.Text = "Đã kết hôn";
            //item2.Value = 2;
            ComboboxItem item3 = new ComboboxItem();
            item3.Text = "Ly Thân";
            //item3.Value = 3;
            ComboboxItem item4 = new ComboboxItem();
            item4.Text = "Ly Dị";
            //item4.Value = 4;
            ComboboxItem item5 = new ComboboxItem();
            item5.Text = "Goá Chồng";
            //item5.Value = 5;
            ComboboxItem item6 = new ComboboxItem();
            item6.Text = "Goá Vợ";
            //item6.Value = 6;

            cbTinhTrangHonNhan.Items.Add(item);
            cbTinhTrangHonNhan.Items.Add(item1);
            cbTinhTrangHonNhan.Items.Add(item2);
            cbTinhTrangHonNhan.Items.Add(item3);
            cbTinhTrangHonNhan.Items.Add(item4);
            cbTinhTrangHonNhan.Items.Add(item5);
            cbTinhTrangHonNhan.Items.Add(item6);
            cbTinhTrangHonNhan.SelectedIndex = 0;
        }
        #endregion

        private void cbMaCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaCV.SelectedIndex == -1)
            {
                txtChucVu.Text = string.Empty;
            }
            else
            {
                txtChucVu.Text = cbMaCV.SelectedValue.ToString();
            }
        }

        private void txtManv_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = txtManv.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPhongBan.SelectedIndex == -1)
            {
                label31.Text = string.Empty;
            }
            else
            {
                label31.Text = cbPhongBan.SelectedValue.ToString();
            }
        }





    }
}
