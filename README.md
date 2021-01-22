# Animal Shelter API
#### **01/22/2021**

## By _Callie Stump_
---
## <u>**About** </u>
### 🚩 **Description**
This is an API application for an Animal Shelter. The API allows connected users to manage their database with the use of 'Http Methods' - GET, POST, PUT, DELETE, and RANDOM.

### 🐛 Known Bugs
There are no known bugs at this time.


<hr>

## <u>**Getting Started**</u>
### **☑️ Requirements**
* C# .Net Core v2.2.4 installed on your local machine.
* Console/Terminal access.
* Code Editor 
Ex.) [Visual Studio Code](https://code.visualstudio.com/)
* MySQL Community Server & Workbench (if you generate your own database)


### 🔧 **Setup/Installation**
#### **Project Editor Setup**
1. Copy this download link: https://github.com/calliestump/AnimalShelter.Solution.git
2. Open bash and go to the directory where you would like to store your cloned project.
3. Clone the repo.
```
git clone https://github.com/calliestump/AnimalShelter.Solution.git
```
4. Navigate to the cloned project folder and open VS code.
```
$ cd Desktop
$ cd [known directory]
$ code .
```
5. If you wish to see if everything is compiling correctly go to the Bakery directory and run the following:
```
dotnet build
```
6. To see if the program is functioning properly you can use:
```
dotnet watch run
```
This will show you if everything is compiling correctly; otherwise you be will prompt with error messages.

#### **Dont forget that in order to push any changes you need to add your own GitHub repo. to your project.**
```
git remote add origin [personal Github repo. link]
```
#### **Note**: Do this is your main parent directory. You do not want to have git initialized in any other places.

#### **AppSettings/Database Connection Setup**
1. Create a new file in the "AnimalShelter.Solution/AnimalShelter" directory named appsettings.json
2. Add in the following code snippet to the new appsettings.json file:
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=firstname_lastname_animalShelter;uid=root;pwd=epicodus;"
  }
}
```

#### **Import Database with Entity Framework Core**
1. Navigate to the "AnimalShelter.Solution/AnimalShelter" directory using your terminal.
2. Run the command 'dotnet ef database update to generate the database through Entity Framework Core.
3. (Optional) To update the database with any changes to the code, run the command 'dotnet ef migrations add [MigrationsName] which will use Entity Framework Core's code-first principle to generate a database update. After, run the previous command 'dotnet ef database update' to update the database.

<hr>

## <u>**API Documentation**</u>
Base URL: ```https://localhost:5000```

### **```[Http]``` Requests**

**Cats  Endpoints**
```
GET /api/cats
POST /api/cats
GET /api/cats{id}
PUT /api/cats{id}
DELETE /api/cats/{id}
RANDOM /api/cats/random
```
**Dogs Endpoints**
```
GET /api/dogs
POST /api/dogs
GET /api/dogs{id}
PUT /api/dogs{id}
DELETE /api/dogs/{id}
RANDOM /api/dogs/random
```
### **<u>Example Query & Response</u>**
**Query:**

```https://localhost:5000/api/cats/1```

**Response:**

```
{
    "catId": 1,
    "catName": "Sage",
    "catGender": "Female",
    "catAge": "1 year, 5 months",
    "catBreed": "Maine Coon/Mix",
    "catDescription": "Sage is a friendly cat that really enjoys being around people. She is very loving and will give you all the cuddles you desire."
}
```
## **Swagger Documentation**
Navigate through our endpoints with the use of NSwag.
* after running ```dotnet watch run``` , go to your browser and navigate to 
```http://localhost:5000/swagger```
<hr>


## **Technologies Used**
* Visual Studio Code 1.52.1
* C# V:7.3
* .NET Core V: 2.2.0
* MySQL WorkBench V: 8.0
* Entity Framework Core V: 2.2.6
* dotnet script, REPL
* API
* NSwag
* Postman


------------------------------
## 👤 Contributor

| Author | Email |
|--------|:-----:|
| [Callie Stump](https://www.linkedin.com/in/callie-stump/) | [callie@stu.mp](mailto:callie@stu.mp) |
------------------------------

## 📝 Legal
```
MIT License

Copyright (c) 2021 Callie Stump

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
```
<center><a href="#">Return to Top</a></center>
