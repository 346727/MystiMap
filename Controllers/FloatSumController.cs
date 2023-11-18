using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace MystiMapWeb.Controllers;

[ApiController]
[Route("[controller]")]
public class FloatSumController : ControllerBase
{
    // POST: api/Value/Sum
    [HttpPost("Sum")]
    public ActionResult<float> SumValues([FromBody] FloatSum floatSum)
    {
        if (floatSum == null || floatSum.Values == null || floatSum.Values.Count != 18)
        {
            return BadRequest("Invalid input. Provide a list of 18 float values.");
        }

        float sum = floatSum.Values.Sum();
        return Ok(sum);
    }
}


