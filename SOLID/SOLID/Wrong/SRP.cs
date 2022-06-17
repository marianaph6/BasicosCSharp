using SOLID.Correct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Wrong
{
    internal class SRPWrong
    {
        public class GarageStation
        {
            public void DoOpenGate()
            {
                //Open the gate functinality
            }

            public void PerformService(Vehicle vehicle)
            {
                //Check if garage is opened
                //finish the vehicle service
            }

            public void DoCloseGate()
            {
                //Close the gate functinality
            }
        }
    }
}
