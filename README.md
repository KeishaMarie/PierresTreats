# Treat and Flavor Tracker

#### By Keisha Hepner

#### This is an MVC application that allows a user to track current treats and flavors

## Technologies Used

* C#
* HTML
* .Net 5
* Entity
* Identity
* Asp.Net Core MVC
* MySql
* JavaScript

## Description

This is an MVC application that allows users to view Treats and Flavors for a bakery. Users are able to register and then log in to Create, Edit and Delete flavors or treats. If the user is not registered, they will only be able to view the Treats and Flavors without any modification abilities.

## Setup/Installation Requirements

* Clone Repository using url https://github.com/KeishaMarie/PierresTreats
* Add a file labeled appsettings.json and input the following code:
{
"ConnectionStrings": {
"DefaultConnection": "Server=localhost;Port=3306;database=database;uid=YOURUSERNAME;pwd=YOURPASSWORD;"
}
}
* Be sure to update the code to match your database, username and password
* Run dotnet restore and dotnet build to build the application
* Install 'dotnet ef tool' by running this command in your terminal: dotnet tool install --global dotnet-ef --version 5.0.1
* Create a Migration for your database by running this command in your terminal: dotnet ef migrations Initial
* Update your database by runnding this command in your terminal: dotnet ef database update
* Run "dotnet run" to run the application

## Known Bugs

* Header and Footer do not scale properly yet

## Copyright (c) <2022 Keisha Hepner>
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

