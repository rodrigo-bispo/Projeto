//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Monitoria.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Curso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Curso()
        {
            this.Materias = new HashSet<Materia>();
            this.Usuarios = new HashSet<Usuario>();
        }
        [Key]
        public int CursoID { get; set; }

        [Display(Name = "Nome do Curso")]
        [Required(ErrorMessage = "O campo nome do curso � Obrigat�rio")]
        public string Nome { get; set; }

        [Display(Name = "Dura��o")]
        [Required(ErrorMessage = "O campo Dura��o � Obrigat�rio")]
        public string Duracao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Materia> Materias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuario> Usuarios { get; set; }
        public virtual Semestre Semestre { get; set; }

    }
}
