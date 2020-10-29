using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnesApp
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void serviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceForm serviceForm = new ServiceForm();
            serviceForm.ShowDialog();
        }

        private void packetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PacketForm packetForm = new PacketForm();
            packetForm.ShowDialog();
        }

        private void serviceToPacketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceToPacketForm serviceToPacketForm = new ServiceToPacketForm();
            serviceToPacketForm.ShowDialog();
        }

        private void workerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WokersInfo wokersInfo = new WokersInfo();
            wokersInfo.ShowDialog();
        }

        private void incomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IncomeForm incomeForm = new IncomeForm();
                    incomeForm.ShowDialog();
        }

        private void outcomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutcomeForm outcomeForm = new OutcomeForm();
            outcomeForm.ShowDialog();
        }
    }
}
