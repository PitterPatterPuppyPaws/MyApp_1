

using System.ComponentModel.DataAnnotations;

namespace MyApp_1.Models;

public record class FirstModel
{
    public int Id { get; set;}
    public string? Username { get; set; }
    public string? Password { get; set; } // obviously you wouldn't actually store a plaintext password
    [DataType(DataType.DateTime)]
    public DateTime DateCreated { get; set; }
}