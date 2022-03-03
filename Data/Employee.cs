using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDOperation.Data
{
    [Table("tblEmployees")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        [Required,Phone]
        public string Mobilenumber { get; set; }
    }
}
