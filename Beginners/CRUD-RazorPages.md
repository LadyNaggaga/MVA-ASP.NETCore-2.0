# Module 1.3.1  Create a Form

Creating a simple CRUD app using Razor Pages.

*Prerequisite*: Module 1.3.0 Introduction to Razor pages

#### Add a data  model for Tickets
```sh 
    public class Ticket
    { 
        public int Id { get; set; } 
  
        [Required] 
        public string Name { get; set; } 
  
        [Required] 
        [EmailAddress]
        public string Email { get; set; } 
 
        [Required] 
        public string Artist { get; set; } 
    } 
```
#### Create a form 
```sh 
<form method="post"> 
    <p>Enter your information to find out when Beyonce gets to town!</p> 
    <div asp-validation-summary="All"></div> 
    <div> 
        <label asp-for="Ticket.Name"></label> 
        <input asp-for="Ticket.Name" /> 
    </div> 
    <div> 
        <label asp-for="Ticket.Email"></label> 
        <input asp-for="Ticket.Email" /> 
    </div> 
    <div> 
        <label asp-for="Ticket.Artist"> Beyonce</label> 
        <input asp-for="Ticket.Artist" /> 
    </div> 
 
    <button>Submit</button> 
</form> 
```
Run the application 

####  Implement Server side Code 
Open the Page Model 
- Add on post page handler 
```sh
    public IActionResult OnPost() 
    { 
        If (!ModelState.IsValid) 
        { 
            return Page(); 
        } 
 
        Return RedirectToPage("/Index"); 
        //later we learn to save this to a database 
    }   
```
- ModelBind
```sh
    [BindProperty] 
    public Ticket Ticket { get; set; } 
```
Run the application. 
#### Next step save to DB.
- Save ticket information
    - Add DBContext
```sh
public class ApplicationDbContext : DbContext 
    { 
        public ApplicationDbContext() 
        { 

        } 
  
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 

        } 
  
        public DbSet<Ticket> Tickets { get; set; }  
    } 
```
- Add the ApplicationDbContext as a service in Startup.cs 
```sh
services.AddDbContext<ApplicationDbContext>(options =>  
    options.UseInMemoryDatabase("name")); 

```
- Inject the ApplicationDbContext to your page ```@inject ApplicationDbContext Db  ```

- Run the application and save the entry to a database.