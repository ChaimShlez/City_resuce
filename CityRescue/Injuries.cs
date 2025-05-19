using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityRescue
{
    internal class Injuries : EmergencyTeams
    {
        public Injuries(string name, EmergencyEnum region, bool isFlag, ZoneEnum zone) : base(name, region, isFlag, zone)
        {
        }

        public override bool IsCanHelp()
        {
            if (this.IsFlag == false)
            {
                return false;
            }
            return true;
        }


        public override void printReport(EmergencyReport report)
        {
            Console.WriteLine($"this symmery report :{report.summery} name team :{this.name}");
        }
    }
}
