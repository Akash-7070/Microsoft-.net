//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBset
{
    using System;
    using System.Collections.Generic;
    
    public partial class CompModel
    {
        public CompModel()
        {
            this.CustModels = new HashSet<CustModel>();
        }
    
        public int Id { get; set; }
        public string Cname { get; set; }
    
        public virtual ICollection<CustModel> CustModels { get; set; }
    }
}
