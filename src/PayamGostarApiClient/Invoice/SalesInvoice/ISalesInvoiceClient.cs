using Septa.PayamGostarApiClient.BillableObject;
using Septa.PayamGostarApiClient.CrmObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Invoice.SalesInvoice
{
    public interface ISalesInvoiceClient
    {
        InvoiceGetResult CallGet(InvoiceGetModel model);
        InvoiceCreateResult CallCreate(SalesInvoiceCreateModel model);
        InvoiceUpdateResult CallUpdate(SalesInvoiceUpdateModel model);
        bool CallDelete(InvoiceDeleteModel model);
        InvoiceFindResult CallFind(CrmObjectFindModel model);
        bool CallMakeNumbered(BillableObjectChangeStateModel model);
        bool CallMakeApproved(BillableObjectChangeStateModel model);
        bool CallMakePending(BillableObjectChangeStateModel model);
        bool CallMakeRejected(BillableObjectChangeStateModel model);
    }
}
