
namespace SistemaVendaRaizes.Formulários
{
    partial class Frm_RelatorioVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label8 = new System.Windows.Forms.Label();
            this.grouppedido = new System.Windows.Forms.GroupBox();
            this.cbLocal = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtfim = new System.Windows.Forms.DateTimePicker();
            this.datainicio = new System.Windows.Forms.DateTimePicker();
            this.cbap = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbloco = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblquantidade = new System.Windows.Forms.Label();
            this.dgtVendas = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbValorTotal = new System.Windows.Forms.Label();
            this.grouppedido.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtVendas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DeepPink;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(967, 24);
            this.menuStrip1.TabIndex = 119;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(306, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(336, 31);
            this.label8.TabIndex = 120;
            this.label8.Text = "RELATÓRIO DE VENDA";
            // 
            // grouppedido
            // 
            this.grouppedido.Controls.Add(this.cbLocal);
            this.grouppedido.Controls.Add(this.label7);
            this.grouppedido.Controls.Add(this.button1);
            this.grouppedido.Controls.Add(this.label4);
            this.grouppedido.Controls.Add(this.label1);
            this.grouppedido.Controls.Add(this.dtfim);
            this.grouppedido.Controls.Add(this.datainicio);
            this.grouppedido.Controls.Add(this.cbap);
            this.grouppedido.Controls.Add(this.label6);
            this.grouppedido.Controls.Add(this.cbbloco);
            this.grouppedido.Controls.Add(this.label3);
            this.grouppedido.Controls.Add(this.btnAdicionar);
            this.grouppedido.Controls.Add(this.cb_tipo);
            this.grouppedido.Controls.Add(this.label2);
            this.grouppedido.Location = new System.Drawing.Point(9, 60);
            this.grouppedido.Name = "grouppedido";
            this.grouppedido.Size = new System.Drawing.Size(795, 158);
            this.grouppedido.TabIndex = 121;
            this.grouppedido.TabStop = false;
            // 
            // cbLocal
            // 
            this.cbLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocal.FormattingEnabled = true;
            this.cbLocal.Items.AddRange(new object[] {
            "Raizes",
            "FiveMed"});
            this.cbLocal.Location = new System.Drawing.Point(484, 84);
            this.cbLocal.Name = "cbLocal";
            this.cbLocal.Size = new System.Drawing.Size(203, 25);
            this.cbLocal.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(481, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 115;
            this.label7.Text = "Localidade:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Pink;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(451, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "LIMPAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(422, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 113;
            this.label4.Text = "Até:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(105, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 112;
            this.label1.Text = "De:";
            // 
            // dtfim
            // 
            this.dtfim.Location = new System.Drawing.Point(425, 38);
            this.dtfim.Name = "dtfim";
            this.dtfim.Size = new System.Drawing.Size(262, 20);
            this.dtfim.TabIndex = 1;
            // 
            // datainicio
            // 
            this.datainicio.Location = new System.Drawing.Point(108, 38);
            this.datainicio.Name = "datainicio";
            this.datainicio.Size = new System.Drawing.Size(262, 20);
            this.datainicio.TabIndex = 0;
            // 
            // cbap
            // 
            this.cbap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbap.FormattingEnabled = true;
            this.cbap.Location = new System.Drawing.Point(206, 85);
            this.cbap.Name = "cbap";
            this.cbap.Size = new System.Drawing.Size(97, 25);
            this.cbap.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(203, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 109;
            this.label6.Text = "Apartamento:";
            // 
            // cbbloco
            // 
            this.cbbloco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbloco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbloco.FormattingEnabled = true;
            this.cbbloco.Location = new System.Drawing.Point(108, 85);
            this.cbbloco.Name = "cbbloco";
            this.cbbloco.Size = new System.Drawing.Size(80, 25);
            this.cbbloco.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(105, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 106;
            this.label3.Text = "Bloco:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionar.BackColor = System.Drawing.Color.Pink;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(108, 116);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(291, 30);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "CONSULTAR";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // cb_tipo
            // 
            this.cb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.Location = new System.Drawing.Point(321, 84);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(149, 25);
            this.cb_tipo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(317, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblquantidade);
            this.groupBox1.Location = new System.Drawing.Point(810, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 82);
            this.groupBox1.TabIndex = 122;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 17);
            this.label9.TabIndex = 109;
            this.label9.Text = "QTD DE ITENS";
            // 
            // lblquantidade
            // 
            this.lblquantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblquantidade.AutoSize = true;
            this.lblquantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquantidade.ForeColor = System.Drawing.Color.DeepPink;
            this.lblquantidade.Location = new System.Drawing.Point(57, 43);
            this.lblquantidade.Name = "lblquantidade";
            this.lblquantidade.Size = new System.Drawing.Size(17, 17);
            this.lblquantidade.TabIndex = 108;
            this.lblquantidade.Text = "0";
            // 
            // dgtVendas
            // 
            this.dgtVendas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgtVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtVendas.Location = new System.Drawing.Point(9, 224);
            this.dgtVendas.Name = "dgtVendas";
            this.dgtVendas.Size = new System.Drawing.Size(949, 377);
            this.dgtVendas.TabIndex = 123;
            this.dgtVendas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgtVendas_CellFormatting);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lbValorTotal);
            this.groupBox2.Location = new System.Drawing.Point(810, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 74);
            this.groupBox2.TabIndex = 124;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 109;
            this.label5.Text = "VALOR TOTAL";
            // 
            // lbValorTotal
            // 
            this.lbValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbValorTotal.AutoSize = true;
            this.lbValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorTotal.ForeColor = System.Drawing.Color.DeepPink;
            this.lbValorTotal.Location = new System.Drawing.Point(36, 38);
            this.lbValorTotal.Name = "lbValorTotal";
            this.lbValorTotal.Size = new System.Drawing.Size(17, 17);
            this.lbValorTotal.TabIndex = 108;
            this.lbValorTotal.Text = "0";
            // 
            // Frm_RelatorioVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(967, 613);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgtVendas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grouppedido);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "Frm_RelatorioVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RELATÓRIO DE VENDAS";
            this.Load += new System.EventHandler(this.Frm_RelatorioVenda_Load);
            this.grouppedido.ResumeLayout(false);
            this.grouppedido.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtVendas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grouppedido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtfim;
        private System.Windows.Forms.DateTimePicker datainicio;
        private System.Windows.Forms.ComboBox cbap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbloco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ComboBox cb_tipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblquantidade;
        private System.Windows.Forms.DataGridView dgtVendas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbValorTotal;
        private System.Windows.Forms.ComboBox cbLocal;
        private System.Windows.Forms.Label label7;
    }
}