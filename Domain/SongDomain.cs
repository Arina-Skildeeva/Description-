using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

class Song
{
    public int Song_ID { get; set; }
    public string Artist_name { get; set; }
    public string Song_name { get; set; }
    public int Favorites { get; set; }
}