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
    
    public partial class tbarchivo
    {
        public int cod_archivo { get; set; }
        public Nullable<int> cod_notas { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string formato { get; set; }
        public string tamaño { get; set; }
        public string direccion { get; set; }
    
        public virtual tbnotas tbnotas { get; set; }
    }
}
