using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMNS
{
    public partial class REPORT : Form
    {
        public REPORT()
        {
            InitializeComponent();
        }

        private void REPORT_Load(object sender, EventArgs e)
        {
            comboGioiTinh.Enabled = false;
            comboDoTuoi.Enabled = false;
            comboBienChe.Enabled = false;
            comboPhongBan.Enabled = false;
            comboDoi.Enabled = false;
            comboTo.Enabled = false;
            comboLoaiTo.Enabled = false;
            comboCapBac.Enabled = false;
            comboChucVu.Enabled = false;
            comboLoaiHD.Enabled = false;
            comboNoiO.Enabled = false;
            comboTrinhDo.Enabled = false;
            txtNamVaoCang.Enabled = false;
            txtTongQuanSo.Enabled = false;
            txtNam.Enabled = false;
            txtNu.Enabled = false;
            txtTCLD.Enabled = false;
            txtTCKT.Enabled = false;
            txtKHKD.Enabled = false;
            txtDD.Enabled = false;
            txtBanGD.Enabled = false;
            txtCGXD.Enabled = false;
            txtCT.Enabled = false;
            txtHCQS.Enabled = false;
        }
        private void cboxGioiTinh_CheckedChanged(object sender, EventArgs e)
        {
            if(cboxGioiTinh.Checked == true)
            {
                comboGioiTinh.Enabled = true;
            }
            else
            {
                comboGioiTinh.Enabled = false;
            }
        }

        private void cboxDoTuoi_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxDoTuoi.Checked == true)
            {
                comboDoTuoi.Enabled = true;
            }
            else
            {
                comboDoTuoi.Enabled = false;
            }
        }

        private void cboxBienChe_CheckedChanged(object sender, EventArgs e)
        {
            if(cboxBienChe.Checked == true)
            {
                comboBienChe.Enabled = true;
            }
            else
            {
                comboBienChe.Enabled = false;
            }
        }

        private void cboxPhongBan_CheckedChanged(object sender, EventArgs e)
        {
            if(cboxPhongBan.Checked==true)
            {
                comboPhongBan.Enabled = true;
            }
            else
            {
                comboPhongBan.Enabled = false;
            }
        }

        private void cboxDoi_CheckedChanged(object sender, EventArgs e)
        {
            if(cboxDoi.Checked == true)
            {
                comboDoi.Enabled = true;
            }
            else
            {
                comboDoi.Enabled = false;
            }
        }

        private void cboxTo_CheckedChanged(object sender, EventArgs e)
        {
            if(cboxTo.Checked == true)
            {
                comboTo.Enabled = true;
            }
            else
            {
                comboTo.Enabled = false;
            }
        }

        private void cboxLoaiTo_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxLoaiTo.Checked == true)
            {
                comboLoaiTo.Enabled = true;
            }
            else
            {
                comboLoaiTo.Enabled = false;
            }
        }

        private void cboxCapBac_CheckedChanged(object sender, EventArgs e)
        {
            if(cboxCapBac.Checked==true)
            {
                comboCapBac.Enabled = true;
            }
            else
            {
                comboCapBac.Enabled = false;
            }
        }

        private void cboxChucVu_CheckedChanged(object sender, EventArgs e)
        {
            if(cboxChucVu.Checked == true)
            {
                comboChucVu.Enabled = true;
            }
            else
            {
                comboChucVu.Enabled = false;
            }
        }

        private void cboxLoaiHD_CheckedChanged(object sender, EventArgs e)
        {
            if(cboxLoaiHD.Checked == true)
            {
                comboLoaiHD.Enabled = true;
            }
            else
            {
                comboLoaiHD.Enabled = false;
            }
        }

        private void cboxNoiO_CheckedChanged(object sender, EventArgs e)
        {
            if(cboxNoiO.Checked==true)
            {
                comboNoiO.Enabled = true;
            }
            else
            {
                comboNoiO.Enabled = false;
            }
        }

        private void cboxTrinhDo_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxTrinhDo.Checked == true)
            {
                comboTrinhDo.Enabled = true;
            }
            else
            {
                comboTrinhDo.Enabled = false;
            }
        }

        private void cboxNamVaoCang_CheckedChanged(object sender, EventArgs e)
        {
            if(cboxNamVaoCang.Checked==true)
            {
                txtNamVaoCang.Enabled = true;
            }
            else
            {
                txtNamVaoCang.Enabled = false;
            }
        }


    }
}
