using Septa.PayamGostarApiClient.CrmObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Organization
{
    public class OrganizationFindResult : CrmObjectFindResult
    {
        public List<OrganizationFindGetResult> data { get; set; }
    }
}
