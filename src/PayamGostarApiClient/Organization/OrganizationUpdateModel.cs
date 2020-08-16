using Septa.PayamGostarApiClient.CrmObject.ExtendedProperty;
using Septa.PayamGostarApiClient.Employee;
using Septa.PayamGostarApiClient.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Organization
{
	public class OrganizationUpdateModel
	{
        public string BusinessType { get; set; }
        public string RegisterNumber { get; set; }
        public DateTime? RegisterDate { get; set; }
        public string ShareType { get; set; }
        public string Trademark { get; set; }
        public string OwnershipType { get; set; }
        public string TradeType { get; set; }
        public Guid? ManagerId { get; set; }
        public string EconomicCode { get; set; }
        public List<EmployeeUpdateModel> Employees { get; set; }
        //
        public string NickName { get; set; }
        public List<IdentityContactPhoneUpdateModel> PhoneContacts { get; set; }
        public List<IdentityContactAddressUpdateModel> AddressContacts { get; set; }
        public string Email { get; set; }
        public string AlternativeEmail { get; set; }
        public string Website { get; set; }
        public string CustomerNumber { get; set; }
        public DateTime? CustomerDate { get; set; }
        public decimal? Balance { get; set; }
        public List<IdentityCategoryUpdateModel> Categories { get; set; }
        public bool? DontSms { get; set; }
        public bool? DontSocialSms { get; set; }
        public bool? DontPhoneCall { get; set; }
        public bool? DontEmail { get; set; }
        public bool? DontFax { get; set; }
        public string SupportUsername { get; set; }
        public string SaleUsername { get; set; }
        public string OtherUsername { get; set; }
        public string FacebookUsername { get; set; }
        public string PreferredContactType { get; set; }
        public string NationalCode { get; set; }
        //
        public string CrmId { get; set; }
        public string CrmObjectTypeCode { get; set; }
        public string ParentCrmObjectId { get; set; }
        public List<ExtendedPorpertyCreateModel> ExtendedProperties { get; set; }
        public string[] Tags { get; set; }
        public string RefId { get; set; }
        public string StageId { get; set; }
        public string Description { get; set; }
        public string Subject { get; set; }
    }
}
