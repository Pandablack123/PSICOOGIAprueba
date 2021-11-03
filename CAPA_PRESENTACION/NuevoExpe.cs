using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_NEGOCIO;

namespace CAPA_PRESENTACION
{
    public partial class NuevoExpe : Form
    {
        public NuevoExpe()
        {
            InitializeComponent();
            mostrar();
        }

    
        private void generar()
        {
            Random generator = new Random();
            int r = Convert.ToInt32(generator.Next(100000, 1000000).ToString("D4"));
            txtid.Texts = r.ToString();
            Random generato = new Random();
            int y = Convert.ToInt32(generato.Next(80000, 1000000).ToString("D4"));
            txtidre.Texts = y.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Nexpediente datos = new Nexpediente();

        private void btnremitir_Click(object sender, EventArgs e)
        {
            string estado = "";



            Nexpediente nexpediente = new Nexpediente();
            System.IO.MemoryStream memory = new System.IO.MemoryStream();
            pictureBox1.Image.Save(memory, System.Drawing.Imaging.ImageFormat.Jpeg);
            
           if (rbtnactivo.Checked == true)
            {
                estado = "A";
            }
            else
            {  
                estado = "I";
            }

            

            nexpediente.insertexpediente(Convert.ToInt32(txtidre.Texts), Convert.ToInt32(txtid.Texts),txtnombre.Texts, estado, memory.GetBuffer(),dtaexpe.CurrentRow.Cells["NoExpediente"].Value.ToString());

           

            RemisionN remisionN = new RemisionN();
            remisionN.insertremision(Convert.ToInt32(txtidre.Texts)
                , Convert.ToInt32(txtid.Texts)
                ,cmbxremitente.Texts
                ,Convert.ToInt32(Motivo.SelectedValue),datetimepicker1.Value,dtaexpe.CurrentRow.Cells["NoExpediente"].Value.ToString());
            MessageBox.Show("Se resgistro correctamente");
            limpiar();
            paneldegradado2.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            DialogResult resul = open.ShowDialog();
            if (resul == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
            }
        }

        private void limpiar()
        {
            rbtnactivo.Checked = true;
            txtnombre.Texts = "";
            txtid.Texts = "";
            txtidre.Texts="";
            datetimepicker1.Value = DateTime.Now;
            cmbxremitente.Texts = "";
            pictureBox1.Image = Properties.Resources.avatardefault_92824;
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txtnombre_Validated(object sender, EventArgs e)
        {
            if (txtnombre.Texts.Trim() == "")
            {
                epError.SetError(txtnombre, "Intruzca un valor");
                txtnombre.Focus();
                btnremitir.Enabled = false;
            }
            else
            {
                epError.Clear();
            }
        }

       
       

        private void pictureBox1_Validated(object sender, EventArgs e)
        {
            if (pictureBox1.Image==Properties.Resources.avatardefault_92824)
            {
                epError.SetError(pictureBox1,"Seleccione una imagen");
                pictureBox1.Focus();
                
            }
            else
            {
                epError.Clear();
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            dtaexpe.DataSource = datos.mostrarestu(txtnom.Text);
        }

        private void dtaexpe_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            panelinfo.Visible = true;
            paneldegradado2.Visible = false;
            txtnombre.Texts = dtaexpe.CurrentRow.Cells["Nombre1"].Value.ToString();
            btnremitir.Enabled = true;
            btnlimpiar.Enabled = true;
            generar();
        }

        private void txtidre_Validated(object sender, EventArgs e)
        {
            if (txtidre.Texts.Trim() == "")
            {
                epError.SetError(txtnombre, "Intruzca un valor");
                txtnombre.Focus();
                btnremitir.Enabled = false;
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtid_Validated(object sender, EventArgs e)
        {
            if (txtid.Texts.Trim() == "")
            {
                epError.SetError(txtnombre, "Intruzca un valor");
                txtnombre.Focus();
                btnremitir.Enabled = false;
            }
            else
            {
                epError.Clear();
            }
        }

        private void NuevoExpe_Load(object sender, EventArgs e)
        {
            
        }

        private void Addmotivo_Click(object sender, EventArgs e)
        {
            AgregarMotivo agregar = new AgregarMotivo();
            agregar.ShowDialog();
            mostrar();
        }

        private void mostrar()
        {
            Nmotivo nmotivo = new Nmotivo();
            Motivo.DataSource =nmotivo.Mostarmotivo();
            Motivo.DisplayMember = "Motivos";
            Motivo.ValueMember = "ID_Motivo";
        }
    }
}
