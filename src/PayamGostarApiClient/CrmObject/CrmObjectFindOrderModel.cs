using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.CrmObject
{
    public class CrmObjectFindOrderModel
    {
        public string Field { get; set; }

        public FilterOrderDirections? Order { get; set; }
    }

    public enum FilterOrderDirections
    {
        Asc = 0,
        Desc = 1
    }
}
