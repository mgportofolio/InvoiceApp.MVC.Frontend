using InvoiceApp.Models.DropdownModel.DropdownModel;
using InvoiceApp.Models.Response.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceApp.Models.Response
{
    public class InitialResponse : BaseResponse
    {
        public InitialResponse()
        {
            this.Dropdowns = new MultiDropdownModel();
            this.InitialInvoiceNo = "";
        }
        public MultiDropdownModel Dropdowns { set; get; }
        public string InitialInvoiceNo { set; get; }
    }
}
