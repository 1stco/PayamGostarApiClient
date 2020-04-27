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

        public List<CrmObjectFindOrderModel> Orders { get; set; }

        public List<CrmObjectFindSelectModel> SelectFields { get; set; }

        public int? PageNumber { get; set; }

        public int? PageSize { get; set; }
    }
}
