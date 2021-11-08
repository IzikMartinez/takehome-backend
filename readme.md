## Overview
This API receives a JSON payload via a POST endpoint in the form of  
{  
    "revenue": Decimal  
    "state": String  
    "business" String  
}

It returns a payload containing the following schema   
{  
"premium": Decimal  
}


To use this API, open the project in the IDE of your choice and begin debugging (F5 in VS Code).
Use Postman or Swagger with the URI https://localhost:5001/Quote to test sending payloads.


## Future work

If I had more time, I would:
* Implement dependency injection by creating an interface for QuotRepository.cs.
* Create a data transfer object for the Applicant entity. 
* Make the API fully asynchronous (currently only asynchronous between the controller and the repository)
* Implement endpoints for GET, PUT, PATCH and DELETE.
* Move the API to a separate folder "takehome.API" in the same root directory as a new folder "takehome.UnitTests"
* Create a unit test project for the API controller and its new endpoints.
* Containerize the API for deployment.