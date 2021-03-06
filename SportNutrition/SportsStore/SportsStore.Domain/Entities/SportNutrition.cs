﻿using System.ComponentModel.DataAnnotations;
using System.Web;

namespace SportsStore.Domain.Entities
{
    public class SportNutrition
    {
        [ScaffoldColumn(false)]
        public int SportNutritionId { get; set; }

        [Required(ErrorMessage = "Please enter a product name")]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please enter a description")]
        public string Description { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a positive price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Please specify a category")]
        public string Category { get; set; }

        public string ImageName { get; set; }
    }
}