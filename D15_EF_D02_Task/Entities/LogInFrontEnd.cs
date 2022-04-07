using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations ;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D15_EF_D02_Task.Entities
{
    public class LogInFrontEnd
    {
        [Key]
        [MaxLength(50)]
        [Required]
        public string UserName { get; set; }

        [MaxLength(50)]
        [Required]
        public string Password { get; set; }

    }
}
