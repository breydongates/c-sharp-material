<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
=======
﻿using System.ComponentModel.DataAnnotations;
>>>>>>> 7dbe01ff961239e92acc2db75a094b72305dbf9d

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
