using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BankOnNet6.Models
{
    [Index("CardNumber", IsUnique = true)]
    [Index("Username", IsUnique = true)]
    public class User
    {
        [Key]
        public int Id { get; set; } = 0;
        [StringLength(30), Required]
        public string Firstname { get; set; } = string.Empty;
        [StringLength(30), Required]
        public string Lastname { get; set; } = string.Empty;



        [MinLength(16), MaxLength(16), Required]
        public string CardNumber { get; set; } = String.Empty;
        [MinLength(6), MaxLength(6), Required]
        public string Pin { get; set; } = String.Empty;
        [Precision(14,2)]
        public decimal? Checking { get; set; } = decimal.Zero;
        [Precision(14,2)]
        public decimal? Saving { get; set; } = decimal.Zero;
        [Precision(14, 2), Required]
        public decimal Total { get; set; } = decimal.Zero;


        [StringLength(30), Required]
        public string Username { get; set; } = string.Empty;
        [StringLength(30), Required]
        public string Password { get; set; } = string.Empty;

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
