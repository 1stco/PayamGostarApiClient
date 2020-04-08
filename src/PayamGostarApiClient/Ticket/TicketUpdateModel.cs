using Septa.PayamGostarApiClient.CrmObject.ExtendedProperty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Ticket
{
    public class TicketUpdateModel
    {
        public string Status { get; set; }

        public string Severity { get; set; }

        public string Impact { get; set; }

        public int Number { get; set; }

        public string EmailAddress { get; set; }
        //
        public string CrmId { get; set; }
        public string CrmObjectTypeCode { get; set; }
        public string ParentCrmObjectId { get; set; }
        public List<ExtendedPorpertyCreateModel> ExtendedProperties { get; set; }
        public string[] Tags { get; set; }
        public string RefId { get; set; }
        public string StageId { get; set; }
        public string IdentityId { get; set; }
        public string AssignedToUserName { get; set; }
        public string Description { get; set; }
    }
}
