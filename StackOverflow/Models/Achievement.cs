using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverflow.Models
{
    public class Achievement
    {
        public int AchievementId { get; set; }

        public string AchievementName { get; set; }

        //We use ICollection because we want to establish a many-to-many connection
        //Namely a user can have one or more achievements and vice versa.
        public ICollection<UserAchievement> UserAchievements { get; set; }
    }
}
