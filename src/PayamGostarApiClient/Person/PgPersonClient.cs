using PayamGostarClient;
using Septa.PayamGostarApiClient.CrmObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Person
{
	public class PgPersonClient : IPersonClient
	{
		private readonly IHttpClient _httpClient;
		private readonly IPgClient _pgClient;

		public PgPersonClient(IHttpClient httpClient, IPgClient pgClient)
		{
			_httpClient = httpClient;
			_pgClient = pgClient;
		}
		public PersonCreateResult CallCreate(PersonCreateModel model)
		{
			return _httpClient.PostJson<PersonCreateModel, PersonCreateResult>(_pgClient.ServiceUrl, $"api/v2/crmobject/person/create", _pgClient.Ticket, model);

		}

		public bool CallDelete(PersonDeleteModel model)
		{
			try
			{
				_httpClient.PostJson<PersonDeleteModel, string>(_pgClient.ServiceUrl, $"api/v2/crmobject/person/delete", _pgClient.Ticket, model);
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public PersonFindResult CallFind(CrmObjectFindModel model)
		{
			return _httpClient.PostJson<CrmObjectFindModel, PersonFindResult>(_pgClient.ServiceUrl, $"api/v2/crmobject/person/find", _pgClient.Ticket, model);
		}

		public PersonGetResult CallGet(PersonGetModel model)
		{
			return _httpClient.PostJson<PersonGetModel, PersonGetResult>(_pgClient.ServiceUrl, $"api/v2/crmobject/person/get", _pgClient.Ticket, model);
		}

		public PersonUpdateResult CallUpdate(PersonUpdateModel model)
		{
			return _httpClient.PostJson<PersonUpdateModel, PersonUpdateResult>(_pgClient.ServiceUrl, $"api/v2/crmobject/person/update", _pgClient.Ticket, model);
		}
	}
}
