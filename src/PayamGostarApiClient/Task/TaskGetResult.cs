using Septa.PayamGostarApiClient.CrmObject.ExtendedProperty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Task
{
	public class TaskGetResult
	{
        public int? PercentCompleted { get; set; }
        public string TaskStatus { get; set; }
        //
        public DateTime? StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        //
        public string CrmId { get; set; }

        public string CrmObjectTypeName { get; set; }

        public string CrmObjectTypeCode { get; set; }

        public int CrmObjectTypeIndex { get; set; }

        public string CrmObjectTypeId { get; set; }

        public string ParentCrmObjectId { get; set; }

        public List<ExtendedPropertyGetResult> ExtendedProperties { get; set; }

        public DateTime CreatDate { get; set; }

        public DateTime ModifyDate { get; set; }

        public string[] Tags { get; set; }

        public string RefId { get; set; }

        public string Stage { get; set; }

        public string StageId { get; set; }

        public int? ProcessLifePathIndex { get; set; }

        public string IdentityId { get; set; }

        public string Description { get; set; }

        public string Subject { get; set; }
    }
}
