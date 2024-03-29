﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route.C4.G02.DAL.Models
{
    public class Department : ModelBase
    {
        //public int Id { get; set; }
        [Required(ErrorMessage ="Code Is Required Ya Ofa !!")]
        public int Code { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Date Of Creation")]
        public DateTime DateOfCreation { get; set; }
    }
}
