using Septa.PayamGostarApiClient.CrmObject.ExtendedProperty;
using Septa.PayamGostarApiClient.Employee;
using Septa.PayamGostarApiClient.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Person
{
	public class PersonGetResult
	{
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? BirthDate { get; set; }

        public string Gender { get; set; }

        public string PersonPrefix { get; set; }

        public string Degree { get; set; }

        public string CreditType { get; set; }

        public string NationalCode { get; set; }

        public string Spouse { get; set; }

        public string PreferredContactType { get; set; }

        public string PaymentStatusType { get; set; }

        public string AreasOfInterest { get; set; }

        public string Hobbies { get; set; }

        public string Children { get; set; }

        public string MannerType { get; set; }

        public string FacebookUsername { get; set; }

        public List<EmployeeGetResult> Organizations { get; set; }
        //
        public string NickName { get; set; }
        public List<IdentityContactPhoneGetResult> PhoneContacts { get; set; }
        public List<IdentityContactAddressGetResult> AddressContacts { get; set; }
        public string Email { get; set; }
        public string AlternativeEmail { get; set; }
        public string Website { get; set; }
        public string SourceTypeName { get; set; }
        public string CustomerNumber { get; set; }
        public string ColorName { get; set; }
        public string Classification { get; set; }
        public DateTime? CustomerDate { get; set; }
        public decimal? Balance { get; set; }
        public string IdentityTypeName { get; set; }

        public List<IdentityCategoryGetResult> Categories { get; set; }

        public bool? DontSms { get; set; }
        public bool? DontSocialSms { get; set; }
        public bool? DontPhoneCall { get; set; }
        public bool? DontEmail { get; set; }
        public bool? DontFax { get; set; }
        public string SupportUsername { get; set; }
        public string SaleUsername { get; set; }
        public string OtherUsername { get; set; }
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

        public string Description { get; set; }

        public string Subject { get; set; }
    }
}
