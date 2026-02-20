using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExamples
{
    internal class Nullable2
    {
        static void Main()
        {
            Agent agent1 = new Agent();
            agent1.AgentId = 1;
            agent1.AgentName = "Vijay";

            agent1.Status = agent1.BusinessAmount ?? 0;

            Console.WriteLine(agent1);


            Agent agent2 = new Agent();
            agent2.AgentId = 2;
            agent2.AgentName = "Kabir";
            agent2.BusinessAmount = 83233;

            agent2.Status = agent2.BusinessAmount ?? 0;

            Console.WriteLine(agent2);

        }
    }
}
