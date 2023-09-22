using System.ComponentModel.DataAnnotations;

namespace MatchdayAnalyzer.Models.ClassModels
{
    public class Game
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
        [Required]
        [StringLength(100)]
        public string? OpponentTeam { get; set; }
        [Required]
        public int? HomeTeamScore { get; set; }
        [Required]
        public int? AwayTeamScore { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<Team>? TeamsList { get; set; }
        public virtual ICollection<Goal>? GoalList { get; set; }


        public Game()
        {

        }
    }
}
