//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SSM.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class productMarketPlan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public productMarketPlan()
        {
            this.Customer_Request = new HashSet<Customer_Request>();
            this.Deal_Item = new HashSet<Deal_Item>();
            this.Licenses = new HashSet<License>();
            this.OrderItems = new HashSet<OrderItem>();
            this.PlanOptions = new HashSet<PlanOption>();
            this.TrialAccounts = new HashSet<TrialAccount>();
        }
    
        public int id { get; set; }
        public int productID { get; set; }
        public double Price { get; set; }
        public double ceilPrice { get; set; }
        public double floorprice { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public System.DateTime CreatedDay { get; set; }
        public Nullable<System.DateTime> lastUpdate { get; set; }
        public bool isActive { get; set; }
        public bool operating { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer_Request> Customer_Request { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Deal_Item> Deal_Item { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<License> Licenses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanOption> PlanOptions { get; set; }
        public virtual softwareProduct softwareProduct { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrialAccount> TrialAccounts { get; set; }
    }
}
