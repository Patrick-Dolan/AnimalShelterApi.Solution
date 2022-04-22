# Animal Shelter Api

#### By _**Patrick Dolan**_

#### _An API for lists of available cats and dogs at a shelter._

## Technologies Used

* C#
* .NET 5.0
* dotnet
* MySql/Workbench

## Description

An API for lists of available cats and dogs at a shelter.

## Setup/Installation Requirements

* Make sure you have MySql Workbench installed on your computer.
* Make sure to have dotnet-ef installed too.<br>
<em>This project uses <code>dotnet-ef --version 3.0.0</code> which I have globally installed but you can install it however you want. 
* Download repo to your computer using either clone or the download link.
* Open the project in VScode or your terminal/IDE of choice.
* Create an <code>appsettings.json</code> file in the root directory of the project folder: <code>AnimalShelterApi.Solution/AnimalShelterApi/</code>. And add the following code replacing anything in square brackets with the information it represents specific to the project database:
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE-NAME-HERE];uid=[USER-ID-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}

```

Example of complete appsettings.json:
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter;uid=root;pwd=strongpassword;"
  }
}

```

* Make sure to run your mysql server and open MySql workbench.
* Open MySql Workbench and login to your server.
* From your terminal navigate to the <code>AnimalShelterApi.Solution/AnimalShelterApi/</code> folder and run the command <code>dotnet ef database update</code> to create the database from migrations.
* Now using your IDE navigate into the AnimalShelterApi.Solution/AnimalShelterApi folder and use the command dotnet run to launch the program.
* The API should now be available at the server address you used in the appsettings.json folder.
* The site should be available at the server address you used in the <code>appsettings.json</code> folder.

## API Documentation
You can explore the API endpoints in Postman or your browser. Once the API is running you can also go to <code>[Your-server-addres]/swagger</code>.  
* For example <code>http://localhost:5001/swagger</code>

This is an open API so you dont need any authentication to use all CRUD functionality. 

### Endpoints
Base URL: http://localhoust:5001

HTTP Request structure
```
GET /api/Animals
POST /api/Animals
GET /api/Animals/{id}
PUT /api/Animals/{id}
DELETE /api/Animals/{id}
```

Example query
```
https://localhost:5001/api/animals/2
```

Example Response
```
{
  "animalId": 2,
  "name": "Skittles,
  "petType": "Cat",
  "breed": "Persian",
  "age": 5,
  "gender": "Male",
  "color": "White"
}
```

Search parameters include:
```
petType: Whether its a dog, cat, bird, etc...
breed: What breed of the petType like husky for dog and persian for cat
minimumAge: Returns results based on animals with a minimum age. Minimum age is 0.
maxAge: Returns results based on animals with a maximum age: Max age is 25.
gender: Returns results based on chosen gender. Male and Female.
color: Returns results based on a chosen color. Black, white, etc...
```
## Known Bugs

* _No known bugs._

## Contact Me

Let me know if you run into any issues or have questions, ideas or concerns:  
dolanp1992@gmail.com

## License

_MIT_

Copyright (c) _2022_ _Patrick Dolan_