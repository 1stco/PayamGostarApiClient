using Septa.PayamGostarApiClient.CrmObject.ExtendedProperty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Form
{
	public class FormUpdateModel
	{
        public Guid CrmId { get; set; }

        public string CrmObjectTypeCode { get; set; }

        public Guid? ParentCrmObjectId { get; set; }

        public List<ExtendedPorpertyCreateModel> ExtendedProperties { get; set; }

        public string[] Tags { get; set; }

        public string RefId { get; set; }

        public Guid? StageId { get; set; }

        public Guid? IdentityId { get; set; }

        public string Description { get; set; }

        public string Subject { get; set; }
    }
}
