using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GymApi.Models
{
    public partial class GymApi_DBContext : DbContext
    {
        public GymApi_DBContext()
        {
        }

        public GymApi_DBContext(DbContextOptions<GymApi_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Coach> Coach { get; set; }
        public virtual DbSet<FoodScheduleId> FoodScheduleId { get; set; }
        public virtual DbSet<Gym> Gym { get; set; }
        public virtual DbSet<Member> Member { get; set; }
        public virtual DbSet<PracticeSchedule> PracticeSchedule { get; set; }

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coach>(entity =>
            {
                entity.Property(e => e.Age)
                    .HasColumnName("age")
                    .HasMaxLength(50);

                entity.Property(e => e.Exprience).HasMaxLength(50);

                entity.Property(e => e.GymId).HasColumnName("Gym_Id");

                entity.Property(e => e.NumberOfMemberManege).HasMaxLength(50);

                entity.HasOne(d => d.Gym)
                    .WithMany(p => p.Coach)
                    .HasForeignKey(d => d.GymId)
                    .HasConstraintName("FK_Coach_Gym");
            });

            modelBuilder.Entity<FoodScheduleId>(entity =>
            {
                entity.HasKey(e => e.FoodScheduleId1);

                entity.Property(e => e.FoodScheduleId1).HasColumnName("FoodScheduleId");

                entity.Property(e => e.Chicken).HasMaxLength(50);

                entity.Property(e => e.Egg).HasMaxLength(50);

                entity.Property(e => e.Fish).HasMaxLength(50);

                entity.Property(e => e.MemberId).HasColumnName("Member_Id");

                entity.Property(e => e.Milk).HasMaxLength(50);

                entity.Property(e => e.Potato).HasMaxLength(50);

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.FoodScheduleId)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK_FoodScheduleId_Member");
            });

            modelBuilder.Entity<Gym>(entity =>
            {
                entity.Property(e => e.Adress).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.Property(e => e.Age).HasMaxLength(50);

                entity.Property(e => e.CoachId).HasColumnName("Coach_Id");

                entity.Property(e => e.FullName).HasMaxLength(50);

                entity.Property(e => e.GymId).HasColumnName("Gym_Id");

                entity.Property(e => e.Height).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.TimeAttendance).HasMaxLength(50);

                entity.Property(e => e.Weight).HasMaxLength(50);

                entity.HasOne(d => d.Coach)
                    .WithMany(p => p.Member)
                    .HasForeignKey(d => d.CoachId)
                    .HasConstraintName("FK_Member_Coach");

                entity.HasOne(d => d.Gym)
                    .WithMany(p => p.Member)
                    .HasForeignKey(d => d.GymId)
                    .HasConstraintName("FK_Member_Gym");
            });

            modelBuilder.Entity<PracticeSchedule>(entity =>
            {
                entity.Property(e => e.JoloBazoDambal).HasMaxLength(100);

                entity.Property(e => e.JoloBzoHalter).HasMaxLength(100);

                entity.Property(e => e.JoloPa).HasMaxLength(100);

                entity.Property(e => e.MemberId).HasColumnName("Member_Id");

                entity.Property(e => e.PoshtBazo).HasMaxLength(100);

                entity.Property(e => e.PoshtePa).HasMaxLength(100);

                entity.Property(e => e.PresSineHalter).HasMaxLength(100);

                entity.Property(e => e.SaghPa).HasMaxLength(100);

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.PracticeSchedule)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK_PracticeSchedule_Member");
            });
        }
    }
}
