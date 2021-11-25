using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

public class Author
{
    public int AuthorId { get; set; }
    public string Country { get; set; }
    public string Style { get; set; }
}   