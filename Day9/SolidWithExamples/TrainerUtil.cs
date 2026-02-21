using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWithExamples
{
    internal class TrainerUtil
    {
        private ITrainerData iTrainerData;

        public TrainerUtil(ITrainerData iTrainerData)
        {
            this.iTrainerData = iTrainerData;
        }

        public void ShowTrainerInfo()
        {
            iTrainerData.Name();
            iTrainerData.Email();
            iTrainerData.City();
        }
    }
}
