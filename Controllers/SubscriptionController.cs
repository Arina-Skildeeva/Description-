using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Description.Domain;
using Description.Repository;
using Microsoft.Extensions.Logging;

namespace MusicLibrary.Controllers
{
    [ApiController]
    [Route("/subscription")]
    public class SubscriptionController : ControllerBase
    {
        [HttpPut]
        public Subscription Create(Subscription subscription)
        {
            Storage.SubscriptionStorage.Create(subscription);
            return Storage.SubscriptionStorage.Read(subscription.Id);
        }

        [HttpGet]
        public Subscription Read(int subscriptionId)
        {
            return Storage.SubscriptionStorage.Read(subscriptionId);о
        }

        [HttpPatch]
        public Subscription Update(int subscriptionId, Subscription newSubscription)
        {
            return Storage.SubscriptionStorage.Update(subscriptionId, newSubscription);
        }

        [HttpDelete]
        public bool Delete(int subscriptionId)
        {
            return Storage.SubscriptionStorage.Delete(subscriptionId);
        }

    } 

}