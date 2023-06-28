using Lesson24;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

[ApiController]
[Route("api/[controller]")]
public class GroupController : ControllerBase
{
    private static List<StudentGroup> cachedGroups = new List<StudentGroup>();
    

    [HttpPost]
    public IActionResult Post([FromBody] StudentGroup group)
    {
        
        if (!ValidateGroup(group))
        {
            return BadRequest("Некоректні дані групи");
        }

        
        if (!IsGroupInCache(group))
        {           
            cachedGroups.Add(group);
        }
        return Ok(cachedGroups);
    }

    private bool ValidateGroup(StudentGroup group)
    {
        if (string.IsNullOrEmpty(group.Name) || group.Name.Length < 2 || group.Name.Length > 5)
        {
            return false;
        }

        if (group.Course <= 0 || group.Course >= 7)
        {
            return false;
        }

        Regex regex = new Regex(@"^[A-Za-z]{3}-\d{2}$");
        if (!regex.IsMatch(group.Name))
        {
            return false;
        }

        return true;
    }

    private bool IsGroupInCache(StudentGroup group)
    {
        return cachedGroups.Any(g => g.Name == group.Name && g.Course == group.Course);
    }
}