using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephonStationLogic
{
    public class Agent
    {
        public delegate void SendInfo(string message, string type);
        public static event SendInfo? Info;
        public string Name { get; }
        public bool busy { get; set; }
        public Call CurrentCall { get; set; }
        public Agent(string name) 
        { 
            Name = name;
            busy = false;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if(obj == this) return true;
            Agent other = obj as Agent;
            if (other == null) return false;
            return other.Name == Name;
        }
        public override string ToString()
        {
            return this.Name;
        }
        public void CallAccepted(Call call)
        {
            
            busy= true;
            CurrentCall= call;
            Info?.Invoke($"TK_Диспетчер {this.ToString()} принял звонок {call.ToString()}", "AC");

            Task task = Task.Run(() =>
            {
                Thread.Sleep(1000 * call.DurationInSec);
                Info?.Invoke($"TK_Диспетчер {this.ToString()} завершил звонок {call.ToString()}", "EC");
                busy= false;
                CurrentCall = default(Call);
            });
                //return new string[] { $"TK_Диспетчер {this.ToString()} принял звонок {call.ToString()}", "AC" };
            }
    }
}
