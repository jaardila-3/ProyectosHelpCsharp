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
    
    public partial class PROYECTO_NOVEDAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROYECTO_NOVEDAD()
        {
            this.PROYECTO_FUNCIONARIO = new HashSet<PROYECTO_FUNCIONARIO>();
            this.OBSERVACION_PROYECTO = new HashSet<OBSERVACION_PROYECTO>();
        }
    
        public string PROYECTO_NOVEDAD_ID { get; set; }
        public string NUMERO_PROYECTO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROYECTO_FUNCIONARIO> PROYECTO_FUNCIONARIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OBSERVACION_PROYECTO> OBSERVACION_PROYECTO { get; set; }
    }
}
