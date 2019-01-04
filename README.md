# scored
clone the project to your local machine
```
git clone https://github.com/bmusiime/scored.git
```

Restore dependencies

```
cd scored
```
Set the following environment variables:
```
export TEST_URL=http://localhost:3000
export APP_URL=http://localhost:3000  
export ASPNETCORE_ENVIRONMENT=Development 
export ASPNETCORE_URLS=http://localhost:5002
```
To run:
```
dotnet clean
dotnet build
dotnet run -project scored
```

The app should be running and accessible on http://localhost:5002
# mock data

Run the mock server:
```
cd mock
npm install
npm install -g json-server
```
you may need to update node:
```
sudo npm install n -g
sudo n stable
```

Start the mock server using the data.json file:
```
json-server data.json --routes routes.json 
```
Accessing mock data:
```
http://localhost:3000/skills
http://localhost:3000/listskills
http://localhost:3000/retros
  
```

or

```
http://localhost:3000/api/skills
http://localhost:3000/api/listskills
http://localhost:3000/api/retros
  
```
