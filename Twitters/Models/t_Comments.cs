//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Twitters.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class t_Comments
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public t_Comments()
        {
            this.t_CommentVotes = new HashSet<t_CommentVotes>();
        }
    
        public int CommentID { get; set; }
        public int UserID { get; set; }
        public string Text { get; set; }
        public int PostID { get; set; }
    
        public virtual t_Posts t_Posts { get; set; }
        public virtual t_Users t_Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_CommentVotes> t_CommentVotes { get; set; }
    }
}
