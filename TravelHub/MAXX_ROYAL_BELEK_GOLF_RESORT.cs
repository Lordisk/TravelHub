//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TravelHub
{
    using System;
    using System.Collections.Generic;
    
    public partial class MAXX_ROYAL_BELEK_GOLF_RESORT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MAXX_ROYAL_BELEK_GOLF_RESORT()
        {
            this.Basket = new HashSet<Basket>();
        }
    
        public int idRoom { get; set; }
        public string NameRoom { get; set; }
        public string Accessibility { get; set; }
        public string People { get; set; }
        public Nullable<decimal> Price1day { get; set; }
        public Nullable<int> idHotels { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Basket> Basket { get; set; }
        public virtual Hotels Hotels { get; set; }
    }
}
