using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.CrmObject
{
    public enum FilterLogicalOperators
    {
        And = 0,
        Or = 1
    }

    public enum FilterOperators
    {
        Equals = 0,
        GreateThan = 1,
        GreaterThanOrEqual = 2,
        In = 3,
        LessThan = 4,
        LessThanOrEqual = 5,
        NotEqual = 6,
        NotIn = 7,
        //Expression = 8, // comparing two specific column values => "" expression {"columnA" equals "columnB"}
        //Modulo = 9, // value of a field divided by a divisor has the specified remainder => Field modulo {"divisor","remainder"}
        //Regex = 10,
        TextStartsWith = 11,
        TextContains = 12,
        TextEndsWith = 13,
        //All = 14, // value of a field is an array that contains all the specified elements
        //Length = 15, // matches any array with the number of elements specified by the argument
    }
}
