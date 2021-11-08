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

If I had more time, I would implement dependency injection by creating an interface for QuotRepository.cs.
I would also create a data transfer object for the Applicant entity. In order to fully flesh out the API, I'd also implement endpoints for GET, PUT, PATCH and DELETE, and then I'd probably containerize the API for deployment.