//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CAPA_PRESENTACION
{
    using System;
    using System.Collections.Generic;
    
    public partial class Seguimiento
    {
        public int ID_Seguimiento { get; set; }
        public Nullable<System.DateTime> Fecha_inicio { get; set; }
        public Nullable<System.DateTime> Fecha_final { get; set; }
        public string Observaciones { get; set; }
        public Nullable<int> ID_Expediente { get; set; }
    }
}
