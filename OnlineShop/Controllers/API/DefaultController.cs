﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DefaultController : ControllerBase
    {
    }
}