using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Invoice
{
    public class InvoiceDetailGetResult
    {
        public string ProductCode { get; set; }

        public string ProductId { get; set; }

        public string ProductName { get; set; }

        public bool IsService { get; set; }

        public decimal BaseUnitPrice { get; set; }

        public decimal FinalUnitPrice { get; set; }

        public decimal Count { get; set; }

        public decimal ReturnedCount { get; set; }

        public decimal TotalUnitPrice { get; set; }

        public string Serial { get; set; }

        public decimal TotalDiscount { get; set; }

        public decimal TotalVat { get; set; }

        public decimal TotalToll { get; set; }

        public decimal? DiscountPercent { get; set; }

        public string DetailDescription { get; set; }

        public string InventoryName { get; set; }

        public string InventoryCode { get; set; }

        public string ProductUnitTypeName { get; set; }
    }
}
