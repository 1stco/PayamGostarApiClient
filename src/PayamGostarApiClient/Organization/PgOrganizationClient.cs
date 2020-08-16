using PayamGostarClient;
using Septa.PayamGostarApiClient.CrmObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Organization
{
	public class PgOrganizationClient : IOrganizationClient
	{
		private readonly IHttpClient _httpClient;
		private readonly IPgClient _pgClient;

		public PgOrganizationClient(IHttpClient httpClient, IPgClient pgClient)
		{
			_httpClient = httpClient;
			_pgClient = pgClient;
		}
		public OrganizationCreateResult CallCreate(OrganizationCreateModel model)
		{
			return _httpClient.PostJson<OrganizationCreateModel, OrganizationCreateResult>(_pgClient.ServiceUrl, $"api/v2/crmobject/organization/create", _pgClient.Ticket, model);

		}

		public bool CallDelete(OrganizationDeleteModel model)
		{
			try
			{
				_httpClient.PostJson<OrganizationDeleteModel, string>(_pgClient.ServiceUrl, $"api/v2/crmobject/organization/delete", _pgClient.Ticket, model);
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public OrganizationFindResult CallFind(CrmObjectFindModel model)
		{
			return _httpClient.PostJson<CrmObjectFindModel, OrganizationFindResult>(_pgClient.ServiceUrl, $"api/v2/crmobject/organization/find", _pgClient.Ticket, model);
		}

		public OrganizationGetResult CallGet(OrganizationGetModel model)
		{
			return _httpClient.PostJson<OrganizationGetModel, OrganizationGetResult>(_pgClient.ServiceUrl, $"api/v2/crmobject/organization/get", _pgClient.Ticket, model);
		}

		public OrganizationUpdateResult CallUpdate(OrganizationUpdateModel model)
		{
			return _httpClient.PostJson<OrganizationUpdateModel, OrganizationUpdateResult>(_pgClient.ServiceUrl, $"api/v2/crmobject/organization/update", _pgClient.Ticket, model);
		}
	}
}
