using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.CrmObject
{
    public class CrmObjectFindQueryModel
    {
        public FilterLogicalOperators LogicalOperator { get; set; }

        public string Field { get; set; }

        public FilterOperators Operator { get; set; }

        public string Value { get; set; }

        public FilterLogicalOperators? LeafLogicalOperator { get; set; }

        public bool LeafNegate { get; set; }

        public List<CrmObjectFindQueryModel> Leafs { get; set; }
    }
}
