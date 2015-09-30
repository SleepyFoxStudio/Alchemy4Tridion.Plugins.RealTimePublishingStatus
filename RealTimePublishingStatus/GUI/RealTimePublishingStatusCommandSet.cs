using Alchemy4Tridion.Plugins.GUI.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimePublishingStatus.GUI
{
    public class RealTimePublishingStatusCommandSet : CommandSet
    {
        public RealTimePublishingStatusCommandSet()
        {
            AddCommand("OpenRealTimePublishingQueue");
            AddCommand("Queue");
        }
    }

}
