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
    public partial class PacketForm : Form
    {
        private readonly FitnesAppEntities _context;
        private Packet SelectedData;
        public PacketForm()
        {
            InitializeComponent();
            _context = new FitnesAppEntities();
        }

        private void FillDataGridView()
        {
            dtgv.DataSource = _context.Packets.Select(s => new
            {
                s.Id,
                s.Packet_Name,
                s.Packet_Price
            }).ToList();
        }

        private bool CheckAll(string packet = "")
        {
            string[] UserInfo = { txtPacket.Text };
            if (CheckAllField(UserInfo, string.Empty))
            {
                ShowMessage("Fill all inputs", "error");
                return false;
            }
            if (_context.Packets.Any(s => s.Packet_Name == packet ? true : false))
            {
                ShowMessage("Packet name must be unique", "error");
                return false;
            }
            return true;
        }

        private void ClearAllField()
        {
            txtPacket.Text = string.Empty;
            nmudPrice.Value = 0;
        }

        private void PacketForm_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void dtgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = (int)dtgv.Rows[e.RowIndex].Cells[0].Value;

            Packet packet = _context.Packets.Find(id);

            SelectedData = packet;
            txtPacket.Text = packet.Packet_Name;
            nmudPrice.Value = (decimal)packet.Packet_Price;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (CheckAll(txtPacket.Text))
            {
                string PacketName = txtPacket.Text;
                int PacketPrice = (int)nmudPrice.Value;
                Packet packet = new Packet()
                {
                    Packet_Name = PacketName,
                    Packet_Price = PacketPrice
                };
                _context.Packets.Add(packet);
                _context.SaveChanges();
                ClearAllField();
                FillDataGridView();
            };
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (CheckAll())
            {
                SelectedData.Packet_Name = txtPacket.Text;
                SelectedData.Packet_Price = nmudPrice.Value;
                _context.SaveChanges();
                ClearAllField();
                FillDataGridView();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _context.Packets.Remove(SelectedData);
            _context.SaveChanges();
            ClearAllField();
            FillDataGridView();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAllField();
            FillDataGridView();
        }
    }
}
