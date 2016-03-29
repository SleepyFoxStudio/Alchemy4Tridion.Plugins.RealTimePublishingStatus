using Alchemy4Tridion.Plugins;
using System;
using System.Linq;
using System.Text;
using System.Web.Http;
using Tridion.ContentManager.CoreService.Client;

namespace RealTimePublishingStatus.Controllers
{
    [AlchemyRoutePrefix("QueueService")]
    public class QueueServiceController : AlchemyApiController
    {


        [HttpGet]
        [Route("Queue")]
        public string GetQueue()
        {
            
            PublishTransactionData[] publishTransactions = InMemoryCache.GetOrSet("RealTimePublishingQueue/Transactions", GetPublishTransactions);

            StringBuilder result = new StringBuilder();
            result.Append(@"<table id = ""queueTable"" cellspacing = ""0"" cellpadding = ""0"">
      <thead>
        <tr>
          <th><span>Id</span></th>
          <th><span>Title</span></th>
          <th><span>State</span></th>
          <th><span>User</span></th>
          <th><span>Time</span></th>
        </tr>
      </thead>");

            foreach (PublishTransactionData publishItem in publishTransactions)
            {
                if (publishItem.State != PublishTransactionState.Success)
                {
                    result.AppendFormat(@"<tr>" +
                                    "   <td>{0}</td>" +
                                    "   <td>{1}</td>" +
                                    "   <td>{2}</td>" +
                                    "   <td>{3}</td>" +
                                    "   <td>{4}</td>" +
                                    "</tr>",
                                    publishItem.Id,
                                    publishItem.Title,
                                    publishItem.State,
                                    publishItem.Creator.Title,
                                    publishItem.StateChangeDateTime);
                }
            }
            result.Append("</table>");
            return result.ToString();
        }

        private  PublishTransactionData[] GetPublishTransactions()
        {
            PublishTransactionsFilterData filter = new PublishTransactionsFilterData()
            {
                EndDate = DateTime.Now,
                BaseColumns = ListBaseColumns.Extended,
                StartDate = DateTime.Now.AddHours(-1)
            };
            PublishTransactionData[] publishTransactions = Client.GetSystemWideList(filter).Cast<PublishTransactionData>().ToArray();
            return publishTransactions;
        }
    }
}

