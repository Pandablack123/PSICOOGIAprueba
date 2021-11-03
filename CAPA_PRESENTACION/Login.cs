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
    public partial class Login : Form
    {
        string retorno= "Everithing its ok";
        public Login()
        {
            InitializeComponent();
            
        }

        public string nombre;

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Texts == "User")
            {
                txtuser.Texts = "";
                txtuser.ForeColor = Color.Black;
                nombre = txtuser.Text;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Texts == "")
            {
                txtuser.Texts = "User";
               
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Texts == "Password")
            {
                txtpass.Texts = "";
                txtpass.PasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Texts == "")
            {
                txtpass.Texts = "Password";
                txtpass.PasswordChar = false;

            }
            else
            {
                txtpass.PasswordChar = true;
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            inicio();
        }
        private void msgError(string msg)
        {
            lblnot.Text="  " + msg;
            lblnot.Visible = true;
          
        }

        private void btnlogin_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void inicio()
        {
            if (txtuser.Texts != "User")
            {
                if (txtpass.Texts != "Pass")
                {
                    NLogin nLogin = new NLogin();
                    string validation = nLogin.loginuser(txtuser.Texts, txtpass.Texts);

                    if (validation == retorno)
                    {
                        this.Hide();
                        Formwelcome formwelcome = new Formwelcome();
                        formwelcome.ShowDialog();
                        Principal principal = new Principal();
                        principal.Show();

                    }
                    else msgError("Usuario incorrecto o contraseña incorrecta");



                }
                else msgError("Please enter password");



            }
            else msgError("Please enter User");
        }

        private void btnver_Click(object sender, EventArgs e)
        {

            if (txtpass.Texts != "")
            {
                if (txtpass.PasswordChar == true)
                {
                    txtpass.PasswordChar = false;
                }
                else
                {
                    txtpass.PasswordChar = true;
                }
            }
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            var recorypass = new Recovery();
            recorypass.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recorypass = new Recovery();
            recorypass.ShowDialog();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            inicio();
        }
    }
}
