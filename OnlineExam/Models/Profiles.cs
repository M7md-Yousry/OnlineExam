using System.ComponentModel.DataAnnotations;

namespace UsersProfiles.Models;

public class Profiles
{
    public int Id { get; set; }
    public string? Email { get; set; }

    public string? Password { get; set; }

}