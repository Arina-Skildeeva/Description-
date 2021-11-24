using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

class Subscription
{
    public int Subscription_number { get; set; }
    public int Client_ID { get; set; }
    public bool Subscription_rejection { get; set; }
    public bool Subscription_agreement { get; set; }
}