using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using CAPA_NEGOCIO;
using CAPA_PRESENTACION;


namespace CAPA_PRESENTACION
{
    public partial class Principal : Form
    {
        NLogin permisos = new NLogin();
        public Principal()
        {
            InitializeComponent();
            ocultarmenu();
            if (permisos.anymetoth() == "Coordinador")
            {
                btncon.Visible = false;
                btncita.Visible = false;
                btnexpe.Visible = false;
            }
            

        }

        private string tema;
        private string tema2;
        private string te;
        private bool Ver;
        Temas temas = new Temas();


        public string Tema { get { return textBox1.Text; } }

       


        private void Principal_Load(object sender, EventArgs e)
        {
            Temas("Acua");

            Cargarfecha();

        }
        private void btncambiartema_Click(object sender, EventArgs e)
        {
           
            temas.ShowDialog();
            Temas(temas.Tema);
        }


        private void Temas(string tema)
        {

            Class1.ElegirTema(tema);
            paneldegradado1.Colorleft = Class1.PanelBotones;
            paneldegradado1.Colorrigth = Class1.panlebotones;
            panelFormhijo.BackColor = Class1.PanelPadre;
            paneldegradado2.BackColor = Class1.BarraTitulo;
            panel4.BackColor = Class1.BarraTitulo;
            opc.Colorleft = Class1.PanelBotones;
            opc.Colorrigth = Class1.panlebotones;
            dtaactividad.GridColor = Class1.PanelPadre;
            dtaactividad.ColumnHeadersDefaultCellStyle.BackColor = Class1.PanelPadre;
            dtaactividad.ColumnHeadersDefaultCellStyle.SelectionBackColor = Class1.PanelBotones;
            dtaactividad.DefaultCellStyle.BackColor = Class1.BarraTitulo;
            dtaactividad.DefaultCellStyle.SelectionBackColor = Class1.panlebotones;
            dtaactividad.RowHeadersDefaultCellStyle.BackColor = Class1.BarraTitulo;

            if (tema == "Acua")
            {
                textBox1.Text = "Acua";
               
            }
            else if (tema == "Celeste")
            {
                textBox1.Text = "Celeste";
                textBox1.Text = "Celeste";
            }
            else if (tema == "Morado")
            {
                textBox1.Text = "Morado";
             
            }
            else if (tema == "Verde")
            {
                textBox1.Text = "Verde";
               
            }
            else if (tema == "Defecto")
            {
                textBox1.Text = "Defecto";
               
            }

            this.Refresh();
        }
        




        private void btncloseform_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ocultarmenu()
        {
            panelsubmenucita.Visible = false;
            panelsubmenuconsulta.Visible = false;
            panelsubmenuexpe.Visible = false;
            panelsubmenuinformes.Visible = false;
        }

        private void btnresform_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnresform.Visible = false;
            btnmaxform.Visible = true;
            this.StartPosition = FormStartPosition.CenterScreen;

        }



        private void btnmaxform_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmaxform.Visible = false;
            btnresform.Visible = true;
        }

        private void btnminform_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ocultarsubmenu()
        {
            if (panelsubmenucita.Visible == true)
            {
                panelsubmenucita.Visible = false;
            }
            if (panelsubmenuconsulta.Visible == true)
            {
                panelsubmenuconsulta.Visible = false;
            }
            if (panelsubmenuexpe.Visible == true)
            {
                panelsubmenuexpe.Visible = false;
            }
            if (panelsubmenuinformes.Visible == true)
            {
                panelsubmenuinformes.Visible = false;
            }
        }

        private void mostrarsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }


        private void btninforme_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelsubmenuinformes);
        }
        private Form fomractive = null;

      

        private void abrirForm(Form formhijo)
        {
            if (fomractive != null)
            {
                fomractive.Close();
            }
            fomractive = formhijo; 
            formhijo.TopLevel = false;
            formhijo.FormBorderStyle = FormBorderStyle.None;
            formhijo.Dock = DockStyle.Fill;
            panelFormhijo.Controls.Add(formhijo);
            panelFormhijo.Tag = formhijo;
            formhijo.BringToFront();
            formhijo.Show();
        }

        private void btnverexpe_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
            abrirForm(new VerExpediente());
            
        }

        private void btnnuevoexpe_Click(object sender, EventArgs e)
        {
            ocultarmenu();
            abrirForm(new NuevoExpe());
        }

        private void btnverconsulta_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
            abrirForm(new VerConsulta());
           
        }

        private void btncon_Click(object sender, EventArgs e)
        {
          
            mostrarsubmenu(panelsubmenuconsulta);
            

        }

        private void btncita_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelsubmenucita);
           
        }

        private void btnexpe_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelsubmenuexpe);
        }

        private void btncon_MouseHover(object sender, EventArgs e)
        {
            btncon.BackColor = Color.Aqua;
        }

        private void btncon_MouseLeave(object sender, EventArgs e)
        {
            btncon.BackColor = Color.Transparent;
        }


        private void btncita_MouseHover(object sender, EventArgs e)
        {
            btncita.BackColor = Color.Aqua;
        }

        private void btncita_MouseLeave(object sender, EventArgs e)
        {
            btncita.BackColor = Color.Transparent;
        }

      
        private void btnexpe_MouseHover(object sender, EventArgs e)
        {
            btnexpe.BackColor = Color.Aqua;
        }

        private void btnexpe_MouseLeave(object sender, EventArgs e)
        {
            btnexpe.BackColor = Color.Transparent;
        }

        private void btninforme_MouseHover(object sender, EventArgs e)
        {
            btninforme.BackColor = Color.Aqua;
        }

        private void btninforme_MouseLeave(object sender, EventArgs e)
        {
            btninforme.BackColor = Color.Transparent;
        }

        private void btnverconsulta_MouseHover(object sender, EventArgs e)
        {
            btnverconsulta.BackColor = Color.Aquamarine;
        }

        private void btnverconsulta_MouseLeave(object sender, EventArgs e)
        {
            btnverconsulta.BackColor = Color.Transparent;
        }

        private void btniniciarconsulta_MouseHover(object sender, EventArgs e)
        {
            btniniciarconsulta.BackColor = Color.Aquamarine;
        }

        private void btniniciarconsulta_MouseLeave(object sender, EventArgs e)
        {
            btniniciarconsulta.BackColor = Color.Transparent;
        }

        private void btnvercitas_MouseHover(object sender, EventArgs e)
        {
            btnvercitas.BackColor = Color.Aquamarine;
        }

        private void btnvercitas_MouseLeave(object sender, EventArgs e)
        {
            btnvercitas.BackColor = Color.Transparent;
        }

        private void btnagendarcitas_MouseHover(object sender, EventArgs e)
        {
            btnagendarcitas.BackColor = Color.Aquamarine;
        }

        private void btnagendarcitas_MouseLeave(object sender, EventArgs e)
        {
            btnagendarcitas.BackColor = Color.Transparent;
        }

        private void btnverexpe_MouseHover(object sender, EventArgs e)
        {
            btnverexpe.BackColor = Color.Aquamarine;
        }

        private void btnverexpe_MouseLeave(object sender, EventArgs e)
        {
            btnverexpe.BackColor = Color.Transparent;
        }

        private void btnnuevoexpe_MouseHover(object sender, EventArgs e)
        {
            btnnuevoexpe.BackColor = Color.Aquamarine;
        }

        private void btnnuevoexpe_MouseLeave(object sender, EventArgs e)
        {
            btnnuevoexpe.BackColor = Color.Transparent;
        }

        private void btnverinformes_MouseHover(object sender, EventArgs e)
        {
            btnverinformes.BackColor = Color.Aquamarine;
        }

        private void btnverinformes_MouseLeave(object sender, EventArgs e)
        {
            btnverinformes.BackColor = Color.Transparent;
        }

        private void btngenerarinfo_MouseHover(object sender, EventArgs e)
        {
            btngenerarinfo.BackColor = Color.Aquamarine;
        }

        private void btngenerarinfo_MouseLeave(object sender, EventArgs e)
        {
            btngenerarinfo.BackColor = Color.Transparent;
        }

        private void btniniciarconsulta_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
            abrirForm(new IniciarConsulta());
            this.Refresh();
            
        }

  

        private void paneldegradado2_MouseDown_1(object sender, MouseEventArgs e)
        {
        }

        private void btnagendarcitas_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
            abrirForm(new Agendarcita());
            this.Refresh();
        }

        CitaN cita = new CitaN();
        private void Cargarfecha()
        {
            string fecha = DateTime.Now.ToShortDateString();
           dtaactividad.DataSource = cita.filtro(Convert.ToDateTime(fecha));
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void dtaactividad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnvercitas_Click(object sender, EventArgs e)
        {
            abrirForm(new Ver_cita());
            this.Refresh();
        }

        private void Congf_Click(object sender, EventArgs e)
        {
            
            if (opc.Visible == false)
            {
                opc.Visible = true;
            }
            else
            {
                opc.Visible = false;
            }
        }

        private void btncerrarsesion_Click(object sender, EventArgs e)
        {
            this.Close();
            Formcierre formcierre = new Formcierre();
            formcierre.ShowDialog();
            Login login = new Login();
            login.Show();
        }

        private void btncambiarcon_Click(object sender, EventArgs e)
        {
            Cambiar_contraseña cambiar = new Cambiar_contraseña();
            cambiar.Show();
        }

      

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            bunifuLabel1.Text = DateTime.Now.ToString("HH:mm:ss");
            bunifuLabel2.Text = DateTime.Now.ToLongDateString();
        }

        private void btnseguimiento_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panel5);
        }

        private void btnversegui_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
            abrirForm(new Actualizar_formulario());

        }

        private void btngenerarinfo_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
            abrirForm(new Graficos());
        }

        private void btnverinformes_Click(object sender, EventArgs e)
        {

        }
    }
} 
    

