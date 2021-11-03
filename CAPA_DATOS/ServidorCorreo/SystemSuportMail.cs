using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS.ServidorCorreo
{
    class SystemSuportMail : MasterMailServer
    {

        public SystemSuportMail()
        {
            senderMail = "soporteadmipsicologia@gmail.com";
            password = "admin4321";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();
        }

    }
}
