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
    [Route("/bill")]
    public class BillController1 : ControllerBase
    {
        [HttpPut]
        public Bill Create(Bill bill)
        {
            Storage.BillStorage.Create(bill);
            return Storage.BillStorage.Read(bill.Bankdetail);
        }

        [HttpGet]
        public Bill Read(int billBankdetail)
        {
            return Storage.BillStorage.Read(billBankdetail);
        }

        [HttpPatch]
        public Bill Update(int billBankdetail, Bill newBill)
        {
            return Storage.BillStorage.Update(billBankdetail, newBill);
        }

        [HttpDelete]
        public bool Delete(int billBankdetail)
        {
            return Storage.BillStorage.Delete(billBankdetail);
        }

    }

}