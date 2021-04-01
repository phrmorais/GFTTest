using GFTTest.Core.Utils;
using GFTTest.infra.data.Entity;
using GFTTest.infra.data.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace GFTTest.app
{
    public partial class FrmMain : Form
    {
        private bool _dragging;
        private Point _pointstart_header = new Point(0, 0);
        public List<ITrade> Trades { get; set; }

        public FrmMain()
        {
            InitializeComponent();
            NewTrades();
            FirstTrades();
        }

        private void MenuItemSair_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        #region MINIMIZAR PELO ICONE DA BARRA DE TAREFAS

        private const int WS_MINIMIZEBOX = 0x20000;
        private const int CS_DBLCLKS = 0x8;

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }

        #endregion MINIMIZAR PELO ICONE DA BARRA DE TAREFAS

        #region EVENTOS

        private void PbMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PbClose_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void CloseForm()
        {
            var confirmacao = MessageBox.Show("Do you want to leave?", "Exit", MessageBoxButtons.YesNo);

            if (confirmacao == DialogResult.Yes)
                Application.Exit();
        }

        private void PnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void PnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _pointstart_header = new Point(e.X, e.Y);
        }

        private void PnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && _dragging)
            {
                var p = PointToScreen(e.Location);
                Location = new Point(p.X - _pointstart_header.X, p.Y - _pointstart_header.Y);
            }
        }

        #endregion EVENTOS

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (cbValue.Value == 0)
            {
                MessageBox.Show("Informe o valor");
                return;
            }
            if (string.IsNullOrEmpty(Text))
            {
                MessageBox.Show("Informe o valor");
                return;
            }
            if (Trades is null) NewTrades();
            Trades.Add(new Trade
            {
                Value = (double)cbValue.Value,
                ClientSector = cmbClientSector.Text
            });
            BindGrid();
        }

        private void BindGrid()
        {
            bdsTrade.DataSource = Trades;
            gridView1.RefreshData();
        }

        private void NewTrades()
        {
            Trades = new List<ITrade>();
        }

        private void FirstTrades()
        {
            Trades.AddRange(new List<Trade> {
            new Trade { Value = 2000000, ClientSector = "Private" },
            new Trade { Value = 400000, ClientSector = "Public" },
            new Trade { Value = 500000, ClientSector = "Public" },
            new Trade { Value = 3000000, ClientSector = "Public" }});
            BindGrid();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            NewTrades();
            BindGrid();
        }

        private void BtnAnalyze_Click(object sender, EventArgs e)
        {
            if (Trades.Count == 0)
            {
                MessageBox.Show("Add trade"); return;
            }
            var result = new Category(Trades).GetCategories();
            var jsonSerialiser = new JavaScriptSerializer();
            MessageBox.Show(jsonSerialiser.Serialize(result));
        }
    }
}