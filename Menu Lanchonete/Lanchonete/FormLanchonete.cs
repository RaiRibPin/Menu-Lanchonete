using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace Lanchonete
{
    public partial class FormLanchonete : Form
    {
        int contItem = 0;
        public FormLanchonete()
        {
            InitializeComponent();
        }

        private void FormLanchonete_Load(object sender, EventArgs e)
        {
            tabControl_Detalhes.Enabled = false;
        }
        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            tabControl_Detalhes.Enabled = true;
            if (lblPedidoDados.Text == "")
            {
                lblPedidoDados.Text = "1";
            }
            else
            {
                lblPedidoDados.Text = (int.Parse(lblPedidoDados.Text) + 1).ToString();
            }

        }

        private void btnLançar_Click(object sender, EventArgs e)
        {
            tabControl_Detalhes.SelectedTab = tabItens;
        }

        private void cmbLanche_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPreçoLanche.SelectedIndex = cmbLanche.SelectedIndex;
            txtQtd.Text = "1";
            rbNão.Checked = true;

            txtQtd.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Hora: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void txtQtdB_TextChanged(object sender, EventArgs e)
        {
            if (txtQtdB.Text == "" || txtQtdB.Text == "0")
            {
                txtQtdB.Text = "1";
            }

            lblTotalB.Text = (double.Parse(cmbPreçoBebida.Text.Substring(2)) * int.Parse(txtQtdB.Text)).ToString("C");
        }
        private void txtQtd_TextChanged(object sender, EventArgs e)
        {
            if (txtQtd.Text == "0" || txtQtd.Text == "")
            {
                txtQtd.Text = "1";
            }
            lblTotal.Text = (double.Parse(cmbPreçoLanche.Text.Substring(2)) * int.Parse(txtQtd.Text)).ToString("C");
            lblTotalPedido.Text = lblTotal.Text.Substring(2);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            dgvItens.Rows.Add(++contItem, cmbLanche.SelectedItem, txtQtd.Text, cmbPreçoLanche.SelectedItem, lblTotal.Text, lblTotal.Text.Substring(2));
            lblTotalPedido.Text =
              (double.Parse(lblTotalPedido.Text.Substring(3)) +
              double.Parse(lblTotal.Text.Substring(2))+double.Parse(lblTotalB.Text.Substring(2))).ToString("C");
            dgvItens.FirstDisplayedScrollingRowIndex = dgvItens.Rows.Count - 1;

            if (rbSim.Checked)
            {
                foreach (CheckBox cb in gbOpções.Controls)
                {
                    if (cb.Checked)
                    {
                        dgvItens.Rows.Add("Condi", cb.Text, "", "", "");
                    }
                    cb.Checked = false;
                }
            }
            if (rbSimB.Checked)
            {
                dgvItens.Rows.Add("Bebi", cmbBebida.Text, "", "", "");
            }
            rbNãoB.Checked = true;
            rbNão.Checked = true;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnResumo_Click(object sender, EventArgs e)
        {
            tabControl_Detalhes.SelectedTab = tabResumo;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tabControl_Detalhes.SelectedTab = tabDados;
            tabControl_Detalhes.Enabled = false;
            lblPedidoDados.Text = "";
            dgvItens.Rows.Clear();
            rbNão.Checked = true;
            rbNãoB.Checked = true;
            cmbLanche.SelectedIndex = 0;
            foreach (CheckBox cb in gbOpções.Controls)
            {
                cb.Checked = false;
            }
        }

        private void rbSim_CheckedChanged(object sender, EventArgs e)
        {
            gbOpções.Enabled = true;
        }

        private void rbNão_CheckedChanged(object sender, EventArgs e)
        {
            gbOpções.Enabled = false;
        }

        private void rbSimB_CheckedChanged(object sender, EventArgs e)
        {
            gbBebidas.Enabled = true;
        }

        private void rbNãoB_CheckedChanged(object sender, EventArgs e)
        {
            gbBebidas.Enabled = false;
        }

        private void tabControl_Detalhes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPedidoItens.Text = lblPedidoDados.Text;
        }

        private void btnGravarPedidoXML_Click(object sender, EventArgs e)
        {
            //Define o caminho do arquivo XML
            string caminhoArquivoXml = @"pedido.XML";
            //Cria um novo arquivo XML
            using (XmlWriter writer = XmlWriter.Create(caminhoArquivoXml, new XmlWriterSettings { Indent = true }))
            {
                //inicia o documento XML
                writer.WriteStartDocument();

                writer.WriteStartElement("Pedido");

                writer.WriteElementString("NumeroPedido", lblPedidoItens.Text);
                writer.WriteElementString("Cliente", txtCliente.Text);
                writer.WriteElementString("DataPedido", dtpDataPed.Value.ToString("yyyy-MM-dd HH:mm:ss")); // Formato de 24h
                writer.WriteElementString("TotalPedido", lblTotalPedido.Text);
                writer.WriteElementString("Observação", txtObs.Text);
                writer.WriteStartElement("Itens");
                foreach (DataGridViewRow row in dgvItens.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        writer.WriteStartElement("Item");

                        writer.WriteElementString("NumeroItem", row.Cells["colItem"].Value?.ToString());
                        writer.WriteElementString("Descricao", row.Cells["colDescricao"].Value?.ToString());
                        writer.WriteElementString("Quantidade", row.Cells["colQtd"].Value?.ToString());
                        writer.WriteElementString("PrecoUnitario", row.Cells["colUnit"].Value?.ToString());
                        writer.WriteElementString("Total", row.Cells["colTotal"].Value?.ToString());

                        writer.WriteEndElement();
                    }
                }
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndDocument();

            }
        }

        private void cmbBebida_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPreçoBebida.SelectedIndex = cmbBebida.SelectedIndex;
            txtQtdB.Text = "1";
            txtQtdB.Focus();
        }

        private void GravarPedidoTXT_Click(object sender, EventArgs e)
        {
            File.Create("pedido.txt").Close();
            using (StreamWriter np = File.AppendText("pedido.txt"))
            {
                np.WriteLine("Pedido nº " + lblPedidoItens.Text);
                np.WriteLine("Nome do Cliente: " + txtCliente.Text);
                np.WriteLine("Obs: " + txtObs.Text);
                np.WriteLine("Data do Pedido: " + dtpDataPed.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                np.WriteLine("");
                np.WriteLine("Itens:");
                np.WriteLine("");
                foreach (DataGridViewRow row in dgvItens.Rows)
                    if (!row.IsNewRow)
                    {
                        np.WriteLine("Número: " + row.Cells["colItem"].Value?.ToString());
                        np.WriteLine("Descrição: " + row.Cells["colDescricao"].Value?.ToString());
                        np.WriteLine("Quantidade: " + row.Cells["colQtd"].Value?.ToString());
                        np.WriteLine("Preço Unitário: " + row.Cells["colUnit"].Value?.ToString());
                        np.WriteLine("Total: " + row.Cells["colTotal"].Value?.ToString());
                        np.WriteLine("");
                    }
            }
        }
        
    }
}
