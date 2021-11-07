Roy Sefton comments
=============================

I've used SOLID principles to refactor this code

1)	ApplicationDetails.cs 
     Add Data Annotations for required fields and string length for any future database entry

2)	IApplicationDetails.cs  - 
     Interface used with ApplicationDetails.cs 
     benefits include Dependency Injection to loosely couple which 
     then allows for improved testing.

3)	Application.cs 
    now an abstract base case that allows the implementation of the Open/Closed principle with Process method overloading in derived classes
    
4)	Other considerations

i)	Email template pages for the email body to replace the string builder text
ii)	Introduce logging.
