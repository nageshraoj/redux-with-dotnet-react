using System.ComponentModel.DataAnnotations;

namespace API.Models;

public class Student
{
    public Guid Id { get; set; }

    [Required]
    public string FirstName { get; set; } = "";

    public string? LastName { get; set; }

    public string? Location { get; set; }


}