using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace MatchdayAnalyzer.Models.ClassModels
{
    public class Team
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }
        public Season? Seasons { get; set; }
        public virtual ICollection<Player>? Players { get; set; }
        public virtual ICollection<Game>? Games { get; set; }
    }
}
