using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityRescue
{
    internal class EmergencyReport
    {
        private EmergencyEvent _Emergency;
        private Zone _Zone;
        private int _Serious;
        private int _longProblem;
        private string _Summery;

        public EmergencyReport(EmergencyEvent events, Zone zone, int serious, 
            int longProblem, string summery)
        {
            _Emergency = events;
            _Zone = zone;
            _Serious = serious;
            _longProblem = longProblem;
            _Summery = summery;
        }


       
        public int serious
        {
            get { return _Serious; }
            set { _Serious = value; }
        }
        public int longProblem
        {
            get { return _longProblem; }
            set { _longProblem = value; }
        }
        public string summery
        {
            get { return _Summery; }
            set { _Summery = value; }
        }

        public EmergencyEvent emergency
        {
            get { return _Emergency; }
            set { _Emergency = value; }
        }

        public Zone zone
        {
            get { return _Zone; }
            set { _Zone = value; }
        }

    }
}
