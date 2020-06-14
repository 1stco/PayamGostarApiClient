using Septa.PayamGostarApiClient.BillableObject;
using Septa.PayamGostarApiClient.CrmObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Invoice.PurchaseInvoice
{
    public interface IPurchaseInvoiceClient
    {
        InvoiceGetResult CallGet(InvoiceGetModel model);
        InvoiceCreateResult CallCreate(PurchaseInvoiceCreateModel model);
        InvoiceUpdateResult CallUpdate(PurchaseInvoiceUpdateModel model);
        bool CallDelete(InvoiceDeleteModel model);
        InvoiceFindResult CallFind(CrmObjectFindModel model);
        bool CallMakeNumbered(BillableObjectChangeStateModel model);
        bool CallMakeApproved(BillableObjectChangeStateModel model);
        bool CallMakePending(BillableObjectChangeStateModel model);
        bool CallMakeRejected(BillableObjectChangeStateModel model);
    }
}
