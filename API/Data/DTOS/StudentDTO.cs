using System.ComponentModel.DataAnnotations;

namespace API.Data.DTOS;

public class StudentDTO
{
    public Guid Id { get; set; }

    [Required]
    public string FirstName { get; set; } = "";

    public string? LastName { get; set; }

    public string? Location { get; set; }

}