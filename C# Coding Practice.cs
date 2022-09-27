﻿//learning dictionaries

IDictionary<int, string> numberNames = new Dictionary<int, string>();
numberNames.Add(1, "One"); //adding a key/value using the Add() method
numberNames.Add(2, "Two");
numberNames.Add(3, "Three");

//The following throws run-time exception: key already added.
//numberNames.Add(3, "Three"); 

foreach (KeyValuePair<int, string> kvp in numberNames)
    Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

//creating a dictionary using collection-initializer syntax
var cities = new Dictionary<string, string>(){
    {"UK", "London, Manchester, Birmingham"},
    {"USA", "Chicago, New York, Washington"},
    {"India", "Mumbai, New Delhi, Pune"}
};

foreach (var kvp in cities)
    Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);


//Editted at home
Console.WriteLine("Write a number from 1-3: ");
Convert.ToInt32 number = Console.ReadLine();
switch
    case 1:
    Console.WriteLine(cities["UK"]);
    break;
    case 2:
    Console.WriteLine(cities["USA"]);
    break;
    case 3:
    Console.WriteLine(cities["India"])
    default:
    Console.WriteLine("Not an option")
