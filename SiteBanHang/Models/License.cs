//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SiteBanHang.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class License
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public License()
        {
            this.OrderItems = new HashSet<OrderItem>();
        }
    
        public int id { get; set; }
        public Nullable<int> licenseType { get; set; }
        public Nullable<int> licenseDuration { get; set; }
        public Nullable<int> status { get; set; }
        public Nullable<int> customerID { get; set; }
        public Nullable<System.DateTime> nextTransactionDate { get; set; }
        public Nullable<System.DateTime> startDate { get; set; }
        public int PlanID { get; set; }
        public string SaleRepResponsible { get; set; }
        public string LicenseKey { get; set; }
        public string LinkUse { get; set; }
        public string AdminAccount { get; set; }
        public string AdminPassword { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual customer customer { get; set; }
        public virtual productMarketPlan productMarketPlan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
