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

namespace PMNS
{
    public partial class HopDongLaoDong : Form
    {
        protected readonly INhanVienServices _nhanVienServices;
        protected readonly IHopDongServices _hopDongServices;

        public HopDongLaoDong(INhanVienServices nhanVienServices,IHopDongServices hopDongServices)
        {
            this._nhanVienServices = nhanVienServices;
            this._hopDongServices = hopDongServices;
            InitializeComponent();
        }

        private void HopDongLaoDong_Load(object sender, EventArgs e)
        {

        }

        private void InitGridView()
        {

        }
    }
}
