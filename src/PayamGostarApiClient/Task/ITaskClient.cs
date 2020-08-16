using Septa.PayamGostarApiClient.CrmObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Task
{
	public interface ITaskClient
	{
		TaskGetResult CallGet(TaskGetModel model);
		TaskCreateResult CallCreate(TaskCreateModel model);
		TaskUpdateResult CallUpdate(TaskUpdateModel model);
		bool CallDelete(TaskDeleteModel model);
		TaskFindResult CallFind(CrmObjectFindModel model);
	}
}
