<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Real Time Publish Queue</title>
    <!-- TODO: Move this to onready or similar -->
    <script src="${JsUrl}/jquery-2.1.4.min.js"></script>
    <script>
        jQuery(document).ready(function () {
            myInitializeCode();
        });

        function myInitializeCode() {
            if (!window.Alchemy) {
                // resources have not loaded yet... let's wait...
                window.setTimeout(myInitializeCode, 500);
                return;
            }
            window.setInterval(getRealTimeItemsFromQueue, 5000);
        }

        function getRealTimeItemsFromQueue() {
            Alchemy.Plugins.Real_Time_Publish_Queue.Api.QueueService.getQueue(function (error, response) { if (error) jQuery("#message").text(error); else jQuery("#message").html(response); });
        }
    </script>
</head>
<body>
    <h1>Real Time Publish Queue</h1>
    <div id="message"></div>



</body>

</html>
