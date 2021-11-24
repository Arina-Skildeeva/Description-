using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

class Application
{
    public int Application_ID { get; set; }
    public string Author_full_name { get; set; }
    public string Song_name { get; set; }
    public int Author { get; set; }
    public int Admin { get; set; }
}