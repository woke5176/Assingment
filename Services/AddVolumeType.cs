using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment2.Services
{
    internal class AddVolumeType
    {
        private static AddVol addVolume;


    public AddVolumeType()
        {
            this.addVolume = addVolume;
        }

  
    public void run()
        {
            lock(this.addVolume.getCoin()){
                while (this.addVolume.getCoin().getStatus() == CoinStatus.NOT_AVAILABLE)
                {
                   
                        this.addVolume.getCoin().wait();
                 }
                   
                }
               
            }

        }
    }
}
