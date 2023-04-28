using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22179
{
    public partial class frmPedido : Form
    {
        public frmPedido()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEnvio_Click(object sender, EventArgs e)
        {
            String lanche = " ";
            String bebida = " ";
            String acomp = " ";
            int calorias = 0;
            
            // Verificação do lanche escolhido
            if (rbtHotdog.Checked)
            {
                lanche = rbtHotdog.Text;
                calorias += 150;
                // calorias = calorias +150;
            }
            else if (rbtMistoquente.Checked)
            {
                lanche = rbtMistoquente.Text;
                calorias += 100;
            }
            else if (rbtXsalada.Checked)
            {
                lanche = rbtXsalada.Text;
                calorias += 180;
            }
            else if (rbtXburguer.Checked)
            {
                lanche = rbtXburguer.Text;
                calorias += 160;
            }
            else
            {
                lanche = rbtXbacon.Text;
                calorias += 180;
            }
            // Verificação da bebida escolhida
            if (rbtSuco.Checked)
            {
                bebida = rbtSuco.Text;
                calorias += 60;
            }
            else if (rbtRefri.Checked)
            {
                bebida = rbtRefri.Text;
                calorias += 80;
            }
            else if (rbtCerveja.Checked)
            {
                bebida = rbtCerveja.Text;
                calorias += 120;
            }
            else if (rbtChopp.Checked)
            {
                bebida = rbtChopp.Text;
                calorias += 90;
            }
            else
            {
                bebida = rbtAgua.Text;
                calorias += 0;
            }
            // Verificação do acompanhamento escolhido
            if (rbtBatata.Checked)
            {
                acomp = rbtBatata.Text;
                calorias += 170;
            }
            else if (rbtMandioca.Checked)
            {
                acomp = rbtMandioca.Text;
                calorias += 190;
            }
            else if (rbtPolenta.Checked)
            {
                acomp = rbtPolenta.Text;
                calorias += 160;
            }
            else if (rbtSalada.Checked)
             {
                acomp = rbtSalada.Text;
                calorias += 30;
            }
            else
            {
                acomp = rbtProvolone.Text;
                calorias += 220;
            }
            if (calorias > 350)
            {
                txtTotal.Text = String.Format("Você vai acabar engordando");
            }
            else
            {
                txtTotal.Text = String.Format("Assim está bom");
            }

            txtPedido.Text = String.Format("Lanche: {0}. Bebida: {1}. Acompanhamento: {2}.", lanche, bebida, acomp);
            txtCaloria.Text = String.Format("{0} Kcal", calorias);
            
        
        }
    }
}
       