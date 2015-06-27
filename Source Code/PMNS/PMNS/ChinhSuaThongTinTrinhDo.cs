namespace PMNS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    using PMNS.Entities.Models;
    using PMNS.Services.Abstract;

    public partial class ChinhSuaThongTinTrinhDo : Form
    {
        #region Properties

        private ThongTinNhanVIen empDetails;

        #endregion

        #region Constructor Or Destructor

        protected readonly IThongTinTrinhDoServices thongTinTrinhDoServices;
        protected readonly ITrinhDoServices trinhDoServices;

        public ChinhSuaThongTinTrinhDo(IThongTinTrinhDoServices thongTinTrinhDoServices, ITrinhDoServices trinhDoServices,
            ThongTinNhanVIen empDetails)
        {
            this.thongTinTrinhDoServices = thongTinTrinhDoServices;
            this.trinhDoServices = trinhDoServices;
            this.empDetails = empDetails;
            InitializeComponent();
        }

        #endregion

        #region Method Event

        private void ChinhSuaThongTinTrinhDo_Load(object sender, EventArgs e)
        {
            InitData();
            if (empDetails.ThongTinTrinhDoes.Count != 0)
            {
                btnFunction.Text = "Sửa";
            }
            else
            {
                MessageBox.Show("Nhân Viên Này Chưa Cập Nhật Thông Tin Học Vấn. Vui Lòng Thêm Thông Tin.",
                    "Thông Báo!",MessageBoxButtons.OK);
                btnFunction.Text = "Thêm";
            }
        }

        private void btnFunction_Click(object sender, EventArgs e)
        {
            if (empDetails.ThongTinTrinhDoes.Count != 0)
            {
                
            }
            else
            {
                
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Method Init

        private void InitData()
        {
            txtMaNV.ReadOnly = true;
            txtTenNV.ReadOnly = true;
            txtMaNV.Text = empDetails.MaNV;
            txtTenNV.Text = empDetails.hoTen;
        }

        private void InitLoaiTrinhDo()
        {
            cbTrinhDo.DataSource = trinhDoServices.GetAllTrinhDo();
            cbTrinhDo.DisplayMember = "TrinhDo1";
            cbTrinhDo.ValueMember = "idTrinhDo";
        }

        #endregion

        #region Method DatetimePicker

        private void datetimeTotNghiep_ValueChanged(object sender, EventArgs e)
        {
            datetimeTotNghiep.Format = DateTimePickerFormat.Custom;
            datetimeTotNghiep.CustomFormat = "dd/MM/yyyy";
            txtThoiGianTotNghiep.Text = datetimeTotNghiep.Text;
        }

        #endregion
    }
}
