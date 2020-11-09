using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SallyServer.Models
{
    public class Question
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        [Required]
        public string Text { get; set; }
        public string Answer { get; set; }
    }
}
