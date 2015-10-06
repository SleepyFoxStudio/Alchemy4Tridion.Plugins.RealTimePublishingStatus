using Alchemy4Tridion.Plugins.GUI.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimePublishingStatus.GUI.ResourceGroups
{
    public class RealTimePublishingStatusResourceGroup : ResourceGroup
    {
        public RealTimePublishingStatusResourceGroup()
        {
            //Add the Js files
            AddFile("OpenRealTimePublishingQueue.js");
            AddFile("QueueCommand.js");

            //Add the CSS
            AddFile("RealTimePublishingQueuePopup.css");
            AddFile("RealTimePublishingQueueStyles.css");

            //Add the images
            AddFile("icon-16x16.png");
            AddFile("icon-32x32.png");

            AddFile<RealTimePublishingStatusCommandSet>();
            AddWebApiProxy();
            AttachToView("PublishQueue.aspx");
        }
    }
}
