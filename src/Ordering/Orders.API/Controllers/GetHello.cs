﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Orders.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetHello : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello World!";
        }
    }
}
