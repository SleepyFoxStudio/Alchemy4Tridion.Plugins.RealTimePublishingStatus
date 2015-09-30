Alchemy.command("Real_Time_Publish_Queue", "OpenRealTimePublishingQueue", {
    execute: function () {
        var url = "${ViewsUrl}PublishQueue.aspx";

        var onPopupClose = function() {
            $evt.removeEventHandler(this.properties.popupInstance, "unload", this.getDelegate(this.properties.popupCloseHandler));
            this.properties.popupInstance = null;
            this.properties.popupCloseHandler = null;
        }

        var popup = this.properties.popupInstance;
        if(popup)
        {
            popup.focus();
        }
        else
        {
            popup = $popup.create(url, "menubar=no,location=no,resizable=no,scrollbars=yes,status=no,width=800,height=350", null);

            this.properties.popupInstance = popup;
            this.properties.popupCloseHandler = onPopupClose;

            $evt.addEventHandler(popup, "unload", this.getDelegate(onPopupClose));

            popup.open();
        }
    }
});