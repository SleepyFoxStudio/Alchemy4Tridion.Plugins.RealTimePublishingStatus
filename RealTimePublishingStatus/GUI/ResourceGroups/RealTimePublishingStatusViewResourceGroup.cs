using Alchemy4Tridion.Plugins.GUI.Configuration;

namespace RealTimePublishingStatus.GUI.ResourceGroups
{
    public class RealTimePublishingStatusViewResourceGroup : ResourceGroup
    {
        public RealTimePublishingStatusViewResourceGroup()
        {
            //Add the CSS
            AddFile("RealTimePublishingQueuePopup.css");

            AddWebApiProxy();
            AttachToView("PublishQueue.aspx");
        }
    }
}
