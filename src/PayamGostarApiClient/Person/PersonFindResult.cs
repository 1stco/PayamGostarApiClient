using Septa.PayamGostarApiClient.CrmObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Person
{
    public class PersonFindResult : CrmObjectFindResult
    {
        public List<PersonFindGetResult> data { get; set; }
    }
}
