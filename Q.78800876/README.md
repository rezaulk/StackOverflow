

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
