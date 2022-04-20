using System.ComponentModel.DataAnnotations;

namespace API.Data.DTOS;

public class NewStudentDTO
{


    [Required]
    public string FirstName { get; set; } = "";

    public string? LastName { get; set; }

    public string? Location { get; set; }

}