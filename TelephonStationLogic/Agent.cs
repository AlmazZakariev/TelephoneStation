using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephonStationLogic
{
    public class Agent
    {
        public string Name { get; }
        public Agent(string name) 
        { 
            Name = name;
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

    }
}
