using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrialReminder.Models.Trials
{
    public class TrialSummaryModel
    {
        public List<TrialSummaryItemModel> Trials { get; set; }
        public int NumberOfCurrentTrials { get; set; }
        public int NumberOfExpiredTrials { get; set; }
      
    }


}
