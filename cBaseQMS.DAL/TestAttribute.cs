//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cBaseQms.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TestAttribute
    {
        public int TestAttrID { get; set; }
        public int TestID { get; set; }
        public short Sequence { get; set; }
        public string Attribute { get; set; }
        public string Value { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
    
        public virtual Test Test { get; set; }
    }
}
