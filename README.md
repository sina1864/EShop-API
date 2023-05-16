# EShop-API
The Source Code of the ASP.NET Core E-Commerce API Course

## Features
* Clean Architecture
* DDD Tactical Patterns
* CQRS using MediatR
* Multiple Database (SQL Server + Redis)
* Multiple ORM (EFCore + Dapper)
* FluentValidation
* Web API
* XSS Protected
* Caching
* Docker Enabled

## Packages
* AspNetCoreRateLimit `v4.0.2`
* AutoMapper.Extensions.Microsoft.DependencyInjection `v11.0.0`
* Microsoft.AspNetCore.Authentication.JwtBearer `v6.0.3`
* Microsoft.EntityFrameworkCore.Design `v6.0.3`
* Microsoft.Extensions.Caching.Redis `v2.2.0`
* Microsoft.VisualStudio.Azure.Containers.Tools.Targets `v1.14.0`
* Swashbuckle.AspNetCore `v6.3.0`
* UAParser `v3.1.47`
* FluentValidation `v10.4.0`
* FluentValidation.DependencyInjectionExtensions `v10.4.0`
* MediatR.Extensions.Microsoft.DependencyInjection `v10.0.1`
* Microsoft.Extensions.DependencyInjection.Abstractions `v6.0.0`
* Dapper `v2.0.123`
* Microsoft.EntityFrameworkCore.SqlServer `v6.0.3`
* Microsoft.EntityFrameworkCore.Tools `v6.0.3`
* HtmlSanitizer `v7.1.488`
* MediatR `v10.0.1`
* Microsoft.AspNetCore.Http.Features `v5.0.15`
* Microsoft.AspNetCore.Mvc.Abstractions `v2.2.0`
* Microsoft.AspNetCore.Mvc.Core `v2.2.5`
* Microsoft.AspNetCore.Hosting.Abstractions `v2.2.0`
* System.Drawing.Common `v6.0.0`
* Microsoft.Extensions.Caching.Abstractions `v6.0.0`

## Getting Started
To run the application:

1. Clone the Project
2. Open Visual Studio and load the Solution
3. Resolve any missing/required nuget package
4. Set `Shop.API` as startup project
5. Build Database. Open `Package Manager Console`, set `Shop.Infrastructure` as defualt project and run the following commands: `update-database`
6. That's all... Run the Project!