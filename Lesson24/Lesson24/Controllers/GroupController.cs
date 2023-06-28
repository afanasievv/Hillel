using Lesson24;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;

[ApiController]
[Route("api/[controller]")]
public class GroupController : ControllerBase
{
    private static List<StudentGroup> cachedGroups = new List<StudentGroup>();

    [HttpPost]
    public IActionResult Post([FromBody] StudentGroup group)
    {
        var validationResults = new List<ValidationResult>();
        var validationContext = new ValidationContext(group);
        if (!Validator.TryValidateObject(group, validationContext, validationResults, true))
        {
            var errorMessages = validationResults.Select(result => result.ErrorMessage);
            return BadRequest(errorMessages);
        }
        if (!IsGroupInCache(group))
        {
            cachedGroups.Add(group);
        }
        return Ok(cachedGroups);
    }

    private bool IsGroupInCache(StudentGroup group)
    {
        return cachedGroups.Any(g => g.Name == group.Name && g.Course == group.Course);
    }
}
