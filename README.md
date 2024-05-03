Self-Assessment: Onion Architecture, MVC, and Web API (.NET Core) with Bottlenecks (Encountered)
Conceptual Understanding:
 
Onion Architecture: (Yes/No) 
 
Have you heard of the Onion Architecture principle in software design?
 
---No
 
MVC Pattern: (Yes/No) 
 
Are you familiar with the Model-View-Controller (MVC) pattern for building web applications?
 
---No
 
Web API: (Yes/No) 
 
Do you understand the concept of building RESTful APIs using ASP.NET Core Web API?
 
---No


Application & Bottlenecks:
Onion Architecture:
 
 
Benefits: (1-3 keywords)
 
 
 
Briefly list some key benefits of using Onion Architecture in .NET Core projects. (e.g., separation of concerns, testability)
 

---Modular, Clean, Scalable
 
 
Bottlenecks (Encountered): (Yes/No and Briefly Explain)
 
Have you encountered any challenges with Onion Architecture in your projects? If so, briefly describe the bottleneck(s). (e.g., Increased complexity for simple projects, difficulty finding developers familiar with the pattern)
 
---Yes, Implementation of the architecture is difficult to to the first time
 

MVC:
 
 
Components: (1-3 keywords each)
 
 
Briefly describe the roles of the Model, View, and Controller in the MVC pattern.
 
---Model contains the structure of the data used, Views are what the user interacts with to access the data, Controller is the logic of the app
 
 
Bottlenecks (Encountered): (Yes/No and Briefly Explain)
 
 
Have you encountered any challenges with tight coupling between Model and Controller in MVC projects? If so, briefly describe the issue(s). (e.g., Difficulty in unit testing controllers, logic changes rippling through the application)
 
---A problem where the controller would clear the database everytime something an action in the controller is referenced
 

Web API:
 
 
Differences from MVC: (Yes/No and Briefly Explain)
 
 
Can you differentiate between traditional MVC applications and Web APIs? Briefly explain the main difference.
 
---MVC have everything in the web app, Web API separates the client and server
 
 
Bottlenecks (Encountered): (Yes/No and Briefly Explain)
 
 
Have you encountered any performance challenges with traditional MVC applications compared to Web APIs? If so, briefly describe the scenario(s). (e.g., Frequent page refreshes causing performance overhead, complex data exchange requiring a more lightweight approach)

---
