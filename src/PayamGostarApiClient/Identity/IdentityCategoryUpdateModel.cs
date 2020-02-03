using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Identity
{
	public class IdentityCategoryUpdateModel
	{
		public Guid Id { get; set; }
		public Guid IdentityId { get; set; }
		public string Key { get; set; }
	}
}
