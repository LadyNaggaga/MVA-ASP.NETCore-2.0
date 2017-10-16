## Module 1.2.0 Console to Web Application 

- Create a new web app 
```sh
   dotnet  new web -o myapp 
   dotnet run  
```
- Open in VS Code 
    - Show and discuss simplified csproj
```sh
   <Project Sdk="Microsoft.NET.Sdk.Web">

  <PropertyGroup>
    <TargetFramework>netcoreapp2.0</TargetFramework>
  </PropertyGroup>

  <ItemGroup>
    <Folder Include="wwwroot\" />
  </ItemGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.AspNetCore.All" Version="2.0.0" />
  </ItemGroup>

</Project>
```
- Show and discuss Program.cs

    *Emphasis the simplcity:In 1.1 this method included code for setting up kestrel, specifying the content root, and adding IIS integration. This is all now handled by the new default web host builder*

```sh
namespace webapp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
```
## Module 1.2.1 Add a basic page 

In this mini module we are going create a basic page that returns date and time.
- Enable MVC 
    - Configure services

        ```sh
        public void ConfigureServices(IServiceCollection services)
        {
             services.AddMvc();
        }
        ```
        
    - Replace the code in yout Configure method with the snippet below.
        ```sh
            public void Configure(IApplicationBuilder app)
            {
                app.UseMvc();
            }
        ```
- Adding a page
    - Add a Pages folder
    - Add a new page Index.cshtml
    - Add ```@page``` directive
    - Add html 
    ```sh
            <h1> Welcome to the MVA</h1> 
            <h2> On @DateTime.Now</h2> 
    ```
## Module 1.2.2 Configuration
*Configuration is built-in*
- Open Startup.cs
- Add a construtor that takes DI and assigns to a property
```sh
    public Startup(IConfiguration config) 
    { 
         Configuration = config; 
     } 
  
    public IConfiguration Configuration { get; set; } 
```
- Add appsettings.json
    - Add a message property
    ```"Message":" Config calling"; ```
- Read the property 
```sh
    @using Microsoft.Extension.Configuration
    @inject IConfiguration Configuration   
    <h2>@Configuration["Message"]</h2> 
```

