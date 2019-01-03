namespace PayamGostarClient
{
    public class PgCredentials
    {
        public PgCredentials()
        {
        }

        public PgCredentials(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}
