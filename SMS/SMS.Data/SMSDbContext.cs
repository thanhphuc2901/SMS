using Microsoft.AspNet.Identity.EntityFramework;
using Model.Framework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data
{
    class SMSDbContext:DbContext
    {

        public SMSDbContext() : 
            base("SMS"){}

        //model
        public virtual DbSet<Bring_In> Bring_In { get; set; }
        public virtual DbSet<Bring_In_Items> Bring_In_Items { get; set; }
        public virtual DbSet<Bring_Out> Bring_Out { get; set; }
        public virtual DbSet<Bring_Out_Items> Bring_Out_Items { get; set; }
        public virtual DbSet<Go_Out> Go_Out { get; set; }
        public virtual DbSet<GroupUser> GroupUsers { get; set; }
        public virtual DbSet<Guest> Guests { get; set; }
        public virtual DbSet<Guest_Item> Guest_Item { get; set; }
        public virtual DbSet<HRTTemplate> HRTTemplates { get; set; }
        public virtual DbSet<Leave_Early> Leave_Early { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }


    }

}
