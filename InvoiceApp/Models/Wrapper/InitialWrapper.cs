using InvoiceApp.Models.DropdownModel;
using InvoiceApp.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceApp.Models.Wrapper
{
    public class InitialWrapper
    {
        public InitialResponse Response { set; get; }
        public int Status { set; get; }
    }
}
