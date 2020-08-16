using Septa.PayamGostarApiClient.CrmObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Task
{
    public class TaskFindResult : CrmObjectFindResult
    {
        public List<TaskFindGetResult> data { get; set; }
    }
}
