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
    public partial class OutcomeForm : Form
    {
        private readonly FitnesAppEntities _context;
        public OutcomeForm()
        {
            InitializeComponent();
            _context = new FitnesAppEntities();
        }

        private void FillDataGridView()
        {
            dtgv.DataSource = _context.Outcomes.Select(o => new
            {
                o.Id,
                o.OutcomeMonth,
                o.Worker_salary,
                o.Cleaning_Tools
            }).ToList();
        }

        private void OutcomeForm_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            decimal Tool = nmudTool.Value;
            decimal Salary = nmudSalary.Value;
            Outcome outcome = new Outcome()
            {
                Cleaning_Tools = Tool,
                Worker_salary = Salary,
                OutcomeMonth = DateTime.Now
            };
            _context.Outcomes.Add(outcome);
            _context.SaveChanges();
            FillDataGridView();
        }

        private void dtgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
