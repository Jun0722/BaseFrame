using System;
using EFCoreDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDemo.Data
{
    public class NoteContext:DbContext
    {
        public NoteContext(DbContextOptions<NoteContext> options)
            :base(options)
        {
            
        }
        public DbSet<Note> Notes { get; set; }
        public DbSet<NoteType> NoteTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NoteType>()
                        .HasMany(n => n.Notes)
                        .WithOne(n => n.Type)
                        .HasForeignKey(k => k.TypeId);
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
