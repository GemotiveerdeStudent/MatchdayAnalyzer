using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.ComponentModel.DataAnnotations.Schema;

namespace MatchdayAnalyzer.Models.ClassModels

{
    public partial class Player
    {
        [NotMapped]
        public int? TotalGoals
        {
            get
            {
                int? totalGoals = 0;

                foreach (Goal matchGoals in Goals)
                {
                    if (matchGoals.PlayerId == this.Id)
                    {
                        totalGoals += matchGoals.MatchGoals;
                    }
                }

                return totalGoals;
            }
        }
    }

}

