//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbpersona
    {
        public tbpersona()
        {
            this.tbusuario = new HashSet<tbusuario>();
        }
    
        public int cod_persona { get; set; }
        public string nombre { get; set; }
        public string ap_paterno { get; set; }
        public string ap_materno { get; set; }
        public Nullable<int> estado { get; set; }
        public Nullable<System.DateTime> fecha_creacion { get; set; }
    
        public virtual ICollection<tbusuario> tbusuario { get; set; }
    }
}
