using PayamGostarClient;
using Septa.PayamGostarApiClient.CrmObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Task
{
	public class PgTaskClient : ITaskClient
	{
		private readonly IHttpClient _httpClient;
		private readonly IPgClient _pgClient;

		public PgTaskClient(IHttpClient httpClient, IPgClient pgClient)
		{
			_httpClient = httpClient;
			_pgClient = pgClient;
		}

		public TaskGetResult CallGet(TaskGetModel model)
		{
			return _httpClient.PostJson<TaskGetModel, TaskGetResult>(_pgClient.ServiceUrl, $"api/v2/crmobject/task/get", _pgClient.Ticket, model);
		}

		public TaskCreateResult CallCreate(TaskCreateModel model)
		{
			return _httpClient.PostJson<TaskCreateModel, TaskCreateResult>(_pgClient.ServiceUrl, $"api/v2/crmobject/task/create", _pgClient.Ticket, model);
		}

		public TaskUpdateResult CallUpdate(TaskUpdateModel model)
		{
			return _httpClient.PostJson<TaskUpdateModel, TaskUpdateResult>(_pgClient.ServiceUrl, $"api/v2/crmobject/task/update", _pgClient.Ticket, model);
		}

		public bool CallDelete(TaskDeleteModel model)
		{
			try
			{
				_httpClient.PostJson<TaskDeleteModel, string>(_pgClient.ServiceUrl, $"api/v2/crmobject/task/delete", _pgClient.Ticket, model);
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public TaskFindResult CallFind(CrmObjectFindModel model)
		{
			return _httpClient.PostJson<CrmObjectFindModel, TaskFindResult>(_pgClient.ServiceUrl, $"api/v2/crmobject/task/find", _pgClient.Ticket, model);
		}
	}
}
