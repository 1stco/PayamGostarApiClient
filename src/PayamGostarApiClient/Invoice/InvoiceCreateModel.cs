using Septa.PayamGostarApiClient.CrmObject.ExtendedProperty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Invoice
{
    public abstract class InvoiceCreateModel
    {
        public string PriceListName { get; set; }

        public decimal Discount { get; set; }

        public decimal Vat { get; set; }

        public decimal Toll { get; set; }

        public decimal? AdditionalCosts { get; set; }

        public decimal TotalValue { get; set; }

        public DateTime? InvoiceDate { get; set; }

        public DateTime? ExpireDate { get; set; }

        public int VatPercent { get; set; }

        public int TollPercent { get; set; }

        public List<InvoiceDetailModel> Details { get; set; }

        public decimal? DiscountPercent { get; set; }

        public decimal TotalDiscountPercent { get; set; }
        //
        public decimal FinalValue { get; set; }
        public string Number { get; set; }
        //
        public string CrmObjectTypeCode { get; set; }
        public string ParentCrmObjectId { get; set; }
        public List<ExtendedPorpertyCreateModel> ExtendedProperties { get; set; }
        public string[] Tags { get; set; }
        public string RefId { get; set; }
        public string StageId { get; set; }
        public string IdentityId { get; set; }
        public string AssignedToUserName { get; set; }
        public string Description { get; set; }
        public string Subject { get; set; }
    }
}
