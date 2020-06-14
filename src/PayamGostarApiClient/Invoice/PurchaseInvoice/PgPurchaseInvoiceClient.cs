using PayamGostarClient;
using Septa.PayamGostarApiClient.BillableObject;
using Septa.PayamGostarApiClient.CrmObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Invoice.PurchaseInvoice
{
    public class PgPurchaseInvoiceClient : IPurchaseInvoiceClient
    {
        private readonly IHttpClient _httpClient;
        private readonly IPgClient _pgClient;

        public PgPurchaseInvoiceClient(IHttpClient httpClient, IPgClient pgClient)
        {
            _httpClient = httpClient;
            _pgClient = pgClient;
        }

        public InvoiceCreateResult CallCreate(PurchaseInvoiceCreateModel model)
        {
            return _httpClient.PostJson<PurchaseInvoiceCreateModel, InvoiceCreateResult>(_pgClient.ServiceUrl, $"api/v2/crmobject/invoice/purchase/create", _pgClient.Ticket, model);
        }

        public bool CallDelete(InvoiceDeleteModel model)
        {
            try
            {
                _httpClient.PostJson<InvoiceDeleteModel, string>(_pgClient.ServiceUrl, $"api/v2/crmobject/invoice/purchase/delete", _pgClient.Ticket, model);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public InvoiceFindResult CallFind(CrmObjectFindModel model)
        {
            return _httpClient.PostJson<CrmObjectFindModel, InvoiceFindResult>(_pgClient.ServiceUrl, $"api/v2/crmobject/invoice/purchase/find", _pgClient.Ticket, model);
        }

        public InvoiceGetResult CallGet(InvoiceGetModel model)
        {
            return _httpClient.PostJson<InvoiceGetModel, InvoiceGetResult>(_pgClient.ServiceUrl, $"api/v2/crmobject/invoice/purchase/get", _pgClient.Ticket, model);
        }

        public InvoiceUpdateResult CallUpdate(PurchaseInvoiceUpdateModel model)
        {
            return _httpClient.PostJson<PurchaseInvoiceUpdateModel, InvoiceUpdateResult>(_pgClient.ServiceUrl, $"api/v2/crmobject/invoice/purchase/update", _pgClient.Ticket, model);
        }

        public bool CallMakeApproved(BillableObjectChangeStateModel model)
        {
            try
            {
                _httpClient.PostJson<BillableObjectChangeStateModel, string>(_pgClient.ServiceUrl, $"api/v2/crmobject/invoice/purchase/make-approved", _pgClient.Ticket, model);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CallMakeNumbered(BillableObjectChangeStateModel model)
        {
            try
            {
                _httpClient.PostJson<BillableObjectChangeStateModel, string>(_pgClient.ServiceUrl, $"api/v2/crmobject/invoice/purchase/make-numbered", _pgClient.Ticket, model);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CallMakePending(BillableObjectChangeStateModel model)
        {
            try
            {
                _httpClient.PostJson<BillableObjectChangeStateModel, string>(_pgClient.ServiceUrl, $"api/v2/crmobject/invoice/purchase/make-pending", _pgClient.Ticket, model);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CallMakeRejected(BillableObjectChangeStateModel model)
        {
            try
            {
                _httpClient.PostJson<BillableObjectChangeStateModel, string>(_pgClient.ServiceUrl, $"api/v2/crmobject/invoice/purchase/make-rejected", _pgClient.Ticket, model);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
