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
    public partial class ServiceToPacketForm : Form
    {
        private readonly FitnesAppEntities _context;
        private ServicetoPacket SelectedData;

        public ServiceToPacketForm()
        {
            InitializeComponent();
            _context = new FitnesAppEntities();
        }

        private void FillDataGridView()
        {
            dtgv.DataSource = _context.ServicetoPackets.Select(stp => new 
            { 
                stp.Id,
                stp.Packet.Packet_Name,
                stp.Service.Service_Name
            }).ToList();
        }

        private bool CheckAll()
        {
            string[] UserInfo = { cmbPacket.Text };
            if(CheckAllField(UserInfo, string.Empty))
            {
                ShowMessage("Fill all field", "error");
                return false;
            }
            if(checkedListBox.SelectedItem == null)
            {
                ShowMessage("You must select minimum one service", "error");
                return false;
            }
            return true;
        }

        private void ClearAllField()
        {
            cmbPacket.Text = string.Empty;
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemChecked(i, false);
            }
        }

        private void ServiceToPacketForm_Load(object sender, EventArgs e)
        {
            FillDataGridView();
            checkedListBox.Items.AddRange(_context.Services.Select(clb => clb.Service_Name).ToArray());
            cmbPacket.Items.AddRange(_context.Packets.Select(p => p.Packet_Name).ToArray());
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (CheckAll())
            {
                int Packetid = _context.Packets.Where(p => p.Packet_Name == cmbPacket.Text).First().Id;
                foreach (var item in checkedListBox.CheckedItems)
                {
                    int id = _context.Services.FirstOrDefault(s => s.Service_Name == item.ToString()).Id;
                    if(!_context.ServicetoPackets.Where(stp => stp.Packet_Id == Packetid).Any(c => c.Service_Id == id))
                    {
                        _context.ServicetoPackets.Add(new ServicetoPacket()
                        {
                            Service_Id = id,
                            Packet_Id = Packetid
                        });
                    }
                }
                _context.SaveChanges();
                FillDataGridView();
                ClearAllField();
            }
        }

        private void dtgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = (int)dtgv.Rows[e.RowIndex].Cells[0].Value;
            ServicetoPacket servicetoPacket = _context.ServicetoPackets.Find(id);
            SelectedData = servicetoPacket;
            cmbPacket.Text = servicetoPacket.Packet.Packet_Name;
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemCheckState(i, CheckState.Unchecked);
                foreach (var items in _context.ServicetoPackets.Where(sp=>sp.Packet_Id==servicetoPacket.Packet_Id).ToList())
                {
                    if (checkedListBox.Items[i].ToString() == items.Service.Service_Name)
                    {
                        checkedListBox.SetItemCheckState(i, CheckState.Checked);
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAllField();
            FillDataGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox.CheckedItems)
            {
                int id = _context.ServicetoPackets.FirstOrDefault(c => c.Service.Service_Name == item.ToString()).Id;
                ServicetoPacket servicetoPacket = _context.ServicetoPackets.Find(id);
                _context.ServicetoPackets.Remove(servicetoPacket);
            }
            _context.SaveChanges();
            FillDataGridView();
            ClearAllField();
        }

        //private void btnEdit_Click(object sender, EventArgs e)
        //{
        //    if (CheckAll())
        //    {
        //        SelectedData.Packet_Id = _context.Packets.First(p => p.Packet_Name == cmbPacket.Text).Id;
        //        foreach (var item in checkedListBox.SelectedItems)
        //        {
        //            SelectedData.Service_Id = _context.Services.First(s => s.Service_Name == item.ToString()).Id;
        //            _context.SaveChanges();
        //        }
        //        FillDataGridView();
        //        ClearAllField();
        //    }
        //}
    }
}
