# TreatApp with Identity
#### An MVC web application for Pierre's Sweet and Savory Treats to track their Treat offerings and flavor profiles.

#### By Brent Hickman

## Technologies Used

* C#
* Dotnet 6
* Entity Framework Core
* MySQL
* Html
* Css


## TreatApp is an MVC application built for Pierre's Sweet and Savory Treats. Users can see a list of Treats and Flavors made by Pierre's . Users can also register an account and log in to access the ability to add their own Treats. Once logged in they can also create Flavors and associate them with specific Treats.

## Setup/Installation Requirements

* Open a terminal window and clone this repository by entering into the command line:
> git clone https://github.com/BrentHickman/TreatApp.Solution.git
* In the terminal, navigate to the console application with the command:
> cd Salon.Solution/TreatApp
* Once in the "TreatApp" directory, create a new file called appsettings.json
* Within appsettings.json, put in the following code, replacing the [YOURUSERNAME] and [YOURPASSWORD] values with your own username and password for MySQL.
>{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=treat_app;uid=[YOURUSERNAME];pwd=[YOURPASSWORD];"
  }
}
* Next, enter the following into the command line:
> dotnet ef database update
* To launch the application in development mode, enter the following lines into the command line:
> dotnet restore
* then:
> dotnet watch run
* The application should the be available at:
> https://localhost:5001/
* Please register an account to have full access to the site features.

## Known Bugs

* If you are experiencing any bugs, please contact me at brenthickman@ymail.com

## License

* [MIT](https://opensource.org/licenses/MIT)
* Brent Hickman 3/24/23