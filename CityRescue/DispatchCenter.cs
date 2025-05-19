using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityRescue
{
    static class DispatchCenter
    {
        //private List<EmergencyTeams> _Teams;
        //private EmergencyReport _Report;


        //public DispatchCenter()
        //{
        //    _Teams = new List<EmergencyTeams>();
        //}

        public static void  AssignTeams(List<EmergencyTeams> teams, EmergencyReport report)
        {
            foreach (EmergencyTeams t in teams) {
                if (t.IsCanHelp() && t.emergency == report.emergency && t.zone==report.zone) {
                    t.IsFlag = false;
                    Console.WriteLine($"the team {t.name} is ready for work ");
                }
            }
           

        }


        //public void AddDispachList(EmergencyTeams team)
        //{
        //    _Teams.Add(team);
        //}
    }
    
}
