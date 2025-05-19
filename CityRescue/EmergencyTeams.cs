using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityRescue
{
    abstract class EmergencyTeams
    {
		private string _Name;

        private EmergencyEvent _Emergency;
        private Zone _Zone;

        private bool _IsFlag;

        public EmergencyTeams(string name, EmergencyEvent events, bool isFlag, Zone zone)
        {
            _Name = name;
            _Emergency = events;
            _IsFlag = isFlag;
            IsFlag = isFlag;
            _Zone = zone;
        }

        public bool IsFlag
		{
			get { return _IsFlag; }
			set { _IsFlag = value; }
		}

		public string name
		{
			get { return _Name ; }
			set { _Name = value; }
		}

        public EmergencyEvent emergency
        {
            get { return _Emergency; }
            set { _Emergency = value; }
        }

        public Zone zone
        {
            get { return _Zone; }
            set { _Zone= value; }
        }


        public virtual bool IsCanHelp()
        {
            return false;
        }

        public virtual void printReport(EmergencyReport report)
        {
            Console.WriteLine("cannot respont");
        }


    }
}
