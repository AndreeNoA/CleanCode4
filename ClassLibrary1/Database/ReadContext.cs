using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Models;

namespace Database.Database
{
    //public class ReadContext : DbContext
    //{
    //    public ReadContext()
    //    {
    //    }
    //
    //    public ReadContext(DbContextOptions<ReadContext> options) : base(options)
    //    {
    //        var msg = new[]
    //        {
    //            new Message
    //            {
    //                Id = Guid.Parse("9f35b48d-cb87-4783-bfdb-21e36012930a"),
    //                Text = "Här har du lite text",
    //                Author = "Andree"
    //            },
    //            new Message
    //            {
    //                Id = Guid.Parse("bffcf83a-0224-4a7c-a278-5aae00a02c1e"),
    //                Text = "Ett väldigt viktigt meddelande",
    //                Author = "Andree"
    //            }
    //        };
    //        Messages.AddRange(msg);
    //        SaveChanges();
    //    }
    //
    //    public virtual DbSet<Message> Messages { get; set; }
    //
    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //    }
    //
    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");
    //
    //        modelBuilder.Entity<Message>(entity =>
    //        {
    //            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
    //
    //            entity.Property(e => e.Text).IsRequired();
    //        });
    //    }
    //}
}
