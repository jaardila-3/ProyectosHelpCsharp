//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OBSERVACION_PROYECTO
    {
        public string OBSERVACION_PROYECTO_ID { get; set; }
        public string PROYECTO_NOVEDAD_ID { get; set; }
        public string OBSERVACION { get; set; }
    
        public virtual PROYECTO_NOVEDAD PROYECTO_NOVEDAD { get; set; }
    }
}
