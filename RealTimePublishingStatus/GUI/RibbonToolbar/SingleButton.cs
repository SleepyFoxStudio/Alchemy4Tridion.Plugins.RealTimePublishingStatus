using Alchemy4Tridion.Plugins.GUI.Configuration;
using RealTimePublishingStatus.GUI.ResourceGroups;

namespace RealTimePublishingStatus.GUI.RibbonToolbar
{
    public class SingleButton : RibbonToolbarExtension
    {
        public SingleButton()
        {
            // Id of element, can be used for css
            AssignId = "RealTimePublishingStatusButton";
            // Becomes label of button
            Name = "Realtime Queue";
            // which tab to put it on
            PageId = Constants.PageIds.HomePage;
            // Which group to put it on... in this case we're adding it to the publish group
            GroupId = Constants.GroupIds.HomePage.PublishGroup;

            // the command to execute when clicked..
            Command = "OpenRealTimePublishingQueue";
            // the title attribute of the element (shows when hovering mouse over button)
            Title = "Launch the real time publishing queue.";

            Dependencies.Add<RealTimePublishingStatusResourceGroup>();
            Apply.ToView(Constants.Views.DashboardView, "DashboardToolbar");
        }
    }
}
