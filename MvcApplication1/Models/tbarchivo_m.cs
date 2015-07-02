using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MvcApplication1.Models;

namespace MvcApplication1.Models
{
    [MetadataType(typeof(itbarchivo))]
    public partial class tbarchivo
    {
    }
    public interface itbarchivo
    {
        [Key]
        [ScaffoldColumn(false)]
        object cod_archivo { get; set; }

        [Required]
        [RegularExpression(@"[0-9]*\.?[0-9]+", ErrorMessage = "Error dato incorrecto")]
        object cod_notas { get; set; }

        [Required(ErrorMessage = "Necesitamos una descripcion de su archivo")]
        object descripcion { get; set; }

    }
}