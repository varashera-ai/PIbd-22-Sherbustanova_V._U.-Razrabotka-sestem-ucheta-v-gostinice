using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelAccounting.Models;

public class Guest
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(150)]
    [Column("fullname")]
    public string FullName { get; set; } = string.Empty;

    [Required]
    [MaxLength(50)]
    [Column("passportnumber")]
    public string PassportNumber { get; set; } = string.Empty;

    [MaxLength(20)]
    [Column("phone")]
    public string Phone { get; set; } = string.Empty;

    [Column("isregularclient")]
    public bool IsRegularClient { get; set; }

    public Guest() { }

    public static Guest CreateEntity(int id, string fullName, string passportNumber, string phone, bool isRegularClient)
    {
        return new Guest
        {
            Id = id,
            FullName = fullName ?? string.Empty,
            PassportNumber = passportNumber ?? string.Empty,
            Phone = phone ?? string.Empty,
            IsRegularClient = isRegularClient
        };
    }
}