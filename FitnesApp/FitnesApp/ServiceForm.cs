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
    public partial class ServiceForm : Form
    {
        private readonly FitnesAppEntities _context;
        private Service SelectedData;
        public ServiceForm()
        {
            InitializeComponent();
            _context = new FitnesAppEntities();
        }

        private void FillDataGridView()
        {
            dtgv.DataSource = _context.Services.Select(s => new
            {
                s.Id,
                s.Service_Name,
                s.Service_Price
            }).ToList();
        }

        private bool CheckAll(string service = "")
        {
            string[] UserInfo = { txtService.Text };
            if(CheckAllField(UserInfo, string.Empty))
            {
                ShowMessage("Fill all inputs", "error");
                return false;
            }   
            if(_context.Services.Any(s => s.Service_Name == service ? true : false))
            {
                ShowMessage("Service name must be unique", "error");
                return false;
            }
            return true;
        }

        private void ClearAllField()
        {
            txtService.Text = string.Empty;
            nmudPrice.Value = 0;
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            FillDataGridView();
            //nmudPrice.Maximum = (int)_context.Services.Max(s => s.Service_Price);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (CheckAll(txtService.Text))
            {
                string ServiceName = txtService.Text;
                int ServicePrice = (int)nmudPrice.Value;
                Service service = new Service()
                {
                    Service_Name = ServiceName,
                    Service_Price = ServicePrice
                };
                _context.Services.Add(service);
                _context.SaveChanges();
                ClearAllField();
                FillDataGridView();
            };
                
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAllField();
            FillDataGridView();
        }

        private void dtgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = (int)dtgv.Rows[e.RowIndex].Cells[0].Value;

            Service service = _context.Services.Find(id);

            SelectedData = service;
            txtService.Text = service.Service_Name;
            nmudPrice.Value = (decimal)service.Service_Price;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _context.Services.Remove(SelectedData);
            _context.SaveChanges();
            ClearAllField();
            FillDataGridView();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (CheckAll())
            {
                SelectedData.Service_Name = txtService.Text;
                SelectedData.Service_Price = nmudPrice.Value;
                _context.SaveChanges();
                ClearAllField();
                FillDataGridView();
            }
        }
    }
}

