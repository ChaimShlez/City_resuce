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

            EmergencyTeams blockages = new Blockages("block", EmergencyEnum.BLOCKAGE, true, ZoneEnum.EAST);
            EmergencyTeams floods = new Floods("floods", EmergencyEnum.FLOOD, true, ZoneEnum.NORTH);
            EmergencyTeams injuries = new Injuries("injuries", EmergencyEnum.INJURY, true, ZoneEnum.SOUTH);

            EmergencyReport reoprt = new EmergencyReport(EmergencyEnum.BLOCKAGE, ZoneEnum.EAST, 3,4, "Life was in danger");


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
