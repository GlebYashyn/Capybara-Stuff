//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Capybara_Stuff.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public Nullable<int> BookId { get; set; }
        public Nullable<int> AnimeId { get; set; }
        public int Rate { get; set; }
        public Nullable<System.DateTime> DateEnded { get; set; }
        public int StatusId { get; set; }
    
        public virtual Anime Anime { get; set; }
        public virtual Book Book { get; set; }
        public virtual Status Status { get; set; }
        public virtual User User { get; set; }
    }
}