namespace PayamGostarClient
{
    public class PgAuthenticationResult
    {
        public PgAuthenticationResult(PgAuthenticationTicket ticket, PgAuthenticationStatus status)
        {
            Ticket = ticket;
            Status = status;
        }

        public PgAuthenticationTicket Ticket { get; set; }

        public PgAuthenticationStatus Status { get; set; }

        public bool Ok()
        {
            return Status == PgAuthenticationStatus.Ok;
        }
    }

    public enum PgAuthenticationStatus
    {
        Ok = 200,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403,
        ServerError = 500
    }
}
