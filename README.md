# LibraryAutomation
The main goal of this project is to create a ready-to-use book rental tracking system for the library. Clean code, SOLID principles, openness to change and improvement are just some of the things I focused on while creating the project. The application is designed as fully responsive. And here are some of the features you can see when reviweing this project

* N-Tier Architecture
* Repository Pattern
* Unit Of Work Pattern
* Custom Exception Handler
* Clean File Structure

### Some of the technologies used
* ASP.NET CORE 6 MVC
* Entity Framework Core 6
* Bootstrap 5
* MSSQL (On Local With SQL Server Management Studio)

### How it works?
First of all, the application is built on ASP.NET CORE 6 MVC. That is, it works in MVC (Model - View - Controller) logic. It uses Entity Framework Core 6 as ORM tool. 
When you log in to the application, a clean and simple page welcomes you. You can navigate between pages with the navbar at the top, create books, authors and see the current rental status.

If you want to create a book, you can access the creation page from the navbar and create it easily. But remember that before you can create your book, you must first create the author of your book. Books and Authors are in a relationship. If your author is not available in the selection box, you can easily create your author by using the "Create Author" button in the navbar.

Ids are created automatically when creating books and authors. Id type is Guid and does not increment automatically.

If you want to make a rental, just click on the "Rent" button above the books listed on the home page. It will then redirect you to a rental page and take the necessary information from you.
If you see a "Not Rentable" button, the book is most likely already rented to someone else or is not available.
If you want to see the rental status or when the book will arrive, just press the 'Rents' button in the navbar.
On this page you can see the rental status, which book has been rented by whom and when it will arrive. You can also end the rental and return the book to the pool by clicking "Receive" on this page.

### Other informations
The application is built on N-Tier Architecture and is built in accordance with SOLID principles. So it is always open to development, workload and updates. The project has become more scalable due to the Repository Pattern and Unit Of Work Patterns used.
Custom Exception Handler logs any error that occurs in the application instantly and the user can easily continue using the application.

### To run the application
First of all, here are the things that should be installed on your machine
* .NET 6
* MSSQL - SQL Server Management Studio (Recommended)  Or a SQL 2019 container that you install on docker

Then add your connection string to the application.json file in LibraryAutomation.Web. This will connect your database to the application. There is some data in it for you to test the application. To include them, you can run the "onModelCreating" method under the "LibraryDbContext" class under the "Data" layer. 
Then you should do the necessary migration operations. These are respectively
add-migration (migration name) and update-database. If these operations are done successfully, you can easily use the application.

If you encounter any other problems or have any questions, please do not hesitate to contact me! I would be very happy to help you.
Have a good day.


