## Module 1.1 : Getting Started with ASP.NET Core  

### Install the .NET Core SDK 
1. Go to https://dot.net and follow the instructions to download and install the .NET Core SDK for your OS

2. Tools :  Visual Studio and Visual Studio Code 
    - [Visual Studio](https://www.visualstudio.com/)
    - [Visual Studio Code](https://code.visualstudio.com/)
3. Documentation :  docs.microsoft.com  

## Module 1.1.1 : Introduction to the .NET CLI  &  Templating 

#### .NET CLI walkthorugh 

- Run the following commands

```sh
   dotnet -version  
   dotnet - help  
```
- Show templates 

```sh
   dotnet new 
```
- Create a console application
```sh
  dotnet new console -o myapp
```
- Open console app in Visual Studio Code 

```sh
using System;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

```
- Add ```Console.Readline() ```
- Basic introduction to debugging 

## Module 1.1.2 Doumentation & Community 

#### Documentation 

- Docs.microsoft.com
- Interactive C# tutorials 

#### Community 
 - .NET and ASP.NET GitHub Repo
 - Live.asp.net
 - Code Conversation Channel 9
 - Web dev blogs & .NET blogs 

