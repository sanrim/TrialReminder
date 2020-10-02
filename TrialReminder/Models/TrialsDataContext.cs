using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrialReminder.Models
{
    public class TrialsDataContext : DbContext
    {
        public TrialsDataContext(DbContextOptions<TrialsDataContext> options) : base(options)
        {

        }

        public virtual DbSet<Trial> Trials { get; set; }
    }
}
