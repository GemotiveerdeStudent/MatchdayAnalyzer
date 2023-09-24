using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace MatchdayAnalyzer.Models.ClassModels
{
    public class Attendance
    {
        public int Id { get; set; }
        public virtual ICollection<Player>? Players { get; set; } = new List<Player>();
        public virtual ICollection<Game>? Games { get; set; }
    }
}

