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
    
    public partial class Hotels
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hotels()
        {
            this.LUJO_BODRUM = new HashSet<LUJO_BODRUM>();
            this.MAXX_ROYAL_BELEK_GOLF_RESORT = new HashSet<MAXX_ROYAL_BELEK_GOLF_RESORT>();
            this.STEIGENBERGER_ALCAZAR = new HashSet<STEIGENBERGER_ALCAZAR>();
            this.VOYAGE_SORGUN = new HashSet<VOYAGE_SORGUN>();
        }
    
        public int idHotels { get; set; }
        public string Hotels1 { get; set; }
        public string Stars { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LUJO_BODRUM> LUJO_BODRUM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAXX_ROYAL_BELEK_GOLF_RESORT> MAXX_ROYAL_BELEK_GOLF_RESORT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STEIGENBERGER_ALCAZAR> STEIGENBERGER_ALCAZAR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VOYAGE_SORGUN> VOYAGE_SORGUN { get; set; }
    }
}
