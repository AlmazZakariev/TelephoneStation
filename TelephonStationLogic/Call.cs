using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephonStationLogic
{
    public class Call
    {
        public Guid Id { get; }
        public int DurationInSec { get; }
        public Call(int durationInSec)
        {
            Id = Guid.NewGuid();
            DurationInSec = durationInSec;
        }
        public override string ToString()
        {
            return $"guid: {Id.ToString().Substring(0,4)} Duration: {DurationInSec}";
        }
    }
}
