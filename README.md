# UNATTENDED-TEST-WEBSERVICES

<br>

## About The Project

The objective for this project was to develop an ASP.NET application, exposing two RESTful services:
1. Return a list of all Member resources
2. Return a Member resource for a given unique memberNumber

<br>

## My Assumptions

* Member resources would be stored in an in-memory data service.

<br>

## How To Build The Application

The application was built using Microsoft.NETCore.App 6.0.13

To build the application:
1. Navigate `"/unattended-test-webservices/src/WebServices"`
2. Run the following command: 
   ```sh
   dotnet build
   ```

<br>

## How To Run The Application

To run the application:
1. Navigate to `"/unattended-test-webservices/src/WebServices"`
2. Run the following command: 
   ```sh
   dotnet run
   ```
3. An HTTP GET request to `https://localhost:{PORT}/member` will return a list of all Member resources
4. An HTTP GET request to `https://localhost:{PORT}/member/6398592762` will return a Member resource for a given unique memberNumber

<br>

## Testing The Application

I used Postman to test the application.

My testing coverered 3 main scenarios:
1. Returns a list of all Member resources (with 200 status)
2. Returns a Member resource for memberNumber "6398592763" (with 200 status)
3. Returns "NotFoundResult as unique ID does not exist" message when trying to return a Member resource for a given unique memberNumber which does not exist (with 404 status)

My testing results were as follows:

1. GET `https://localhost:{PORT}/member`

```sh
[
    {
        "memberNumber": "1234567890",
        "forename": "Timmy",
        "surname": "Taylors",
        "products": [
            {
                "name": "Healthcare",
                "cost": 100
            },
            {
                "name": "Travel Insurance",
                "cost": 150
            }
        ]
    },
    {
        "memberNumber": "0987654321",
        "forename": "Yorkshire",
        "surname": "Guzzler",
        "products": [
            {
                "name": "Healthcare",
                "cost": 100
            },
            {
                "name": "Travel Insurance",
                "cost": 150
            }
        ]
    },
    {
        "memberNumber": "6398592763",
        "forename": "Theakstons",
        "surname": "Best",
        "products": [
            {
                "name": "Healthcare",
                "cost": 100
            }
        ]
    },
    {
        "memberNumber": "3986271583",
        "forename": "Beavertown",
        "surname": "IPA",
        "products": [
            {
                "name": "Travel Insurance",
                "cost": 150
            }
        ]
    },
    {
        "memberNumber": "3986271583",
        "forename": "Yorkshire",
        "surname": "Blonde",
        "products": [
            {
                "name": "Healthcare",
                "cost": 100
            },
            {
                "name": "Travel Insurance",
                "cost": 150
            }
        ]
    }
]
   ```

2. GET `https://localhost:{PORT}/member/6398592763`

```sh
{
    "memberNumber": "6398592763",
    "forename": "Theakstons",
    "surname": "Best",
    "products": [
        {
            "name": "Healthcare",
            "cost": 100
        }
    ]
}
   ```


3. GET `https://localhost:{PORT}/member/6398592762`

```sh
{
    "type": "https://tools.ietf.org/html/rfc7231#section-6.5.4",
    "title": "Not Found",
    "status": 404,
    "traceId": "00-61f0139f22c5d87bc94a543766e23d19-493cf5c848146730-00"
}
   ```