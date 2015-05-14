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
    public partial class QuanLyBienChe : Form
    {
        protected readonly IBienCheServices _bienCheServices;
        public QuanLyBienChe(IBienCheServices bienCheServices)
        {
            this._bienCheServices = bienCheServices;
            InitializeComponent();
        }

        #region Form's Event
        private void QuanLyBienChe_Load(object sender, EventArgs e)
        {
            InitGridView();
            dataGridChucVu.CurrentCell = null;
        }
        #endregion

        #region Init
        public void InitGridView()
        {
            dataGridChucVu.DataSource = _bienCheServices.GetAllBienChe().OrderBy(x => x.maBienChe).ToList().Select(x =>
                new
                {
                    ID = x.idBienChe,
                    MaBienChe = x.maBienChe,
                    TenBienChe = x.bienChe1
                }).ToList();
            dataGridChucVu.Columns[0].Visible = false;
        }

        private void btnThemBienChe_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaBienChe_Click(object sender, EventArgs e)
        {

        }
        #endregion        
    }
}
