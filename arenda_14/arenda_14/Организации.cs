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
    
    public partial class Организации
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Организации()
        {
            this.Аренда = new HashSet<Аренда>();
        }
    
        public int КодОрганизации { get; set; }
        public string Организация { get; set; }
        public string ОрганизацияКратко { get; set; }
        public string УНП { get; set; }
        public string БИКБанка { get; set; }
        public string Банк { get; set; }
        public string РасчётныйСчёт { get; set; }
        public string ПочтовыйИндекс { get; set; }
        public string Город { get; set; }
        public string Адрес { get; set; }
        public string Телефон { get; set; }
        public string ПочтовыйЯщик { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Аренда> Аренда { get; set; }
    }
}
