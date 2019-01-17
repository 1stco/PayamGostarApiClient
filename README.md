### PayamGostar Api Client

[![Build status](https://ci.appveyor.com/api/projects/status/k4igwwggo2lkm7gy?svg=true)](https://ci.appveyor.com/project/1st-dev/payamgostarapiclient)

### How to authenticate:

```cs
private static IPgClient CreateClient()
{
    var factory = new PgClientFactory();
    var signInResult = factory.SignIn(BaseUrl, new PgCredentials("username", "password"));
    if (signInResult.Ok())
    {
        return factory.Create(BaseUrl, signInResult.Ticket);
    }
    else
    {
        throw new InvalidOperationException($"Can not sign in to {BaseUrl}. Status: {signInResult.Status}");
    }
}

```
