# Securing .Net 5 Microservices With IdentityServer4

We will learn how to secure microservices using standalone Identity Server 4 and backing with Ocelot API Gateway. We’re going to protect our ASP.NET Web MVC and API applications using OAuth 2 and OpenID Connect in IdentityServer4. Securing our web application and API with tokens, working with claims, authentication and authorization middlewares and applying policies. We will secure our ASP.NET based microservices applications with IdentityServer4 using OAuth 2 and OpenID Connect on a distributed microservices architecture. We will secure protected APIs backing with Ocelot API Gateway in a microservices architecture.


## Movies.API

### Create project

<img src="/pictures/movies_api.png" title="create movies.API project"  width="600">

### Add Nuget Packages
```
Install-Package Microsoft.EntityFrameworkCore.InMemory
```


## IdentityServer

### Create project

<img src="/pictures/identity_server.png" title="identity server"  width="600">

### Add Nuget Packages
```
Install-Package IdentityServer4
Install-Package Microsoft.AspNetCore.Authentication.JwtBearer
```

<img src="/pictures/identity_server_call.png" title="identity server call"  width="600">
<img src="/pictures/get_access_token_call.png" title="get access token call"  width="600">
<img src="/pictures/get_access_token_call2.png" title="get access token call logs"  width="600">
<img src="/pictures/bad_client_id.png" title="get access token call with bad client id"  width="600">
<img src="/pictures/jwt.png" title="jwt"  width="600">
<img src="/pictures/get_movies_unauthorized.png" title="jwt"  width="401 unauthorized">

