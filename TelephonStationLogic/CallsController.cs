using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TelephonStationLogic.Agent;

namespace TelephonStationLogic
{
    public static class CallsController
    {
        public static List<Call> Calls { get;  set; } = new List<Call>();
        public static Queue<Call> WaitingCalls { get; set; } = new Queue<Call>();
        public static Call AddCall()
        {
            var rnd = new Random();
            var call = new Call(rnd.Next(2, 5));
            WaitingCalls.Enqueue(call);
            Task task = Task.Factory.StartNew(() =>
            {
    
                StartConnection(call);
            });
            return call;

        }

        private static void StartConnection(Call call)
        {
            Task firts = Task.Factory.StartNew(() =>
            {
                bool waiting  = true;
                while (waiting)
                {
                    foreach (var agent in AgentsController.Agents)
                    {
                        if (!agent.busy)
                        {
                            agent.CallAccepted(call);
                            waiting = false;
                            break;
                        }
                    }
                    Thread.Sleep(100);

                }
            });
        }
    }
}
