using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Identity
{
	public class IdentityContactAddressGetResult
	{
		public string Id { get; set; }

		public bool Default { get; set; }

        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }

        public string AddressType { get; set; }

        public string AreaCode { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string ZipBox { get; set; }

        public decimal? Longitude { get; set; }
        public decimal? Latitude { get; set; }
    }
}
