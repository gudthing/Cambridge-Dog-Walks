//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DogWalks.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserProfile
    {
        public UserProfile()
        {
            this.DogWalks = new HashSet<DogWalk>();
        }
    
        public int UserID { get; set; }
        public string ProfilePicture { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Postcode { get; set; }
        public string FKUserID { get; set; }
        public Nullable<System.DateTime> JoinDateTime { get; set; }
        public string AboutMe { get; set; }
    
        public virtual ICollection<DogWalk> DogWalks { get; set; }
    }
}
