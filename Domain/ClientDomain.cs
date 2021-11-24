using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

class Client
{
    public int Client_ID { get; set; }
    public string Client_full_name { get; set; }
    public string Email { get; set; }
    public string Login { get; set; }
}