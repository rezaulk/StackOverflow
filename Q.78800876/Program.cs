// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Configuration;
using System;

var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");


var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{environment}.json", true, true)
    .Build();

string exampleSetting = configuration["ExampleSetting"];
Console.WriteLine($"Example Setting: {exampleSetting}");