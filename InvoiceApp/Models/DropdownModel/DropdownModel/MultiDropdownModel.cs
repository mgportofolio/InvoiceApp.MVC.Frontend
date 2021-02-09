using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceApp.Models.DropdownModel.DropdownModel
{
    public class MultiDropdownModel
    {
        public MultiDropdownModel()
        {
            this.Currency = new List<DropdownModel>();
            this.Language = new List<DropdownModel>();
            this.Metrics = new List<DropdownModel>();
        }

        public List<DropdownModel> Currency { set; get; }
        public List<DropdownModel> Language { set; get; }
        public List<DropdownModel> Metrics { set; get; }
    }
}
