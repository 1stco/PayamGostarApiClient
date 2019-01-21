using PayamGostarClient;
using System;
using System.Collections.Generic;

namespace Septa.PayamGostarApiClient.SecurityItem
{
    public interface ISecurityItemClient
    {
        IEnumerable<OfficeModelResult> GetOffices();

        UserResult GetUser(string username);
    }

    public class PgSecurityItemClient : ISecurityItemClient
    {
        private readonly IHttpClient _httpClient;
        private readonly IPgClient _pgClient;

        public PgSecurityItemClient(IHttpClient httpClient, IPgClient pgClient)
        {
            _httpClient = httpClient;
            _pgClient = pgClient;
        }

        public IEnumerable<OfficeModelResult> GetOffices()
        {
            return _httpClient.GetJson<OfficeFilterModel, List<OfficeModelResult>>(_pgClient.ServiceUrl, "api/v1/security/office", _pgClient.Ticket, null);
        }

        public UserResult GetUser(string username)
        {
            return _httpClient.GetJson<UserFilterModel, UserResult>(_pgClient.ServiceUrl, $"api/v1/security/user/{username}", _pgClient.Ticket, null);

        }
    }

    public class OfficeFilterModel { }

    public class OfficeModelResult
    {
        public OfficeModelResult()
        {
        }

        public Guid? ParentId { get; set; }

        public Guid? Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string OfficeKey { get; set; }

        public DateTime CreateDate { get; set; }

        public bool IsActive { get; set; }

        public string UserKey { get; set; }
    }

    public class UserFilterModel { }

    public class UserResult
    {
        public Guid Id { get; set; }

        public string Username { get; set; }
    }
}
