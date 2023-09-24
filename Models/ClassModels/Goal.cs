using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MatchdayAnalyzer.Models.ClassModels
{
    public class Goal
    {
        public int Id { get; set; }
        public int? GameId { get; set; }
        public int? PlayerId { get; set; }
        public int? MatchGoals { get; set; } = 0;
        public virtual Player? player { get; set; }
        public virtual Game? Game { get; set; }


    }
}
