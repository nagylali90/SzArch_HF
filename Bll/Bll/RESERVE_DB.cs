//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bll
{
    using System;
    using System.Collections.Generic;
    
    public partial class RESERVE_DB
    {
        public int RESERVE_ID { get; set; }
        public int TIC_CAT_ID { get; set; }
        public int USER_ID { get; set; }
    
        public virtual CATEGORY CATEGORY { get; set; }
    }
}
