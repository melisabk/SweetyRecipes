//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RecipeSites.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLUSER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLUSER()
        {
            this.TBLCOMMENT = new HashSet<TBLCOMMENT>();
            this.TBLRATING = new HashSet<TBLRATING>();
        }
    
        public int User_Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string NameSurname { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> Add_ModifyDate { get; set; }
        public string Role { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLCOMMENT> TBLCOMMENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLRATING> TBLRATING { get; set; }
    }
}
