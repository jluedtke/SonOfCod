# Son of Cod
### Jared Luedtke 08.011.2017

## Description
Son of Cod is a basic application that preforms user authentication, route security, and minor styling.

## Specs
| Spec | Input | Output | Description |
| :------------- | :------------- | :------------- | :------------- |
| Program can set up database. | "dotnet ef database update" | *Mock data here* | Program needs the database to implement user authentication |
| Program can add admin users. | "Create admin account" | Admin1 | Program creates admins to monitor regular users. |
| Program can add recipients to newsletters. | "Subscribe" | User1.Email | Program is designed around this feature for buisinesses. |
| Program can list recipient emails for admin accounts. | "Mailing List" | *List of emails* | Requested feature by client. |

## Setup/Installation Requirements
1. Clone this repository : [GitHub](https://github.com/jluedtke/SonOfCod)
2. Make sure you have [Visual Studio 2015](https://www.visualstudio.com/downloads/) and [SQL SSMS](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms) installed
3. Execute the file "SonOfCod.mvss" in Project Directory
4. Open Windows Powershell and navigate to SonOfCod/src/SonOfCod
5. Input the command: dotnet ef database update
6. This will set up a blank database.
7. Inside of Visual Studio, click "IIS Express" or the green play button to start the webpage.

## Known Bugs
None at this time

## Technologies Used
* .NET Core
* C#

## Legal
Copyright (c) 2017 **_Jared Luedtke_** All Rights Reserved.
Licensed under the MIT license.
