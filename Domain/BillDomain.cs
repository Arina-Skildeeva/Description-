using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

class Bill
{
    public int Bank_detail { get; set; }
    public int Client { get; set; }
    public int Pay_number { get; set; }
    public decimal Pay_amount { get; set; }
    public bool Payment_confirmation { get; set; }
}