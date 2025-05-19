using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityRescue
{
    internal class Program
    {
        static void Main(string[] args)
        {

            EmergencyTeams blockages = new Blockages("block", EmergencyEvent.BLOCKAGE, true, Zone.EAST);
            EmergencyTeams floods = new Floods("floods", EmergencyEvent.FLOOD, true, Zone.NORTH);
            EmergencyTeams injuries = new Injuries("injuries", EmergencyEvent.INJURY, true, Zone.SOUTH);

            EmergencyReport reoprt = new EmergencyReport(EmergencyEvent.BLOCKAGE, Zone.EAST, 3,4, "Life was in danger");


            List<EmergencyTeams> teams = new List<EmergencyTeams>();

            teams.Add(blockages);
            teams.Add(floods);
            teams.Add(injuries);
            //DispatchCenter dispach = new DispatchCenter();
            //dispach.AddDispachList(blockages);
            //dispach.AddDispachList(floods);
            //dispach.AddDispachList(injuries);

            DispatchCenter.AssignTeams(teams, reoprt);


        }
    }
}
