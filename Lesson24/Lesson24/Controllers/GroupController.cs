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

        if (ModelState.IsValid)
        {
            if (!IsGroupInCache(group))
            {
                cachedGroups.Add(group);
            }

            return Ok(cachedGroups);
        }

        return BadRequest(ModelState);
    }


    private bool IsGroupInCache(StudentGroup group)
    {
        return cachedGroups.Any(g => g.Name == group.Name && g.Course == group.Course);
    }
}


    
