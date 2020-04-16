using Microsoft.EntityFrameworkCore;
using StackOverflow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverflow
{
     public class StackOverflowContext : DbContext
    {
        public StackOverflowContext (DbContextOptions<StackOverflowContext> options)
                : base(options)
        {


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { //sequence of code to configure the Fluent API so as
          // to create the many to many relationship between the users and achievements
            modelBuilder.Entity<UserAchievement>()
                .HasKey(bc => new { bc.UserId, bc.AchievementId });
            modelBuilder.Entity<UserAchievement>()
                .HasOne(bc => bc.User)
                .WithMany(b => b.UserAchievements)
                .HasForeignKey(bc => bc.UserId);
            modelBuilder.Entity<UserAchievement>()
                .HasOne(bc => bc.Achievement)
                .WithMany(c => c.UserAchievements)
                .HasForeignKey(bc => bc.AchievementId);

            //sequence of code to configure the Fluent API so as
            // to create the many to many relationship between the Tag and Questions
            modelBuilder.Entity<TagQuestion>()
                .HasKey(bc => new { bc.TagId, bc.QuestionId });
            modelBuilder.Entity<TagQuestion>()
                .HasOne(bc => bc.Question)
                .WithMany(b => b.TagQuestions)
                .HasForeignKey(bc => bc.QuestionId);
            modelBuilder.Entity<TagQuestion>()
                .HasOne(bc => bc.Tag)
                .WithMany(c => c.TagQuestions)
                .HasForeignKey(bc => bc.TagId);

            //configuring one-to-many User-Question
            modelBuilder.Entity<User>()
                .HasMany(c => c.Questions)
                .WithOne(e => e.User);
            
            //configuring one-to-many Question-Answer
            modelBuilder.Entity<Question>()
                .HasMany(c => c.Answers)
                .WithOne(e => e.Question);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Achievement> Achievements{ get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<News> News { get; set; }

        public DbSet<Question> Questions { get; set; }
        public DbSet<ScoreboardPosition> ScoreboardPositions { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public DbSet<UserAchievement> UserAchievements { get; set; }


    }
}
