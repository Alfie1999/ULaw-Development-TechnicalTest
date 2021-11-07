# `Roy Sefton`
### The University of Law Developer Technical Test
---

|Related Documnets|
| ---      | 
|- [Guidelines for this project](README.md)|
|- [Technical Exercise Instructions](https://github.com/Alfie1999/ULaw-Development-TechnicalTest/blob/main/Technical%20Exercise%20Instructions.docx)|

---

### Main Code Refactoring

1. [SOLID](https://en.wikipedia.org/wiki/SOLID) principles have been applied to refactor the code.

1.	[*IApplicationDetails.cs*](https://github.com/Alfie1999/ULaw-Development-TechnicalTest/blob/main/ApplicationProcessor/IApplicationDetails.cs) - 
     Interface used with ApplicationDetails.cs,  benefits include [Dependency Injection](https://en.wikipedia.org/wiki/Dependency_injection) to loosely couple which then allows for improved testing.
     
2.  [*ApplicationDetails.cs*](https://github.com/Alfie1999/ULaw-Development-TechnicalTest/blob/main/ApplicationProcessor/ApplicationDetails.cs) - [POCO](https://en.wikipedia.org/wiki/Plain_old_CLR_object) class to hold the candidate's application.

3.	[*Application.cs*](https://github.com/Alfie1999/ULaw-Development-TechnicalTest/blob/main/ApplicationProcessor/Base/Application.cs) - Converted to an abstract base case that allows the implementation of the [Open/Closed](https://en.wikipedia.org/wiki/Open%E2%80%93closed_principle) principle with Process method overloading in derived classes.
 

### Other Considerations

   - [*ApplicationDetails.cs*](https://github.com/Alfie1999/ULaw-Development-TechnicalTest/blob/main/ApplicationProcessor/ApplicationDetails.cs) Add Data Annotations for             required fields and to define string length for any future storage (database) entry
   
   -	Email template pages to take the place of the string builder text for the email body.
   
   -	Introduce [logging](https://en.wikipedia.org/wiki/Logging_(software)).
      
  
      
