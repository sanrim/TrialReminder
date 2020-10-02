using System;
using System.ComponentModel;

namespace TrialReminder.Models.Trials
{
    public class TrialSummaryItemModel
    {
        public int Id { get; set; }
        [DisplayName("Name of Service")]
        public string ServiceName { get; set; }
        public string Url { get; set; }
        public DateTime StartDate { get; set; }
        public bool HasStartDate { get; set; }

        public DateTime EndDate { get; set; }
        public bool HasEndDate { get; set; }

        public bool IsExpired { get; set; }
    }
}
