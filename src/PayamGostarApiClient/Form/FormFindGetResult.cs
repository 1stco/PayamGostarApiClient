using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Form
{
    public class FormFindGetResult : FormGetResult
    {
        public Dictionary<string, string> IncludedFields { get; set; }
    }
}
