using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApi_EL.Entities
{
    [Table("Assignments")]
    public class Assignment
    {
        [Key]
        [Column(Order=1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(Order = 2)]
        public DateTime CreatedDate { get; set; } 
        [Required]
        [StringLength(500,MinimumLength =2,ErrorMessage =("Görev tanımı en az 2 en çok 500 karakter olabilir."))]
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
    }
}
