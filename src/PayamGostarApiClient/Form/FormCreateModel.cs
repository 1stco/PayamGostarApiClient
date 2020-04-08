using Septa.PayamGostarApiClient.CrmObject.ExtendedProperty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Form
{
	public class FormCreateModel
	{
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
