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
    public partial class AddClientsForm : Form
    {
        private readonly FitnesAppEntities _context;
        private Card SelectedData;
        public AddClientsForm()
        {
            InitializeComponent();
            _context = new FitnesAppEntities();
        }

        private void FillDataGridView()
        {
            dtgv.DataSource = _context.Cards.Select(c => new
            {
                c.Id,
                c.Registration.Client_Name,
                c.Registration.Client_Surname,
                c.Code
            }).ToList();
        }

        private void ClearAll()
        {
            txtSurname.Text = txtName.Text = txtBarcode.Text = string.Empty;
        }

        private bool CheckAll(string barcode = "")
        {
            string[] UserInfo = { txtBarcode.Text, txtName.Text, txtSurname.Text };
            if (CheckAllField(UserInfo, string.Empty))
            {
                ShowMessage("Fill all inputs", "error");
                return false;
            }
            if (_context.Cards.Any(c => c.Code == barcode ? true : false))
            {
                ShowMessage("Barcode must be unique", "error");
                return false;
            }
            if (txtBarcode.Text.Length != 4)
            {
                ShowMessage("Barcode must be 4 symbol", "error");
                return false;
            }
            return true;
        }

        private void AddClientsForm_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (CheckAll(txtBarcode.Text))
            {
                string Name = txtName.Text;
                string Surname = txtSurname.Text;
                string Barcode = txtBarcode.Text;
                Registration registration = new Registration()
                {
                    Client_Name = Name,
                    Client_Surname = Surname,
                };
                _context.Registrations.Add(registration);
                Card card = new Card()
                {
                    Registration_Id=registration.Id,
                    Code = Barcode
                };
                _context.Cards.Add(card);
                _context.SaveChanges();
                FillDataGridView();
                ClearAll();
            }
            else
            {
                ShowMessage("Error","error");
            }
        }

        private void dtgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = (int)dtgv.Rows[e.RowIndex].Cells[0].Value;
            Card card = _context.Cards.Find(id);

            SelectedData = card;
            txtBarcode.Text = card.Code;
            txtName.Text = card.Registration.Client_Name;
            txtSurname.Text = card.Registration.Client_Surname;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _context.Cards.Remove(SelectedData);
            _context.SaveChanges();
            FillDataGridView();
            ClearAll();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (CheckAll(""))
            {
                SelectedData.Code = txtBarcode.Text;
                SelectedData.Registration.Client_Name = txtName.Text;
                SelectedData.Registration.Client_Surname = txtSurname.Text;
                _context.SaveChanges();
                FillDataGridView();
                ClearAll();
            }
        }
    }
}
