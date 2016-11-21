Welcome to Week 7: Advanced topics!

You will review:
- interfaces
You will learn about:
- delegates
- lambda expressions
- LINQ

1. ScifiShows
Follow the tutorial here:
http://codetunnel.io/introduction-to-linq-part-i-delegates/
Create a console app called ScifiShows based on the tutorial.

2. Ads 
Spam simulator
a) Create an AdTarget class with public read & write properties for FirstName, LastName, BirthDate, Email.
Also create a property called Age. This property only has a getter. The getter computes the age from DateTime.Today and BirthDate.
b) Create an PersonalizedAd class with public read & write properties for ToAddress, Subject, and Message.
c) Create an interface called IAdTargetRepository with a method to GetAallAdTargets
d) Create a class that implements the repository interface for quick testing. 
Use Genfu, or Bogus, or another generator of your choice.
Generate a list of 200 random AdTargets, with random BirthDates between 1905 and 2005.
e) Print the targets to the console. Make sure any var or field you store the repository to is of the interface type, not of the class type.
This way, we can easily switch to a real implementation that goes to the database.
f) Read a target age interval from the console (e.g. minAge 15 - maxAge 30)
g) Use LINQ to create a list of PersonalizedAds for each AdTarget in the target age range. 
ToAddress = target.Email
Subject = "Wanna buy our new product that sings 'O come all ye faithful?'"
Message = "Hey {target.FirstName}, you're in for a treat blah blah"
Use 
.Where(...)
.Select(...)
.ToList()
h) Make sure the code that creates the PersonalizedAds is in its own class. 
Write tests for that class.