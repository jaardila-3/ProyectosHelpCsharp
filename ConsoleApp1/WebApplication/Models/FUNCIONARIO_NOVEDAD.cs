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
    
    public partial class FUNCIONARIO_NOVEDAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FUNCIONARIO_NOVEDAD()
        {
            this.OBSERVACION_FUNCIONARIO = new HashSet<OBSERVACION_FUNCIONARIO>();
            this.PROYECTO_FUNCIONARIO = new HashSet<PROYECTO_FUNCIONARIO>();
        }
    
        public string FUNCIONARIO_NOVEDAD_ID { get; set; }
        public int IDENTIFICACION__IDENTIFICACION__IDENTIFICACION_ { get; set; }
        public int CONSECUTIVO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OBSERVACION_FUNCIONARIO> OBSERVACION_FUNCIONARIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROYECTO_FUNCIONARIO> PROYECTO_FUNCIONARIO { get; set; }
    }
}