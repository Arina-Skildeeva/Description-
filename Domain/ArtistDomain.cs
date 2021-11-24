using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

class Artist
{
    public int Artist_ID { get; set; }
    public string Artist_full_name { get; set; }
    public string Artist_song { get; set; }
    public int Favourites { get; set; }
    public int Admin_ID { get; set; }
}