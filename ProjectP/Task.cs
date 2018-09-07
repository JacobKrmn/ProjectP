using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectP
{
    class Task
    {
        public string taskName { get; set; }
        public DateTime DateAndTimePlanned { get; set; }
        public bool planned { get; set; }
        public bool finished { get; set; }
        public int estimatedTime { get; set; }

        public Task(string taskName, DateTime DateAndTimePlanned, bool planned, bool finished, int estimatedTime) {
            this.taskName = taskName;
            this.DateAndTimePlanned = DateAndTimePlanned;
            this.planned = planned;
            this.finished = finished;
            this.estimatedTime = estimatedTime;
        }

        

    }
}
