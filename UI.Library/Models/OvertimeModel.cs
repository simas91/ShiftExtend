using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Library.Models
{
    public class OvertimeModel
    {
        public int? Id { get; set; }
        public DateTime? OvertimeDate { get; set; } = DateTime.Now;
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public bool OP { get; set; }
        public bool? CB { get; set; }
        public bool? RT { get; set; }
        public bool? Pack { get; set; }
    }
}
