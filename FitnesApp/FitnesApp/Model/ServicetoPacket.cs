//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FitnesApp.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ServicetoPacket
    {
        public int Id { get; set; }
        public int Service_Id { get; set; }
        public int Packet_Id { get; set; }
    
        public virtual Packet Packet { get; set; }
        public virtual Service Service { get; set; }
    }
}
