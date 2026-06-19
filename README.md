# Test Project
This contains a couple of items for this test:

1. First is the data model image that contains a simple version of the proposed data model. I did create an Azure infrastructure model, but the application I used has locked me out of viewing it, so I couldn't export it and upload it here. The basic infrastructure would be an API server, and app server both accessing a database server which would use Redis to cache common requests making those requests return faster. Another service I would create is one that regularly goes through certain tables (such as jobs) and removes old records making sure table scans return quickly. This would allow for the application to scale well over time and not get slower the longer the system is in operation. 
2. The TestWebApi - This contains a simple API structure using Entity Framework and Web API where I have implemented some basic routes. The main one is the route showing how the API would get all jobs for a candidate based upon their skills. This is a simple version and not meant to represent all potential available features. Having more time I would separate the API and data access logic into their own sections allowing the LINQ statements to be reused for other routes.

You can contact me with any further questions.
