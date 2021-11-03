using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;
using CAPA_DATOS.usercache;
using System.Data;

namespace CAPA_NEGOCIO
{
    public class NLogin
    {
        public NLogin()
        {
        }
        DLogin dLogin = new DLogin();

        public  string loginuser(string user, string pass)
        {
            DLogin dLogin = new DLogin();

            dLogin.Nombre = user;
            dLogin.Contraseña= pass;

            return dLogin.INICIO(dLogin);
        }
        public string recory(string recovery)
        {
            
            DLogin datos = new DLogin();
            datos.Nombre = recovery;
            datos.recovery(datos);
            return datos.recovery(datos); ;
        }

    

     

        public string anymetoth()
        {
            string retorno;
            if (USERcache.Nombre == Cargos.Administrador)
            {
                retorno = Cargos.Administrador;
            }
            else 
            {
                retorno =Cargos.Coordinador; 
            }

            return retorno;

        }

        public string anymetothcon( string con)
        {
            string retorno;
            if (USERcache.Contraseña == con)
            {
                retorno = "ok";
            }
            else
            {
                retorno = "No";
            }

            return retorno;

        }



        public string cambiopassword(string user, string pass, string ncon)
        {
            DLogin dLogin = new DLogin();

            dLogin.Nombre = user;
            dLogin.Contraseña = pass;
            dLogin.Camcontra = ncon;

            return dLogin.Cpassword(dLogin);
        }
       
    }
    
}
