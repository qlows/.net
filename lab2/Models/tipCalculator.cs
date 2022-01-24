using System.ComponentModel.DataAnnotations;

namespace lab2.Models
{
    public class tipCalculator
    {
       [Required(ErrorMessage = "Please enter a value for the cost of the meal")]
       [Range(0.0, 1000.0, ErrorMessage = "Cost of the meal must be greater than $0, and less or equal to $1000.")]
        public double? mealCost { get; set; }

        public double calculateTips(double precent)
        {
            if (mealCost.HasValue)
            {
                var tip = mealCost.Value * precent;
                return tip;
            }
            else
            {
                return 0.0;
            }
        }
    }
}
