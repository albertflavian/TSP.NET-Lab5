
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFStudiuDeCaz.SelfReferences
{
    public class SelfReference
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SelfReferenceId { get; private set; }
        public string Name { get; set; }
        public int? ParentSelfReferenceId { get; private set; }
        [ForeignKey("ParentSelfReferenceId")]
        public SelfReference ParentSelfReference { get; set; }
        public virtual ICollection<SelfReference> References { get; set; }
        public SelfReference()
        {
            References = new List<SelfReference>();
        }
    }
}
