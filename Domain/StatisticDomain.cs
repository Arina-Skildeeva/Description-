using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

class Statistic
{
    public int Statistic_ID { get; set; }
    public int Amount_of_listening { get; set; }
    public int Chat_rating { get; set; }
    public int Artist { get; set; }
    public int Song { get; set; }
    public int Author { get; set; }
}