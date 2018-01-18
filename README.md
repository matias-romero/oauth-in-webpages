# oauth-in-webpages
Minimal example adding OAuth Authentication to existing ASP.NET WebPages project without Identity or other frameworks

Two steps are required in every ASP.NET web project (WebPages, MVC, Web API or SignalR)
1. Add Microsoft Owin Security or some concrete extension like "Cookies"

    `Install-Package Microsoft.Owin.Security.Cookies`

2. Add Microsoft Owin Hosting for your case (In our example is IIS)

    `Install-Package Microsoft.Owin.Host.SystemWeb`

3. Add `OWIN Startup Class`  (Startup.cs or Startup.vb) this decouple the web app from the IIS pipeline
4. Fill Startup class with your security model 
```cs
public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = CookieAuthenticationDefaults.AuthenticationType,
                LoginPath = new PathString("/Login")
            });
        }
    }
```

Now check the rest of the code in Login/Logout pages for more details.
