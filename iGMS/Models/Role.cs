//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iGMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Role
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Role()
        {
            this.Users = new HashSet<User>();
        }
    
        public int Id { get; set; }
        public Nullable<bool> Admin { get; set; }
        public Nullable<bool> EditDiscountGoods { get; set; }
        public Nullable<bool> EditDiscountBill { get; set; }
        public Nullable<bool> EditPriceGoods { get; set; }
        public Nullable<bool> EditAmountGoods { get; set; }
        public Nullable<bool> DeleteGoods { get; set; }
        public Nullable<bool> PrintAgainBill { get; set; }
        public Nullable<bool> HangBill { get; set; }
        public Nullable<bool> ChangeCateGoods { get; set; }
        public Nullable<bool> ChangeUnit { get; set; }
        public Nullable<bool> EditDate { get; set; }
        public Nullable<bool> IdentifyConsultants { get; set; }
        public Nullable<bool> ConfirmCusInfor { get; set; }
        public Nullable<bool> ReturnGoods { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
    }
}
