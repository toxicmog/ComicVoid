﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicVoid.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoidController: ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "hello", "goodbye" };
        }
    }
}
