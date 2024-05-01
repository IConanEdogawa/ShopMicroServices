# My Project

This is my first Microservices project where <br>I use CQRS pattern for design.

## Screenshots

![Screenshot 1](/Screenshot%202024-04-30%20084313.png)
![Screenshot 2](/Screenshot%202024-04-30%20084000.png)

## Code Blocks
```json
{
  "Routes": [
    {
      "DownstreamPathTemplate": "/api/Catalogs",
      "DownstreamScheme": "https",
      "DownstreamHostAndPorts": [
        {
          "Host": "localhost",
          "Port": 7075
        }
      ],
      "UpstreamPathTemplate": "/apigetway/users",
      "UpstreamHttpMethod": [ "POST ", "GET" ]
    },
    {
      "DownstreamPathTemplate": "/WeatherForecast",
      "DownstreamScheme": "https",
      "DownstreamHostAndPorts": [
        {
          "Host": "localhost",
          "Port": 7160
        }
      ],
      "UpstreamPathTemplate": "/apigetway/WeatherForecast",
      "UpstreamHttpMethod": [ "Get" ]
    },
    {
      "DownstreamPathTemplate": "/api/Catalogs",
      "DownstreamScheme": "https",
      "DownstreamHostAndPorts": [
        {
          "Host": "localhost",
          "Port": 7075
        }
      ],
      "UpstreamPathTemplate": "/apigetway/create",
      "UpstreamHttpMethod": [ "POST " ]
    },
    {
      "DownstreamPathTemplate": "/api/GetHello",
      "DownstreamScheme": "https",
      "DownstreamHostAndPorts": [
        {
          "Host": "localhost",
          "Port": 7019
        }
      ],
      "UpstreamPathTemplate": "/apigetway/getHello",
      "UpstreamHttpMethod": [ "GET" ]
    },
    {
      "DownstreamPathTemplate": "/api/GetBye",
      "DownstreamScheme": "https",
      "DownstreamHostAndPorts": [
        {
          "Host": "localhost",
          "Port": 7165
        }
      ],
      "UpstreamPathTemplate": "/apigetway/getBye",
      "UpstreamHttpMethod": [ "GET" ]
    }
  ],
  "GlobalConfiguration": {
    "BaseUrl": "https://localhost:5000"
  }
}
```

## Homework solutions 

[View my text file](/homework.txt)


