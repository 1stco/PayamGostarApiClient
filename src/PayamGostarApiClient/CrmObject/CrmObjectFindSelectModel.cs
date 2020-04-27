using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.CrmObject
{
    public class CrmObjectFindSelectModel
    {
        public bool IncludeAll { get; set; }

        public string Name { get; set; }

        public List<string> Fields { get; set; }
    }
}
