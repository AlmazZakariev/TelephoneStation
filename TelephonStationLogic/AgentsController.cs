using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephonStationLogic
{
    public static class AgentsController
    {
        public static List<Agent> Agents { get; private set; } = new List<Agent>();

        //TODO: разобраться есть ли что-то типа конструктора в статическом классе
        //public static void Init()
        //{
        //    Agents = new List<Agent>();
        //}

        public static void CreateAgent(string AgentName)
        {
            if (!IsAgentExist(AgentName))
            {
                Agents.Add(new Agent(AgentName));
            }
        }
        public static bool DeleteAgent(string AgentName)
        {
            if (IsAgentExist(AgentName, out Agent agent))
            {
                Agents.Remove(agent);
            }

            return true;
        }
        private static bool IsAgentExist(string Name)
        {
            var searchAgent = new Agent(Name);
            if (Agents.Contains(searchAgent))
            {
                
                return true;
            }
            
            return false;

        }
        private static bool IsAgentExist(string Name, out Agent agent)
        {
            var searchAgent = new Agent(Name);
            if (Agents.Contains(searchAgent))
            {
                agent = searchAgent;
                return true;
            }
            agent = null;
            return false;

        }
    }
}
