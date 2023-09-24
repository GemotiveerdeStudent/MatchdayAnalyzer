using System.ComponentModel.DataAnnotations;

namespace MatchdayAnalyzer.Models.ClassModels
{
    public class Player

    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string? Name { get; set; }
        [Required]
        [StringLength(50)]
        public string? Position { get; set; }
        public int? TotalGoals { get; set; }
        public virtual Team? Team { get; set; }
        public int? TeamId { get; set; }
        public virtual int? AttendanceId { get; set; } 
        public virtual Attendance? Attendance { get; set;}
        public virtual ICollection<Goal>? Goals { get; set; }
    }
}

