//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataService.Models.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class StoreDomain
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public string Protocol { get; set; }
        public string HostName { get; set; }
        public int Port { get; set; }
        public string Directory { get; set; }
        public bool Active { get; set; }
    
        public virtual Store Store { get; set; }
    }
}
