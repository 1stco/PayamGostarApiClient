using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Task
{
    public class TaskFindGetResult : TaskGetResult
    {
        public Dictionary<string, string> IncludedFields { get; set; }
    }
}
