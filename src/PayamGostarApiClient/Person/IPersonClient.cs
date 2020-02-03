using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Person
{
	public interface IPersonClient
	{
		PersonGetResult CallGet(PersonGetModel model);
		PersonCreateResult CallCreate(PersonCreateModel model);
		PersonUpdateResult CallUpdate(PersonUpdateModel model);
		void CallDelete(PersonDeleteModel model);
	}
}
