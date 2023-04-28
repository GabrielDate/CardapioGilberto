
namespace _22179
{
    partial class frmPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedido));
            this.btnEnvio = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbLanche = new System.Windows.Forms.GroupBox();
            this.rbtHotdog = new System.Windows.Forms.RadioButton();
            this.rbtMistoquente = new System.Windows.Forms.RadioButton();
            this.rbtXsalada = new System.Windows.Forms.RadioButton();
            this.rbtXburguer = new System.Windows.Forms.RadioButton();
            this.grbBebida = new System.Windows.Forms.GroupBox();
            this.rbtChopp = new System.Windows.Forms.RadioButton();
            this.rbtCerveja = new System.Windows.Forms.RadioButton();
            this.rbtRefri = new System.Windows.Forms.RadioButton();
            this.rbtSuco = new System.Windows.Forms.RadioButton();
            this.grbAcomp = new System.Windows.Forms.GroupBox();
            this.rbtSalada = new System.Windows.Forms.RadioButton();
            this.rbtPolenta = new System.Windows.Forms.RadioButton();
            this.rbtMandioca = new System.Windows.Forms.RadioButton();
            this.rbtBatata = new System.Windows.Forms.RadioButton();
            this.rbtAgua = new System.Windows.Forms.RadioButton();
            this.rbtXbacon = new System.Windows.Forms.RadioButton();
            this.lblPedido = new System.Windows.Forms.Label();
            this.rbtProvolone = new System.Windows.Forms.RadioButton();
            this.lblCaloria = new System.Windows.Forms.Label();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.txtCaloria = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblNomee = new System.Windows.Forms.Label();
            this.grbLanche.SuspendLayout();
            this.grbBebida.SuspendLayout();
            this.grbAcomp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnvio
            // 
            this.btnEnvio.Location = new System.Drawing.Point(247, 421);
            this.btnEnvio.Name = "btnEnvio";
            this.btnEnvio.Size = new System.Drawing.Size(143, 23);
            this.btnEnvio.TabIndex = 0;
            this.btnEnvio.Text = "&Enviar Pedido";
            this.btnEnvio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEnvio.UseVisualStyleBackColor = true;
            this.btnEnvio.Click += new System.EventHandler(this.btnEnvio_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(484, 760);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "&Sair";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grbLanche
            // 
            this.grbLanche.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grbLanche.Controls.Add(this.rbtXbacon);
            this.grbLanche.Controls.Add(this.rbtXburguer);
            this.grbLanche.Controls.Add(this.rbtXsalada);
            this.grbLanche.Controls.Add(this.rbtMistoquente);
            this.grbLanche.Controls.Add(this.rbtHotdog);
            this.grbLanche.Location = new System.Drawing.Point(82, 213);
            this.grbLanche.Name = "grbLanche";
            this.grbLanche.Size = new System.Drawing.Size(150, 152);
            this.grbLanche.TabIndex = 2;
            this.grbLanche.TabStop = false;
            this.grbLanche.Text = "Lanches";
            // 
            // rbtHotdog
            // 
            this.rbtHotdog.AutoSize = true;
            this.rbtHotdog.Location = new System.Drawing.Point(20, 20);
            this.rbtHotdog.Name = "rbtHotdog";
            this.rbtHotdog.Size = new System.Drawing.Size(65, 17);
            this.rbtHotdog.TabIndex = 0;
            this.rbtHotdog.TabStop = true;
            this.rbtHotdog.Text = "Hot-Dog";
            this.rbtHotdog.UseVisualStyleBackColor = true;
            // 
            // rbtMistoquente
            // 
            this.rbtMistoquente.AutoSize = true;
            this.rbtMistoquente.Location = new System.Drawing.Point(20, 44);
            this.rbtMistoquente.Name = "rbtMistoquente";
            this.rbtMistoquente.Size = new System.Drawing.Size(88, 17);
            this.rbtMistoquente.TabIndex = 1;
            this.rbtMistoquente.TabStop = true;
            this.rbtMistoquente.Text = "Misto Quente";
            this.rbtMistoquente.UseVisualStyleBackColor = true;
            // 
            // rbtXsalada
            // 
            this.rbtXsalada.AutoSize = true;
            this.rbtXsalada.Location = new System.Drawing.Point(20, 68);
            this.rbtXsalada.Name = "rbtXsalada";
            this.rbtXsalada.Size = new System.Drawing.Size(68, 17);
            this.rbtXsalada.TabIndex = 2;
            this.rbtXsalada.TabStop = true;
            this.rbtXsalada.Text = "X-Salada";
            this.rbtXsalada.UseVisualStyleBackColor = true;
            // 
            // rbtXburguer
            // 
            this.rbtXburguer.AutoSize = true;
            this.rbtXburguer.Location = new System.Drawing.Point(20, 92);
            this.rbtXburguer.Name = "rbtXburguer";
            this.rbtXburguer.Size = new System.Drawing.Size(72, 17);
            this.rbtXburguer.TabIndex = 3;
            this.rbtXburguer.TabStop = true;
            this.rbtXburguer.Text = "X-Burguer";
            this.rbtXburguer.UseVisualStyleBackColor = true;
            // 
            // grbBebida
            // 
            this.grbBebida.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grbBebida.Controls.Add(this.rbtAgua);
            this.grbBebida.Controls.Add(this.rbtChopp);
            this.grbBebida.Controls.Add(this.rbtCerveja);
            this.grbBebida.Controls.Add(this.rbtRefri);
            this.grbBebida.Controls.Add(this.rbtSuco);
            this.grbBebida.Location = new System.Drawing.Point(247, 213);
            this.grbBebida.Name = "grbBebida";
            this.grbBebida.Size = new System.Drawing.Size(143, 152);
            this.grbBebida.TabIndex = 4;
            this.grbBebida.TabStop = false;
            this.grbBebida.Text = "Bebidas";
            // 
            // rbtChopp
            // 
            this.rbtChopp.AutoSize = true;
            this.rbtChopp.Location = new System.Drawing.Point(20, 92);
            this.rbtChopp.Name = "rbtChopp";
            this.rbtChopp.Size = new System.Drawing.Size(56, 17);
            this.rbtChopp.TabIndex = 3;
            this.rbtChopp.TabStop = true;
            this.rbtChopp.Text = "Chopp";
            this.rbtChopp.UseVisualStyleBackColor = true;
            // 
            // rbtCerveja
            // 
            this.rbtCerveja.AutoSize = true;
            this.rbtCerveja.Location = new System.Drawing.Point(20, 68);
            this.rbtCerveja.Name = "rbtCerveja";
            this.rbtCerveja.Size = new System.Drawing.Size(61, 17);
            this.rbtCerveja.TabIndex = 2;
            this.rbtCerveja.TabStop = true;
            this.rbtCerveja.Text = "Cerveja";
            this.rbtCerveja.UseVisualStyleBackColor = true;
            // 
            // rbtRefri
            // 
            this.rbtRefri.AutoSize = true;
            this.rbtRefri.Location = new System.Drawing.Point(20, 44);
            this.rbtRefri.Name = "rbtRefri";
            this.rbtRefri.Size = new System.Drawing.Size(83, 17);
            this.rbtRefri.TabIndex = 1;
            this.rbtRefri.TabStop = true;
            this.rbtRefri.Text = "Refrigerante";
            this.rbtRefri.UseVisualStyleBackColor = true;
            // 
            // rbtSuco
            // 
            this.rbtSuco.AutoSize = true;
            this.rbtSuco.Location = new System.Drawing.Point(20, 20);
            this.rbtSuco.Name = "rbtSuco";
            this.rbtSuco.Size = new System.Drawing.Size(50, 17);
            this.rbtSuco.TabIndex = 0;
            this.rbtSuco.TabStop = true;
            this.rbtSuco.Text = "Suco";
            this.rbtSuco.UseVisualStyleBackColor = true;
            // 
            // grbAcomp
            // 
            this.grbAcomp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grbAcomp.Controls.Add(this.rbtProvolone);
            this.grbAcomp.Controls.Add(this.rbtSalada);
            this.grbAcomp.Controls.Add(this.rbtPolenta);
            this.grbAcomp.Controls.Add(this.rbtMandioca);
            this.grbAcomp.Controls.Add(this.rbtBatata);
            this.grbAcomp.Location = new System.Drawing.Point(416, 213);
            this.grbAcomp.Name = "grbAcomp";
            this.grbAcomp.Size = new System.Drawing.Size(157, 152);
            this.grbAcomp.TabIndex = 5;
            this.grbAcomp.TabStop = false;
            this.grbAcomp.Text = "Acompanhamento";
            // 
            // rbtSalada
            // 
            this.rbtSalada.AutoSize = true;
            this.rbtSalada.Location = new System.Drawing.Point(20, 92);
            this.rbtSalada.Name = "rbtSalada";
            this.rbtSalada.Size = new System.Drawing.Size(58, 17);
            this.rbtSalada.TabIndex = 3;
            this.rbtSalada.TabStop = true;
            this.rbtSalada.Text = "Salada";
            this.rbtSalada.UseVisualStyleBackColor = true;
            // 
            // rbtPolenta
            // 
            this.rbtPolenta.AutoSize = true;
            this.rbtPolenta.Location = new System.Drawing.Point(20, 68);
            this.rbtPolenta.Name = "rbtPolenta";
            this.rbtPolenta.Size = new System.Drawing.Size(84, 17);
            this.rbtPolenta.TabIndex = 2;
            this.rbtPolenta.TabStop = true;
            this.rbtPolenta.Text = "Polenta Frita";
            this.rbtPolenta.UseVisualStyleBackColor = true;
            // 
            // rbtMandioca
            // 
            this.rbtMandioca.AutoSize = true;
            this.rbtMandioca.Location = new System.Drawing.Point(20, 44);
            this.rbtMandioca.Name = "rbtMandioca";
            this.rbtMandioca.Size = new System.Drawing.Size(95, 17);
            this.rbtMandioca.TabIndex = 1;
            this.rbtMandioca.TabStop = true;
            this.rbtMandioca.Text = "Mandioca Frita";
            this.rbtMandioca.UseVisualStyleBackColor = true;
            // 
            // rbtBatata
            // 
            this.rbtBatata.AutoSize = true;
            this.rbtBatata.Location = new System.Drawing.Point(20, 20);
            this.rbtBatata.Name = "rbtBatata";
            this.rbtBatata.Size = new System.Drawing.Size(79, 17);
            this.rbtBatata.TabIndex = 0;
            this.rbtBatata.TabStop = true;
            this.rbtBatata.Text = "Batata Frita";
            this.rbtBatata.UseVisualStyleBackColor = true;
            // 
            // rbtAgua
            // 
            this.rbtAgua.AutoSize = true;
            this.rbtAgua.Location = new System.Drawing.Point(20, 116);
            this.rbtAgua.Name = "rbtAgua";
            this.rbtAgua.Size = new System.Drawing.Size(50, 17);
            this.rbtAgua.TabIndex = 4;
            this.rbtAgua.TabStop = true;
            this.rbtAgua.Text = "Água";
            this.rbtAgua.UseVisualStyleBackColor = true;
            // 
            // rbtXbacon
            // 
            this.rbtXbacon.AutoSize = true;
            this.rbtXbacon.Location = new System.Drawing.Point(20, 116);
            this.rbtXbacon.Name = "rbtXbacon";
            this.rbtXbacon.Size = new System.Drawing.Size(66, 17);
            this.rbtXbacon.TabIndex = 4;
            this.rbtXbacon.TabStop = true;
            this.rbtXbacon.Text = "X-Bacon";
            this.rbtXbacon.UseVisualStyleBackColor = true;
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.lblPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPedido.Location = new System.Drawing.Point(92, 518);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(114, 13);
            this.lblPedido.TabIndex = 6;
            this.lblPedido.Text = "Pedido Realizado: ";
            // 
            // rbtProvolone
            // 
            this.rbtProvolone.AutoSize = true;
            this.rbtProvolone.Location = new System.Drawing.Point(20, 116);
            this.rbtProvolone.Name = "rbtProvolone";
            this.rbtProvolone.Size = new System.Drawing.Size(127, 17);
            this.rbtProvolone.TabIndex = 4;
            this.rbtProvolone.TabStop = true;
            this.rbtProvolone.Text = "Provolone à Milanesa";
            this.rbtProvolone.UseVisualStyleBackColor = true;
            // 
            // lblCaloria
            // 
            this.lblCaloria.AutoSize = true;
            this.lblCaloria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.lblCaloria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaloria.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCaloria.Location = new System.Drawing.Point(92, 572);
            this.lblCaloria.Name = "lblCaloria";
            this.lblCaloria.Size = new System.Drawing.Size(107, 13);
            this.lblCaloria.TabIndex = 7;
            this.lblCaloria.Text = "Total de Calorias:";
            // 
            // txtPedido
            // 
            this.txtPedido.Location = new System.Drawing.Point(95, 533);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.ReadOnly = true;
            this.txtPedido.Size = new System.Drawing.Size(255, 20);
            this.txtPedido.TabIndex = 8;
            // 
            // txtCaloria
            // 
            this.txtCaloria.Location = new System.Drawing.Point(95, 588);
            this.txtCaloria.Name = "txtCaloria";
            this.txtCaloria.ReadOnly = true;
            this.txtCaloria.Size = new System.Drawing.Size(255, 20);
            this.txtCaloria.TabIndex = 9;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(356, 588);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(217, 20);
            this.txtTotal.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(258, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 42);
            this.label1.TabIndex = 11;
            this.label1.Text = "MENU";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNome.Location = new System.Drawing.Point(94, 770);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(146, 13);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Gabriel Victor Cepeda, 21799";
            // 
            // lblNomee
            // 
            this.lblNomee.AutoSize = true;
            this.lblNomee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.lblNomee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNomee.Location = new System.Drawing.Point(94, 789);
            this.lblNomee.Name = "lblNomee";
            this.lblNomee.Size = new System.Drawing.Size(237, 13);
            this.lblNomee.TabIndex = 13;
            this.lblNomee.Text = "Gabrielle Carvalho Gonçalves das Neves, 22846";
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(643, 832);
            this.Controls.Add(this.lblNomee);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtCaloria);
            this.Controls.Add(this.txtPedido);
            this.Controls.Add(this.lblCaloria);
            this.Controls.Add(this.lblPedido);
            this.Controls.Add(this.grbAcomp);
            this.Controls.Add(this.grbBebida);
            this.Controls.Add(this.grbLanche);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEnvio);
            this.Name = "frmPedido";
            this.Text = "O Programa Calorias";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbLanche.ResumeLayout(false);
            this.grbLanche.PerformLayout();
            this.grbBebida.ResumeLayout(false);
            this.grbBebida.PerformLayout();
            this.grbAcomp.ResumeLayout(false);
            this.grbAcomp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnvio;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grbLanche;
        private System.Windows.Forms.RadioButton rbtXbacon;
        private System.Windows.Forms.RadioButton rbtXburguer;
        private System.Windows.Forms.RadioButton rbtXsalada;
        private System.Windows.Forms.RadioButton rbtMistoquente;
        private System.Windows.Forms.RadioButton rbtHotdog;
        private System.Windows.Forms.GroupBox grbBebida;
        private System.Windows.Forms.RadioButton rbtAgua;
        private System.Windows.Forms.RadioButton rbtChopp;
        private System.Windows.Forms.RadioButton rbtCerveja;
        private System.Windows.Forms.RadioButton rbtRefri;
        private System.Windows.Forms.RadioButton rbtSuco;
        private System.Windows.Forms.GroupBox grbAcomp;
        private System.Windows.Forms.RadioButton rbtProvolone;
        private System.Windows.Forms.RadioButton rbtSalada;
        private System.Windows.Forms.RadioButton rbtPolenta;
        private System.Windows.Forms.RadioButton rbtMandioca;
        private System.Windows.Forms.RadioButton rbtBatata;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.Label lblCaloria;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.TextBox txtCaloria;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNomee;
    }
}

