using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Identity
{
	public class IdentityContactPhoneCreateModel
	{
		public string PhoneType { get; set; }

		public string PhoneNumber { get; set; }

		public string ContinuedNumber { get; set; }

		public string Extension { get; set; }

		public bool Default { get; set; }
	}
}
