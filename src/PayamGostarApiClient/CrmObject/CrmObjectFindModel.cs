using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.CrmObject
{
    public class CrmObjectFindModel
    {
        public string TypeKey { get; set; }

        public List<CrmObjectFindQueryModel> Queries { get; set; }
    }
}
