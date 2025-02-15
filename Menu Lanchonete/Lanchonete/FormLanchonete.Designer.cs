
namespace Lanchonete
{
    partial class FormLanchonete
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl_Detalhes = new System.Windows.Forms.TabControl();
            this.tabDados = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.dtpDataPed = new System.Windows.Forms.DateTimePicker();
            this.lblHora = new System.Windows.Forms.Label();
            this.btnLançar = new System.Windows.Forms.Button();
            this.tabData = new System.Windows.Forms.Label();
            this.lblObs = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblPedidoDados = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.tabItens = new System.Windows.Forms.TabPage();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalPedido = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPedidoItens = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbNão = new System.Windows.Forms.RadioButton();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.rbNãoB = new System.Windows.Forms.RadioButton();
            this.rbSimB = new System.Windows.Forms.RadioButton();
            this.gbOpções = new System.Windows.Forms.GroupBox();
            this.checkBbq = new System.Windows.Forms.CheckBox();
            this.checkBPalha = new System.Windows.Forms.CheckBox();
            this.checkMInglês = new System.Windows.Forms.CheckBox();
            this.checkPimenta = new System.Windows.Forms.CheckBox();
            this.checkMaionese = new System.Windows.Forms.CheckBox();
            this.checkMostarda = new System.Windows.Forms.CheckBox();
            this.checkKetchup = new System.Windows.Forms.CheckBox();
            this.gbBebidas = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQtdB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPreçoBebida = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmbBebida = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbLanche = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.TextBox();
            this.cmbPreçoLanche = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabResumo = new System.Windows.Forms.TabPage();
            this.lstResumo = new System.Windows.Forms.ListBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravarPedidoXML = new System.Windows.Forms.Button();
            this.btnResumo = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnNovoPedido = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GravarPedidoTXT = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTotalB = new System.Windows.Forms.TextBox();
            this.tabControl_Detalhes.SuspendLayout();
            this.tabDados.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.gbOpções.SuspendLayout();
            this.gbBebidas.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabResumo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Detalhes
            // 
            this.tabControl_Detalhes.Controls.Add(this.tabDados);
            this.tabControl_Detalhes.Controls.Add(this.tabItens);
            this.tabControl_Detalhes.Controls.Add(this.tabResumo);
            this.tabControl_Detalhes.Location = new System.Drawing.Point(19, 130);
            this.tabControl_Detalhes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl_Detalhes.Name = "tabControl_Detalhes";
            this.tabControl_Detalhes.SelectedIndex = 0;
            this.tabControl_Detalhes.Size = new System.Drawing.Size(988, 327);
            this.tabControl_Detalhes.TabIndex = 6;
            this.tabControl_Detalhes.SelectedIndexChanged += new System.EventHandler(this.tabControl_Detalhes_SelectedIndexChanged);
            // 
            // tabDados
            // 
            this.tabDados.Controls.Add(this.groupBox2);
            this.tabDados.Location = new System.Drawing.Point(4, 25);
            this.tabDados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDados.Name = "tabDados";
            this.tabDados.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDados.Size = new System.Drawing.Size(980, 298);
            this.tabDados.TabIndex = 0;
            this.tabDados.Text = "Dados do Pedido";
            this.tabDados.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Orange;
            this.groupBox2.Controls.Add(this.txtObs);
            this.groupBox2.Controls.Add(this.txtCliente);
            this.groupBox2.Controls.Add(this.dtpDataPed);
            this.groupBox2.Controls.Add(this.lblHora);
            this.groupBox2.Controls.Add(this.btnLançar);
            this.groupBox2.Controls.Add(this.tabData);
            this.groupBox2.Controls.Add(this.lblObs);
            this.groupBox2.Controls.Add(this.lblCliente);
            this.groupBox2.Controls.Add(this.lblPedidoDados);
            this.groupBox2.Controls.Add(this.label);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(973, 274);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(137, 124);
            this.txtObs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(304, 22);
            this.txtObs.TabIndex = 12;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(137, 76);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(304, 22);
            this.txtCliente.TabIndex = 11;
            // 
            // dtpDataPed
            // 
            this.dtpDataPed.Location = new System.Drawing.Point(137, 190);
            this.dtpDataPed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDataPed.Name = "dtpDataPed";
            this.dtpDataPed.Size = new System.Drawing.Size(304, 22);
            this.dtpDataPed.TabIndex = 10;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(132, 224);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 25);
            this.lblHora.TabIndex = 9;
            // 
            // btnLançar
            // 
            this.btnLançar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLançar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLançar.Location = new System.Drawing.Point(621, 217);
            this.btnLançar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLançar.Name = "btnLançar";
            this.btnLançar.Size = new System.Drawing.Size(167, 42);
            this.btnLançar.TabIndex = 8;
            this.btnLançar.Text = "Lançar Itens ->";
            this.btnLançar.UseVisualStyleBackColor = false;
            this.btnLançar.Click += new System.EventHandler(this.btnLançar_Click);
            // 
            // tabData
            // 
            this.tabData.AutoSize = true;
            this.tabData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabData.Location = new System.Drawing.Point(51, 188);
            this.tabData.Name = "tabData";
            this.tabData.Size = new System.Drawing.Size(64, 25);
            this.tabData.TabIndex = 6;
            this.tabData.Text = "Data:";
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.Location = new System.Drawing.Point(51, 121);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(59, 25);
            this.lblObs.TabIndex = 4;
            this.lblObs.Text = "Obs:";
            this.lblObs.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(37, 73);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(87, 25);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblPedidoDados
            // 
            this.lblPedidoDados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPedidoDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidoDados.Location = new System.Drawing.Point(137, 18);
            this.lblPedidoDados.Name = "lblPedidoDados";
            this.lblPedidoDados.Size = new System.Drawing.Size(102, 41);
            this.lblPedidoDados.TabIndex = 1;
            this.lblPedidoDados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(7, 23);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(115, 25);
            this.label.TabIndex = 0;
            this.label.Text = "Pedido Nº:";
            // 
            // tabItens
            // 
            this.tabItens.BackColor = System.Drawing.Color.Orange;
            this.tabItens.Controls.Add(this.dgvItens);
            this.tabItens.Controls.Add(this.lblTotalPedido);
            this.tabItens.Controls.Add(this.label2);
            this.tabItens.Controls.Add(this.lblPedidoItens);
            this.tabItens.Controls.Add(this.label3);
            this.tabItens.Controls.Add(this.groupBox4);
            this.tabItens.Location = new System.Drawing.Point(4, 25);
            this.tabItens.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabItens.Name = "tabItens";
            this.tabItens.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabItens.Size = new System.Drawing.Size(980, 298);
            this.tabItens.TabIndex = 1;
            this.tabItens.Text = "Itens";
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItem,
            this.colDescricao,
            this.colQtd,
            this.colUnit,
            this.colTotal});
            this.dgvItens.Location = new System.Drawing.Point(483, 51);
            this.dgvItens.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersWidth = 62;
            this.dgvItens.RowTemplate.Height = 28;
            this.dgvItens.Size = new System.Drawing.Size(474, 196);
            this.dgvItens.TabIndex = 7;
            // 
            // colItem
            // 
            this.colItem.HeaderText = "Item";
            this.colItem.MinimumWidth = 8;
            this.colItem.Name = "colItem";
            this.colItem.ReadOnly = true;
            this.colItem.Width = 30;
            // 
            // colDescricao
            // 
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.MinimumWidth = 8;
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            this.colDescricao.Width = 80;
            // 
            // colQtd
            // 
            this.colQtd.HeaderText = "Qtd";
            this.colQtd.MinimumWidth = 8;
            this.colQtd.Name = "colQtd";
            this.colQtd.ReadOnly = true;
            this.colQtd.Width = 30;
            // 
            // colUnit
            // 
            this.colUnit.HeaderText = "$Unit";
            this.colUnit.MinimumWidth = 8;
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            this.colUnit.Width = 60;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.MinimumWidth = 8;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            this.colTotal.Width = 90;
            // 
            // lblTotalPedido
            // 
            this.lblTotalPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPedido.Location = new System.Drawing.Point(828, 254);
            this.lblTotalPedido.Name = "lblTotalPedido";
            this.lblTotalPedido.Size = new System.Drawing.Size(128, 42);
            this.lblTotalPedido.TabIndex = 6;
            this.lblTotalPedido.Text = "?";
            this.lblTotalPedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(760, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total:";
            // 
            // lblPedidoItens
            // 
            this.lblPedidoItens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPedidoItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidoItens.ForeColor = System.Drawing.Color.White;
            this.lblPedidoItens.Location = new System.Drawing.Point(646, 12);
            this.lblPedidoItens.Name = "lblPedidoItens";
            this.lblPedidoItens.Size = new System.Drawing.Size(98, 32);
            this.lblPedidoItens.TabIndex = 4;
            this.lblPedidoItens.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(524, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pedido Nº";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Orange;
            this.groupBox4.Controls.Add(this.btnRemover);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.btnAdicionar);
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Controls.Add(this.gbOpções);
            this.groupBox4.Controls.Add(this.gbBebidas);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(7, 5);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(458, 291);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Escolha:";
            // 
            // btnRemover
            // 
            this.btnRemover.AutoSize = true;
            this.btnRemover.Location = new System.Drawing.Point(7, 249);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(125, 28);
            this.btnRemover.TabIndex = 22;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbNão);
            this.groupBox5.Controls.Add(this.rbSim);
            this.groupBox5.Location = new System.Drawing.Point(300, 20);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(137, 67);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Condimentos?";
            // 
            // rbNão
            // 
            this.rbNão.AutoSize = true;
            this.rbNão.Checked = true;
            this.rbNão.Location = new System.Drawing.Point(36, 40);
            this.rbNão.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbNão.Name = "rbNão";
            this.rbNão.Size = new System.Drawing.Size(58, 21);
            this.rbNão.TabIndex = 4;
            this.rbNão.TabStop = true;
            this.rbNão.Text = "Não";
            this.rbNão.UseVisualStyleBackColor = true;
            this.rbNão.CheckedChanged += new System.EventHandler(this.rbNão_CheckedChanged);
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Location = new System.Drawing.Point(36, 20);
            this.rbSim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(55, 21);
            this.rbSim.TabIndex = 3;
            this.rbSim.Text = "Sim";
            this.rbSim.UseVisualStyleBackColor = true;
            this.rbSim.CheckedChanged += new System.EventHandler(this.rbSim_CheckedChanged);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.AutoSize = true;
            this.btnAdicionar.Location = new System.Drawing.Point(7, 214);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(125, 28);
            this.btnAdicionar.TabIndex = 8;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.rbNãoB);
            this.groupBox7.Controls.Add(this.rbSimB);
            this.groupBox7.Location = new System.Drawing.Point(146, 20);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Size = new System.Drawing.Size(137, 67);
            this.groupBox7.TabIndex = 18;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Bebidas?";
            // 
            // rbNãoB
            // 
            this.rbNãoB.AutoSize = true;
            this.rbNãoB.Checked = true;
            this.rbNãoB.Location = new System.Drawing.Point(39, 40);
            this.rbNãoB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbNãoB.Name = "rbNãoB";
            this.rbNãoB.Size = new System.Drawing.Size(58, 21);
            this.rbNãoB.TabIndex = 4;
            this.rbNãoB.TabStop = true;
            this.rbNãoB.Text = "Não";
            this.rbNãoB.UseVisualStyleBackColor = true;
            this.rbNãoB.CheckedChanged += new System.EventHandler(this.rbNãoB_CheckedChanged);
            // 
            // rbSimB
            // 
            this.rbSimB.AutoSize = true;
            this.rbSimB.Location = new System.Drawing.Point(39, 20);
            this.rbSimB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbSimB.Name = "rbSimB";
            this.rbSimB.Size = new System.Drawing.Size(55, 21);
            this.rbSimB.TabIndex = 3;
            this.rbSimB.Text = "Sim";
            this.rbSimB.UseVisualStyleBackColor = true;
            this.rbSimB.CheckedChanged += new System.EventHandler(this.rbSimB_CheckedChanged);
            // 
            // gbOpções
            // 
            this.gbOpções.Controls.Add(this.checkBbq);
            this.gbOpções.Controls.Add(this.checkBPalha);
            this.gbOpções.Controls.Add(this.checkMInglês);
            this.gbOpções.Controls.Add(this.checkPimenta);
            this.gbOpções.Controls.Add(this.checkMaionese);
            this.gbOpções.Controls.Add(this.checkMostarda);
            this.gbOpções.Controls.Add(this.checkKetchup);
            this.gbOpções.Enabled = false;
            this.gbOpções.Location = new System.Drawing.Point(300, 101);
            this.gbOpções.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbOpções.Name = "gbOpções";
            this.gbOpções.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbOpções.Size = new System.Drawing.Size(136, 171);
            this.gbOpções.TabIndex = 18;
            this.gbOpções.TabStop = false;
            this.gbOpções.Text = "Opções";
            // 
            // checkBbq
            // 
            this.checkBbq.AutoSize = true;
            this.checkBbq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBbq.Location = new System.Drawing.Point(5, 148);
            this.checkBbq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBbq.Name = "checkBbq";
            this.checkBbq.Size = new System.Drawing.Size(110, 21);
            this.checkBbq.TabIndex = 9;
            this.checkBbq.Text = "Molho BBQ";
            this.checkBbq.UseVisualStyleBackColor = true;
            // 
            // checkBPalha
            // 
            this.checkBPalha.AutoSize = true;
            this.checkBPalha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBPalha.Location = new System.Drawing.Point(5, 86);
            this.checkBPalha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBPalha.Name = "checkBPalha";
            this.checkBPalha.Size = new System.Drawing.Size(123, 21);
            this.checkBPalha.TabIndex = 8;
            this.checkBPalha.Text = "Batata Palha";
            this.checkBPalha.UseVisualStyleBackColor = true;
            // 
            // checkMInglês
            // 
            this.checkMInglês.AutoSize = true;
            this.checkMInglês.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMInglês.Location = new System.Drawing.Point(5, 128);
            this.checkMInglês.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkMInglês.Name = "checkMInglês";
            this.checkMInglês.Size = new System.Drawing.Size(121, 21);
            this.checkMInglês.TabIndex = 7;
            this.checkMInglês.Text = "Molho Inglês";
            this.checkMInglês.UseVisualStyleBackColor = true;
            // 
            // checkPimenta
            // 
            this.checkPimenta.AutoSize = true;
            this.checkPimenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPimenta.Location = new System.Drawing.Point(5, 107);
            this.checkPimenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkPimenta.Name = "checkPimenta";
            this.checkPimenta.Size = new System.Drawing.Size(88, 21);
            this.checkPimenta.TabIndex = 6;
            this.checkPimenta.Text = "Pimenta";
            this.checkPimenta.UseVisualStyleBackColor = true;
            // 
            // checkMaionese
            // 
            this.checkMaionese.AutoSize = true;
            this.checkMaionese.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMaionese.Location = new System.Drawing.Point(5, 66);
            this.checkMaionese.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkMaionese.Name = "checkMaionese";
            this.checkMaionese.Size = new System.Drawing.Size(99, 21);
            this.checkMaionese.TabIndex = 5;
            this.checkMaionese.Text = "Maionese";
            this.checkMaionese.UseVisualStyleBackColor = true;
            // 
            // checkMostarda
            // 
            this.checkMostarda.AutoSize = true;
            this.checkMostarda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMostarda.Location = new System.Drawing.Point(5, 44);
            this.checkMostarda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkMostarda.Name = "checkMostarda";
            this.checkMostarda.Size = new System.Drawing.Size(97, 21);
            this.checkMostarda.TabIndex = 4;
            this.checkMostarda.Text = "Mostarda";
            this.checkMostarda.UseVisualStyleBackColor = true;
            // 
            // checkKetchup
            // 
            this.checkKetchup.AutoSize = true;
            this.checkKetchup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkKetchup.Location = new System.Drawing.Point(5, 20);
            this.checkKetchup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkKetchup.Name = "checkKetchup";
            this.checkKetchup.Size = new System.Drawing.Size(89, 21);
            this.checkKetchup.TabIndex = 3;
            this.checkKetchup.Text = "Ketchup";
            this.checkKetchup.UseVisualStyleBackColor = true;
            // 
            // gbBebidas
            // 
            this.gbBebidas.Controls.Add(this.lblTotalB);
            this.gbBebidas.Controls.Add(this.label6);
            this.gbBebidas.Controls.Add(this.txtQtdB);
            this.gbBebidas.Controls.Add(this.label5);
            this.gbBebidas.Controls.Add(this.label4);
            this.gbBebidas.Controls.Add(this.cmbPreçoBebida);
            this.gbBebidas.Controls.Add(this.label1);
            this.gbBebidas.Controls.Add(this.comboBox1);
            this.gbBebidas.Controls.Add(this.cmbBebida);
            this.gbBebidas.Enabled = false;
            this.gbBebidas.Location = new System.Drawing.Point(146, 101);
            this.gbBebidas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbBebidas.Name = "gbBebidas";
            this.gbBebidas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbBebidas.Size = new System.Drawing.Size(137, 171);
            this.gbBebidas.TabIndex = 19;
            this.gbBebidas.TabStop = false;
            this.gbBebidas.Text = "Bebida:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(7, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Valor Item:";
            // 
            // txtQtdB
            // 
            this.txtQtdB.Location = new System.Drawing.Point(7, 98);
            this.txtQtdB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQtdB.Name = "txtQtdB";
            this.txtQtdB.Size = new System.Drawing.Size(121, 23);
            this.txtQtdB.TabIndex = 23;
            this.txtQtdB.TextChanged += new System.EventHandler(this.txtQtdB_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-185, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Qtd:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(5, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Qtd:";
            // 
            // cmbPreçoBebida
            // 
            this.cmbPreçoBebida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbPreçoBebida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPreçoBebida.FormattingEnabled = true;
            this.cmbPreçoBebida.Items.AddRange(new object[] {
            "R$ 3,50",
            "R$ 18,00",
            "R$ 10,00",
            "R$ 7,50"});
            this.cmbPreçoBebida.Location = new System.Drawing.Point(7, 58);
            this.cmbPreçoBebida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPreçoBebida.Name = "cmbPreçoBebida";
            this.cmbPreçoBebida.Size = new System.Drawing.Size(121, 23);
            this.cmbPreçoBebida.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(5, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Preço:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "R$ 25,00",
            "R$ 15,00",
            "R$ 05,00",
            "R$ 50,00"});
            this.comboBox1.Location = new System.Drawing.Point(136, 15);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(73, 23);
            this.comboBox1.TabIndex = 21;
            // 
            // cmbBebida
            // 
            this.cmbBebida.FormattingEnabled = true;
            this.cmbBebida.Items.AddRange(new object[] {
            "c/ Água",
            "c/ MilkShake",
            "c/ Refrigerante",
            "c/ Suco"});
            this.cmbBebida.Location = new System.Drawing.Point(5, 18);
            this.cmbBebida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBebida.Name = "cmbBebida";
            this.cmbBebida.Size = new System.Drawing.Size(121, 24);
            this.cmbBebida.TabIndex = 0;
            this.cmbBebida.SelectedIndexChanged += new System.EventHandler(this.cmbBebida_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbLanche);
            this.groupBox3.Controls.Add(this.lblTotal);
            this.groupBox3.Controls.Add(this.cmbPreçoLanche);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtQtd);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(7, 20);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(124, 186);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // cmbLanche
            // 
            this.cmbLanche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanche.FormattingEnabled = true;
            this.cmbLanche.Items.AddRange(new object[] {
            "X-Sabedoria ",
            "X-Salada ",
            "X-Humildade ",
            "X-Banana "});
            this.cmbLanche.Location = new System.Drawing.Point(7, 26);
            this.cmbLanche.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLanche.Name = "cmbLanche";
            this.cmbLanche.Size = new System.Drawing.Size(108, 24);
            this.cmbLanche.TabIndex = 7;
            this.cmbLanche.SelectedIndexChanged += new System.EventHandler(this.cmbLanche_SelectedIndexChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.Window;
            this.lblTotal.Location = new System.Drawing.Point(9, 154);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.ReadOnly = true;
            this.lblTotal.Size = new System.Drawing.Size(107, 23);
            this.lblTotal.TabIndex = 20;
            // 
            // cmbPreçoLanche
            // 
            this.cmbPreçoLanche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbPreçoLanche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPreçoLanche.FormattingEnabled = true;
            this.cmbPreçoLanche.Items.AddRange(new object[] {
            "R$ 25,00",
            "R$ 15,00",
            "R$ 05,00",
            "R$ 50,00"});
            this.cmbPreçoLanche.Location = new System.Drawing.Point(9, 68);
            this.cmbPreçoLanche.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPreçoLanche.Name = "cmbPreçoLanche";
            this.cmbPreçoLanche.Size = new System.Drawing.Size(106, 23);
            this.cmbPreçoLanche.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Valor Item:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "Qtd:";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(9, 111);
            this.txtQtd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(106, 23);
            this.txtQtd.TabIndex = 9;
            this.txtQtd.TextChanged += new System.EventHandler(this.txtQtd_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "Preço:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "Lanche:";
            // 
            // tabResumo
            // 
            this.tabResumo.BackColor = System.Drawing.Color.Orange;
            this.tabResumo.Controls.Add(this.lstResumo);
            this.tabResumo.Location = new System.Drawing.Point(4, 25);
            this.tabResumo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabResumo.Name = "tabResumo";
            this.tabResumo.Size = new System.Drawing.Size(980, 298);
            this.tabResumo.TabIndex = 2;
            this.tabResumo.Text = "Resumo dos Pedidos";
            // 
            // lstResumo
            // 
            this.lstResumo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lstResumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstResumo.ForeColor = System.Drawing.Color.White;
            this.lstResumo.FormattingEnabled = true;
            this.lstResumo.ItemHeight = 20;
            this.lstResumo.Location = new System.Drawing.Point(98, 12);
            this.lstResumo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstResumo.Name = "lstResumo";
            this.lstResumo.Size = new System.Drawing.Size(557, 224);
            this.lstResumo.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(514, 20);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 84);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravarPedidoXML
            // 
            this.btnGravarPedidoXML.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGravarPedidoXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravarPedidoXML.Location = new System.Drawing.Point(183, 20);
            this.btnGravarPedidoXML.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGravarPedidoXML.Name = "btnGravarPedidoXML";
            this.btnGravarPedidoXML.Size = new System.Drawing.Size(117, 84);
            this.btnGravarPedidoXML.TabIndex = 1;
            this.btnGravarPedidoXML.Text = "Gravar Pedido XML";
            this.btnGravarPedidoXML.UseVisualStyleBackColor = false;
            this.btnGravarPedidoXML.Click += new System.EventHandler(this.btnGravarPedidoXML_Click);
            // 
            // btnResumo
            // 
            this.btnResumo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnResumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResumo.Location = new System.Drawing.Point(681, 20);
            this.btnResumo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResumo.Name = "btnResumo";
            this.btnResumo.Size = new System.Drawing.Size(117, 84);
            this.btnResumo.TabIndex = 3;
            this.btnResumo.Text = "Resumo dos Pedidos";
            this.btnResumo.UseVisualStyleBackColor = false;
            this.btnResumo.Click += new System.EventHandler(this.btnResumo_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(843, 20);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(117, 84);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnNovoPedido
            // 
            this.btnNovoPedido.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNovoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoPedido.Location = new System.Drawing.Point(18, 20);
            this.btnNovoPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNovoPedido.Name = "btnNovoPedido";
            this.btnNovoPedido.Size = new System.Drawing.Size(117, 84);
            this.btnNovoPedido.TabIndex = 0;
            this.btnNovoPedido.Text = "Novo Pedido";
            this.btnNovoPedido.UseVisualStyleBackColor = false;
            this.btnNovoPedido.Click += new System.EventHandler(this.btnNovoPedido_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Orange;
            this.groupBox1.Controls.Add(this.GravarPedidoTXT);
            this.groupBox1.Controls.Add(this.btnNovoPedido);
            this.groupBox1.Controls.Add(this.btnFechar);
            this.groupBox1.Controls.Add(this.btnResumo);
            this.groupBox1.Controls.Add(this.btnGravarPedidoXML);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(19, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(988, 114);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ações";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // GravarPedidoTXT
            // 
            this.GravarPedidoTXT.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.GravarPedidoTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GravarPedidoTXT.Location = new System.Drawing.Point(351, 20);
            this.GravarPedidoTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GravarPedidoTXT.Name = "GravarPedidoTXT";
            this.GravarPedidoTXT.Size = new System.Drawing.Size(117, 84);
            this.GravarPedidoTXT.TabIndex = 5;
            this.GravarPedidoTXT.Text = "Gravar Pedido TXT";
            this.GravarPedidoTXT.UseVisualStyleBackColor = false;
            this.GravarPedidoTXT.Click += new System.EventHandler(this.GravarPedidoTXT_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTotalB
            // 
            this.lblTotalB.BackColor = System.Drawing.SystemColors.Window;
            this.lblTotalB.Location = new System.Drawing.Point(10, 141);
            this.lblTotalB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTotalB.Name = "lblTotalB";
            this.lblTotalB.ReadOnly = true;
            this.lblTotalB.Size = new System.Drawing.Size(118, 23);
            this.lblTotalB.TabIndex = 25;
            // 
            // FormLanchonete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lanchonete.Properties.Resources.pattern;
            this.ClientSize = new System.Drawing.Size(1027, 462);
            this.Controls.Add(this.tabControl_Detalhes);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormLanchonete";
            this.Text = "Lanchonete";
            this.Load += new System.EventHandler(this.FormLanchonete_Load);
            this.tabControl_Detalhes.ResumeLayout(false);
            this.tabDados.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabItens.ResumeLayout(false);
            this.tabItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.gbOpções.ResumeLayout(false);
            this.gbOpções.PerformLayout();
            this.gbBebidas.ResumeLayout(false);
            this.gbBebidas.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabResumo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl_Detalhes;
        private System.Windows.Forms.TabPage tabDados;
        private System.Windows.Forms.TabPage tabItens;
        private System.Windows.Forms.TabPage tabResumo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblPedidoDados;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Label tabData;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravarPedidoXML;
        private System.Windows.Forms.Button btnResumo;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnNovoPedido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.ComboBox cmbPreçoLanche;
        private System.Windows.Forms.ComboBox cmbLanche;
        private System.Windows.Forms.GroupBox gbOpções;
        private System.Windows.Forms.CheckBox checkBPalha;
        private System.Windows.Forms.CheckBox checkMInglês;
        private System.Windows.Forms.CheckBox checkPimenta;
        private System.Windows.Forms.CheckBox checkMaionese;
        private System.Windows.Forms.CheckBox checkMostarda;
        private System.Windows.Forms.CheckBox checkKetchup;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton rbNãoB;
        private System.Windows.Forms.RadioButton rbSimB;
        private System.Windows.Forms.GroupBox gbBebidas;
        private System.Windows.Forms.ComboBox cmbBebida;
        private System.Windows.Forms.ListBox lstResumo;
        private System.Windows.Forms.Label lblPedidoItens;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLançar;
        private System.Windows.Forms.Label lblTotalPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.DateTimePicker dtpDataPed;
        private System.Windows.Forms.TextBox lblTotal;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button GravarPedidoTXT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQtdB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPreçoBebida;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbNão;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.CheckBox checkBbq;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.TextBox lblTotalB;
    }
}

