namespace PayamGostarClient
{
    public interface IPgClientFactory
    {
        IPgClient Create(string serviceUrl, PgCredentials credentials);

        IPgClient Create(string serviceUrl, PgAuthenticationTicket ticket);

        PgAuthenticationResult SignIn(string serviceUrl, PgCredentials credentials);

        bool Test(string serviceUrl, PgAuthenticationTicket ticket);
    }
}