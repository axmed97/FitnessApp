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
    public partial class OrderForm : Form
    {
        private readonly FitnesAppEntities _context;
        private CardtoPacketService SelectedData;
        public OrderForm()
        {
            InitializeComponent();
            _context = new FitnesAppEntities();
        }

        private void FillDataGridView()
        {
            dtgvPacket.DataSource = _context.CardtoPacketServices.Select(cps => new
            {
                cps.Id,
                cps.Card.Registration.Client_Name,
                cps.Card.Registration.Client_Surname,
                cps.Packet.Packet_Name,
                cps.Service.Service_Name,
                cps.Packet.Packet_Price,
                cps.Service.Service_Price,
                cps.Card.Code
            }).ToList();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            FillDataGridView();
            cmbPacket.Items.AddRange(_context.Packets.Select(p => p.Packet_Name).ToArray());
            cmbService.Items.AddRange(_context.Services.Select(s => s.Service_Name).ToArray());
        }

        private bool CheckAll()
        {
            string[] UserInfo = { txtName.Text, txtBarcode.Text, txtSurname.Text };
            if (CheckAllField(UserInfo, string.Empty))
            {
                ShowMessage("Fill all inputs", "error");
                return false;
            }
            if (!_context.Cards.Any(c => c.Code == txtBarcode.Text))
            {
                ShowMessage("Your name or surname or barcode is wrong!", "error");
                return false;
            }
            if (txtBarcode.Text.Length != 4)
            {
                ShowMessage("Barcode must be 4 symbol", "error");
                return false;
            }
            //if(cmbPacket.Text != null || cmbService.Text != null)
            //{
            //    ShowMessage("error", "error");
            //    return false;
            //}
            return true;
        }

        private void ClearAllField()
        {
            txtPacketPrice.Text = txtServicePrice.Text = cmbPacket.Text = cmbService.Text = txtName.Text = txtSurname.Text= string.Empty;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (CheckAll())
            {
                string Name = txtName.Text;
                string Surname = txtSurname.Text;
                string Barcode = txtBarcode.Text;
                string Packet = cmbPacket.Text;
                string Service = cmbService.Text;
                string ServicePrice = txtServicePrice.Text;
                string PacketPrice = txtPacketPrice.Text;
                Registration registration = new Registration()
                {
                    Client_Name = Name,
                    Client_Surname = Surname
                };
                _context.Registrations.Add(registration);
                Card card = new Card()
                {
                    Registration_Id = registration.Id,
                    Code = Barcode
                };
                Service service = _context.Services.Where(p => p.Service_Name == cmbService.Text).FirstOrDefault();
                Packet packet = _context.Packets.Where(p => p.Packet_Name == cmbPacket.Text).FirstOrDefault();
                if (packet != null)
                {
                    CardtoPacketService cardtoPacketService = new CardtoPacketService()
                    {
                        Card_Id = _context.Cards.Where(c => c.Code == txtBarcode.Text).First().Id,
                        //Packet_Id = packet.Id,
                        //Service_Id = service.Id
                        Packet_Id = packet.Id,
                        Service_Id = null
                    };
                    Income income = new Income()
                    {
                        Client_Id = _context.Cards.Where(c => c.Code == txtBarcode.Text).First().Registration.Id,
                        IncomeMonth = DateTime.Now,
                        ClientIncomes = (int)packet.Packet_Price
                    };
                    _context.Incomes.Add(income);
                    _context.CardtoPacketServices.Add(cardtoPacketService);
                }
                if (service != null)
                {
                    CardtoPacketService cardtoPacketService = new CardtoPacketService()
                    {
                        Card_Id = _context.Cards.Where(c => c.Code == txtBarcode.Text).First().Id,
                        //Packet_Id = packet.Id,
                        //Service_Id = service.Id
                        Packet_Id = null,
                        Service_Id = service.Id
                    };
                    Income income = new Income()
                    {
                        Client_Id = _context.Cards.Where(c => c.Code == txtBarcode.Text).First().Registration.Id,
                        IncomeMonth = DateTime.Now,
                        ClientIncomes = (int)service.Service_Price
                    };
                    _context.Incomes.Add(income);
                    _context.CardtoPacketServices.Add(cardtoPacketService);
                }
                _context.SaveChanges();
                FillDataGridView();
                ClearAllField();
            }
        }

        private void dtgvPacket_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = (int)dtgvPacket.Rows[e.RowIndex].Cells[0].Value;
            CardtoPacketService cardtoPacketService = _context.CardtoPacketServices.Find(id);
            SelectedData = cardtoPacketService;
            txtBarcode.Text = cardtoPacketService.Card.Code;
            txtName.Text = cardtoPacketService.Card.Registration.Client_Name;
            txtSurname.Text = cardtoPacketService.Card.Registration.Client_Surname;
            txtPacketPrice.Text = cardtoPacketService.Packet.Packet_Price.ToString();
            txtServicePrice.Text = cardtoPacketService.Service.Service_Price.ToString();
            cmbPacket.Text = cardtoPacketService.Packet.Packet_Name;
            cmbService.Text = cardtoPacketService.Service.Service_Name;
        }

        private void cmbPacket_SelectedIndexChanged(object sender, EventArgs e)
        {
            Packet packet = _context.Packets.Where(p => p.Packet_Name == cmbPacket.Text).FirstOrDefault();
            txtPacketPrice.Text = packet.Packet_Price.ToString() + "AZN";
            if (cmbPacket.Text != null)
            {
                cmbService.Text = string.Empty;
                txtServicePrice.Text = string.Empty;
            }
        }

        private void cmbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            Service service = _context.Services.Where(s => s.Service_Name == cmbService.Text).FirstOrDefault();
            txtServicePrice.Text = service.Service_Price.ToString() + "AZN";
            if (cmbService.Text != null)
            {
                cmbPacket.Text = "";
                txtPacketPrice.Text = string.Empty;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _context.CardtoPacketServices.Remove(SelectedData);
            _context.SaveChanges();
            FillDataGridView();
            ClearAllField();
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            var x = _context.Cards.Where(c => c.Code== txtBarcode.Text).FirstOrDefault();
            if (x != null)
            {
                txtName.Text = x.Registration.Client_Name;
                txtSurname.Text = x.Registration.Client_Surname;
            }
            else
            {
                txtName.Text = txtSurname.Text = string.Empty;
            }
        }
    }
}
