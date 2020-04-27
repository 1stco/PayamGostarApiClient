using Septa.PayamGostarApiClient.CrmObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Form
{
    public class FormFindResult : CrmObjectFindResult
    {
        public List<FormFindGetResult> data { get; set; }
    }
}
