# Module 1.3.0 Introduction to Razor Pages 

### What are Razor Pages?
Razor Pages is a new feature of ASP.NET Core MVC that makes coding page-focused scenarios easier and more productive 
### Create a Razor Page web app
- From the Visual Studio File menu, select New > Project. 
- Create a new ASP.NET Core Web Application  
- Select Web Application  
    - Briefly mention that MVC template is still available  
- Show the starter template  
- Run the application  
    - *Note: it looks the like MVC templates you have seen in the past.* 
- Go over the project structure  
- Show some of the MVC features that are similar 
 
 Go over routing in pages
- Add another page 
    - Tickets.cshtml- *Requests are routed to different pages based on their name and location on the file system.*
    
**Example**
| File name & path | matching url |
| ------ | ------ |
| /Pages/Ticket.cshtml  | /Ticket  |
| /Pages/Beyonce/Ticket.cshtml | /Beyonce/Ticket  |
- Show the Code behind 
    - Show the Page Model for the Tickets page 