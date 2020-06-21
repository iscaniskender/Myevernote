using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MyEvernote.Entities;


namespace MyEvernote.DataAcessLayer.dll.EntityFreamwork
{
    public class DatabaseContex :DbContext
    {
        public DbSet<EvernoteUser> EvernoteUsers { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Liked> Likes { get; set; }

        public DatabaseContex()
        {
            Database.SetInitializer(new DataAccessLayer.dll.EntityFreamwork.MyInitializer());
        }
    }
}
