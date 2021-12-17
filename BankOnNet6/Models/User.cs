using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BankOnNet6.Models
{
    [Index("Username", IsUnique = true)]
    public class User
    {
        [Key]
        public int Id { get; set; } = 0;
        [StringLength(30), Required]
        public string Username { get; set; } = string.Empty;
        [StringLength(30), Required]
        public string Password { get; set; } = string.Empty;
        [StringLength(30), Required]
        public string Firstname { get; set; } = string.Empty;
        [StringLength(30), Required]
        public string Lastname { get; set; } = string.Empty;
        [StringLength(12)]
        public string? Phone { get; set; } = null;
        [StringLength(255)]
        public string? Email { get; set; } = null;
        
    }
}
