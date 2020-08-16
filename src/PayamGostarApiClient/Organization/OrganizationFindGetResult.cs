using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Organization
{
    public class OrganizationFindGetResult : OrganizationGetResult
    {
        public Dictionary<string, string> IncludedFields { get; set; }
    }
}
