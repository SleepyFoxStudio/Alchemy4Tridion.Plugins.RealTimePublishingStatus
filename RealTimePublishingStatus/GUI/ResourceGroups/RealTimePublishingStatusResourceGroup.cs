using Alchemy4Tridion.Plugins.GUI.Configuration;

namespace RealTimePublishingStatus.GUI.ResourceGroups
{
    public class RealTimePublishingStatusResourceGroup : ResourceGroup
    {
        public RealTimePublishingStatusResourceGroup()
        {
            //Add the Js files
            AddFile("OpenRealTimePublishingQueue.js");

            AddFile("RealTimePublishingQueueStyles.css");

            AddFile<RealTimePublishingStatusCommandSet>();
        }
    }
}
