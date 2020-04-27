using Septa.PayamGostarApiClient.CrmObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Form
{
	public interface IFormClient
	{
		FormGetResult CallGet(FormGetModel model);
		FormCreateResult CallCreate(FormCreateModel model);
		FormUpdateResult CallUpdate(FormUpdateModel model);
		bool CallDelete(FormDeleteModel model);
		FormFindResult CallFind(CrmObjectFindModel model);
	}
}
