//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BDProject.Models
{
    using System;
    using System.Collections.Generic;
	using System.ComponentModel;

	public partial class Warehouse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Warehouse()
        {
            this.Inventories = new HashSet<Inventory>();
        }

		[DisplayName("Almacén")]
		public int warehouse_id { get; set; }
		[DisplayName("Especificación")]
		public string warehouse_spec { get; set; }
		[DisplayName("Nombre")]
		public string warehouse_name { get; set; }
		[DisplayName("Ubicación")]
		public Nullable<int> location_id { get; set; }
		[DisplayName("Ubicación geográfica")]
		public System.Data.Entity.Spatial.DbGeography wh_geo_location { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inventory> Inventories { get; set; }
		[DisplayName("Ubicación")]
		public virtual Location Location { get; set; }
    }
}
