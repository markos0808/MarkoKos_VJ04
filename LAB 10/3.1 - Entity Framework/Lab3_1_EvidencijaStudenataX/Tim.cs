//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab3_1_EvidencijaStudenataX
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tim
    {
        public Tim()
        {
            this.Studenti = new HashSet<Student>();
        }
    
        public int Id { get; set; }
        public string OznakaTima { get; set; }
        public string NazivProjekta { get; set; }
        public string OpisProjekta { get; set; }
        public string Napomena { get; set; }
    
        public virtual ICollection<Student> Studenti { get; set; }
    }
}