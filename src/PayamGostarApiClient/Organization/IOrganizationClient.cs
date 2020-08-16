using Septa.PayamGostarApiClient.CrmObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Organization
{
	public interface IOrganizationClient
	{
		OrganizationGetResult CallGet(OrganizationGetModel model);
		OrganizationCreateResult CallCreate(OrganizationCreateModel model);
		OrganizationUpdateResult CallUpdate(OrganizationUpdateModel model);
		bool CallDelete(OrganizationDeleteModel model);
		OrganizationFindResult CallFind(CrmObjectFindModel model);
	}
}
