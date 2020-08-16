using Septa.PayamGostarApiClient.CrmObject.ExtendedProperty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Task
{
	public class TaskCreateModel
	{
        public int? PercentCompleted { get; set; }
        public string TaskStatus { get; set; }
        public string ImmediateReferenceToUserName { get; set; }
        //
        public DateTime? StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        //
        public string CrmObjectTypeCode { get; set; }

        public string ParentCrmObjectId { get; set; }

        public List<ExtendedPorpertyCreateModel> ExtendedProperties { get; set; }

        public string[] Tags { get; set; }

        public string RefId { get; set; }

        public string StageId { get; set; }

        public string IdentityId { get; set; }

        public string AssignedToUserName { get; set; }

        public string Description { get; set; }

        public string Subject { get; set; }
    }
}
