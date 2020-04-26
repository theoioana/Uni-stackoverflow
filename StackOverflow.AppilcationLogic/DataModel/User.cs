using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverflow.AppilcationLogic.DataModel
{
    public class User
    {
        public int UserId { get; set; }
        public string EmailAdress { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string University { get; set; }
        public int GithubRating { get; set; }
        public int CodeforcesRating { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }
        public int PointsAccumulated { get; set; }

        //We use ICollection because we want to establish a many-to-many connection
        //Namely a user can have one or more achievements and vice versa.
        public ICollection<UserAchievement> UserAchievements { get; set; }

        //We will configure a one-to-one relationship with ScoreBoardPosition

        public ScoreboardPosition ScoreboardPosition { get; set; }

        //configuring one-to-many relation between User and Question

        public ICollection<Question> Questions { get; set; }

    }
}
