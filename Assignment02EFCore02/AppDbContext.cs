using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02EFCore02
{
    internal class AppDbContext : DbContext
    {

 
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Badge> Badges { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Organizer> Organizers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;Database=EventHub;Trusted_Connection=true;TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventAttendees>().HasKey(EA => new { EA.EventId, EA.AttendeeId });
            modelBuilder.Entity<Attendee>().HasOne(a => a.AttendeeBadge).WithOne(b => b.Attendee).HasForeignKey<Attendee>(a => a.BadgeId);
            modelBuilder.Entity<Event>().Property<DateTime>("CreatedAt");
            modelBuilder.Entity<Event>().Property<DateTime>("UpdatedAt");
        }
    }
}
