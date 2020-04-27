using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Person
{
    public class PersonFindGetResult : PersonGetResult
    {
        public Dictionary<string, string> IncludedFields { get; set; }
    }
}
