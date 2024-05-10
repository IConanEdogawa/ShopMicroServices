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
          "Host": "catalog.api",
          "Port": 9090
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
          "Host": "discount.api",
          "Port": 9092
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
          "Host": "orders.api",
          "Port": 9094
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
          "Host": "shoppingcarts.api",
          "Port": 9096
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
          "Host": "shop",
          "Port": 9098
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

[View my homework file](/HOMEWORK.md)


