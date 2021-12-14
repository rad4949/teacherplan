﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using Plan.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Plan.ViewModels
{
    public class EducationalActivitiesViewModel
    {
        [BindNever]
        public int Id { get; set; }

        [Display(Name = "Назва. Кількісна характеристика")]
        [StringLength(60, MinimumLength = 2, ErrorMessage = "Введіть вид роботи не більше 50 і не менше 2 символів ")]
        [Required(ErrorMessage = "Введіть назву не більше 50 і не менше 2 символів ")]
        public string NameEducationalActivities { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Термін виконання")]
        public DateTime DateSuccess { get; set; }

        public bool Correct { get; set; }
    }

    public class ListEducationalActivitiesViewModel
    {
        public List<EducationalActivities> educationalActivities { get; set; }
        public AllUserViewModel userModel { get; set; }
    }
}