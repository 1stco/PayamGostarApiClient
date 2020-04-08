using Septa.PayamGostarApiClient.CrmObject.ExtendedProperty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Ticket
{
    public class TicketGetResult
    {
        public string Status { get; set; }

        public int Number { get; set; }

        public string EmailAddress { get; set; }

        public string ResponseStatus { get; set; }

        public string Severity { get; set; }

        public string Impact { get; set; }

        public List<TicketActiveProcessLifePathGetResult> ActiveProcessLifePaths { get; set; }
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
