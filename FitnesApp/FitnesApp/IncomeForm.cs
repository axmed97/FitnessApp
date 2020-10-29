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
    public partial class IncomeForm : Form
    {
        private readonly FitnesAppEntities _context;

        public IncomeForm()
        {
            InitializeComponent();
            _context = new FitnesAppEntities();
        }

        private void FillIcomeDataGridView()
        {
            dtgvIncomes.DataSource = _context.Incomes.Select(i => new
            {
                i.Id,
                i.Registration.Client_Name,
                i.Registration.Client_Surname,
                i.IncomeMonth,
                i.ClientIncomes
                
            }).ToList();
        }

        private void FillOutcomeDataGridView()
        {
            dtgvOutcomes.DataSource = _context.Outcomes.Select(o => new
            {
                o.Id,
                o.Worker_salary,
                o.Cleaning_Tools
            }).ToList();
        }

        private void IncomeForm_Load(object sender, EventArgs e)
        {
            FillIcomeDataGridView();
            FillOutcomeDataGridView();
        }

        private void MonthValueChange(object sender, EventArgs e)
        {
            txtInTotal.Text = _context.Incomes.Where(i => dtpMin.Value <= i.IncomeMonth && i.IncomeMonth <= dtpMax.Value).Sum(i => i.ClientIncomes).ToString();
            txtOutTotal.Text = _context.Outcomes.Where(o => dtpMin.Value <= o.OutcomeMonth && o.OutcomeMonth <= dtpMax.Value).Sum(o => o.Worker_salary + o.Cleaning_Tools).ToString();
            txtTool.Text = _context.Outcomes.Where(o => dtpMin.Value <= o.OutcomeMonth && o.OutcomeMonth <= dtpMax.Value).Sum(o => o.Cleaning_Tools).ToString();
            txtSalary.Text = _context.Outcomes.Where(o => dtpMin.Value <= o.OutcomeMonth && o.OutcomeMonth <= dtpMax.Value).Sum(o => o.Worker_salary).ToString();
            txtPure.Text = (Convert.ToInt64(txtInTotal.Text) - Convert.ToInt64(txtOutTotal.Text)).ToString();

        }
    }
}
