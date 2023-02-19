using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephonStationLogic
{
    public static class CallsController
    {
        public static List<Call> Calls { get;  set; } = new List<Call>();
        public static Queue<Call> WaitingCalls { get; set; } = new Queue<Call>();
        public static Call AddCall()
        {
            var rnd = new Random();
            var call = new Call(rnd.Next(5, 35));
            WaitingCalls.Enqueue(call);
            return call;
        }
    }
}
