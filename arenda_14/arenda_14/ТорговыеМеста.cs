//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace arenda_14
{
    using System;
    using System.Collections.Generic;
    
    public partial class ТорговыеМеста
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ТорговыеМеста()
        {
            this.Аренда = new HashSet<Аренда>();
        }
    
        public int КодТорговогоМеста { get; set; }
        public string НомерТорговогоМеста { get; set; }
        public short Этаж { get; set; }
        public float Площадь { get; set; }
        public string ЕдИзм { get; set; }
        public float Ставка { get; set; }
        public string ЕдИзм_ { get; set; }
        public Nullable<bool> Арендовано { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Аренда> Аренда { get; set; }
    }
}
