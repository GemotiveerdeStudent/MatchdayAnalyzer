using System.ComponentModel.DataAnnotations;

namespace MatchdayAnalyzer.Models.ClassModels
{
    public class Season
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string? Name { get; set; }
        public DateTime? Date { get; set; }
        public virtual ICollection<Team>? Teams { get; set; }

    }
}

