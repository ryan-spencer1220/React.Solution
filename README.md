# Learn To React: A learnhowtoprogram.com React Course Companion

![image](/React/wwwroot/img/learntoreact.png)

#### A C# application built with ASP.NET Core, Entity to integrate MySQL databases, and Identity for authentication / authorization

#### By Alex Adamovic, Ryan Spencer, Jessi Baker, Riley Shimp, Jase Seeley, & Eric Crudup

## Technologies Used

- _C#_
- _HTML_
- _JavaScript_
- _CSS_
- _MySQL_

### Dependencies

- _Entity_
- _Identity_
- _Bootstrap_
- _ASP.NET Core_

## Description

_Learn To React is a C# web application to serve as a tutorial companion to [learnhowtoprogram's](https://www.learnhowtoprogram.com) React course. On the splash page, the user is presented with general information about the course. Once a user registers and logs in, they are able to view their dashboard and access all of the lessons available. Each user is linked to SQL database tables containing boolean values as to whether they have completed lessons in all of the courses. Once the user has marked all of the lessons complete, they are presented with a certificate of completion. By employing Entity and LINQ syntax, user submit inputs trigger boolean state changes that are passed to the respective mySQL database tables through Post requests. This application showcases our team's flexibility in using multiple One-To-One relationships in connecting an ASP.NET core web framework with mySQL databases using Entity, as well as handle authorization/authentication with Identity._

## Setup/Installation Requirements

#### To Install MySQL & MySQL Workbench

- _go to https://dev.mysql.com/downloads/ and install **MySQL Community Server** and **MySQL Workbench** for your operating system_
- _follow the instructions at [learnhowtoprogram](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql) for proper installation_

#### To Set Up Project With Dependencies

- _clone repository from https://github.com/ryan-spencer1220/React.Solution.git_
- _navigate to the project directory in your terminal/command line_
- _navigate to the subdirectory React and enter `dotnet restore` to install project dependencies_

#### To Create appsettings.json

- _navigate to the subdirectory Factory and create the file `appsettings.json`_
- _add the following code:_

```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR_DATABASE];uid=[YOUR_USER_ID];pwd=[YOUR_PASSWORD];"
  }
}
```

- _replace the applicable sections with your database name, your user ID, and your password_

#### To Create Database using Migrations

- _navigate to the project directory in your terminal/command line_
- _navigate to the subdirectory React and enter `dotnet ef database update` to create a new local database for the project_
- _the database will take the name specified in your `appsettings.json` file and can be viewed using MySQL_

#### To Run the Web Application

- _navigate to the subdirectory React and enter `dotnet run` for a snapshot server or `dotnet watch run` for a live updating server for the application_
- _access the server in your browser by entering `localhost:5000` into your navigation bar_
- _click the hyperlinks and submit forms to navigate between the views_
- _enter `ctrl` + `c` for Windows or `command` + `.` for Mac in your terminal/command line to stop the server_

## Known Bugs

- _None_

## License

_MIT License_

## Contact Information

alexanderadamovic@gmail.com | ryan.spencer1220@gmail.com | jessb.epicodus@gmail.com | Cruduper@users.noreply.github.com | jase.seeley@gmail.com | rilryshimp@gmail.com
