
Problem link: https://stackoverflow.com/questions/78800876/how-to-get-environment-name-in-program-cs-file-in-net-8
Firstly Need to add this package
```
dotnet add package Microsoft.Extensions.Configuration.Json
```

then write this code 
```
var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{environment}.json", true, true)
    .Build();
   ``` 
