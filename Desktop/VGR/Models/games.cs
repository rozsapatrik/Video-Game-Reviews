//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VGR.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class games
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public games()
        {
            this.reviews = new HashSet<reviews>();
        }
    
        public long ID { get; set; }
        public string GameName { get; set; }
        public string Description { get; set; }
        public System.DateTime ReleaseDate { get; set; }
        public string MainPlatform { get; set; }
        public string MainGenre { get; set; }
        public string Developer { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reviews> reviews { get; set; }
    }
}
