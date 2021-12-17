using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BankOnNet6.Models
{
    [Index("CardNumber", "UserName", IsUnique = true)]
    public class User
    {
        [Key]
        public int Id { get; set; } = 0;

        [MaxLength(16), MinLength(16), Required]
        public int CardNumber { get; set; } = 0;
        [MaxLength(6), MinLength(6), Required]
        public int Pin { get; set; } = 0;

        [StringLength(30), Required]
        public string Username { get; set; } = string.Empty;
        [StringLength(30), Required]
        public string Password { get; set; } = string.Empty;

        [StringLength(30), Required]
        public string Firstname { get; set; } = string.Empty;
        [StringLength(30), Required]
        public string Lastname { get; set; } = string.Empty;
        [StringLength(128), Required]
        public string Address { get; set; } = string.Empty;
        [StringLength(35), Required]
        public string City { get; set; } = string.Empty;
        [StringLength(2), Required]
        public string State { get; set; } = string.Empty;
        [StringLength(12)]
        public string? Phone { get; set; } = null;
        [StringLength(255)]
        public string? Email { get; set; } = null;
        
    }
}
