using PayamGostarClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Form
{
	public class PgFormClient : IFormClient
	{
		private readonly IHttpClient _httpClient;
		private readonly IPgClient _pgClient;

		public PgFormClient(IHttpClient httpClient, IPgClient pgClient)
		{
			_httpClient = httpClient;
			_pgClient = pgClient;
		}

		public FormGetResult CallGet(FormGetModel model)
		{
			return _httpClient.PostJson<FormGetModel, FormGetResult>(_pgClient.ServiceUrl, $"api/v2/crmobject/form/get", _pgClient.Ticket, model);
		}

		public FormCreateResult CallCreate(FormCreateModel model)
		{
			return _httpClient.PostJson<FormCreateModel, FormCreateResult>(_pgClient.ServiceUrl, $"api/v2/crmobject/form/create", _pgClient.Ticket, model);
		}

		public FormUpdateResult CallUpdate(FormUpdateModel model)
		{
			return _httpClient.PostJson<FormUpdateModel, FormUpdateResult>(_pgClient.ServiceUrl, $"api/v2/crmobject/form/update", _pgClient.Ticket, model);
		}

		public void CallDelete(FormDeleteModel model)
		{
			_httpClient.PostJson<FormDeleteModel, string>(_pgClient.ServiceUrl, $"api/v2/crmobject/form/delete", _pgClient.Ticket, model);
		}
	}
}
