using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitnesApp.Model;
using static FitnesApp.Extension;

namespace FitnesApp
{
    public partial class WokersInfo : Form
    {
        private readonly FitnesAppEntities _context;
        public WokersInfo()
        {
            InitializeComponent();
            _context = new FitnesAppEntities();
        }

        private void FillDataGridView()
        {
            dtgv.DataSource = _context.Users.Select(u => new
            {
                u.Id,
                u.Username,
                u.Password
            }).ToList();
        }

        private void WokersInfo_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }
    }
}
