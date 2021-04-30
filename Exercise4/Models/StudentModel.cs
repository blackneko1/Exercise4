using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Exercise4.Models
{
    public class StudentModel
    {
        public int ID { get; set; }
        [RegularExpression(@"([1-9][0-9]*)", ErrorMessage = "Invalid must be a number"), Required, StringLength(8)]
        public string Idnumber { get; set; }
        [RegularExpression(@"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,}$", ErrorMessage = "Name Invalid"), Required, StringLength(50)]
        public string Name { get; set; }
        [RegularExpression(@"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,}$", ErrorMessage = "Course Invalid"), Required, StringLength(50)]
        public string Course { get; set; }
        [RegularExpression(@"^[0-9A-Za-z ]+$", ErrorMessage = "Example 1st year, 2nd year, 3rd year, 4th year, 5th year."), Required]
        public string Year { get; set; }
        [RegularExpression(@"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,}$", ErrorMessage = "Color Invalid"), Required, StringLength(50)]
        public string TshirtColor { get; set; }
        [RegularExpression(@"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,}$", ErrorMessage = "Size Invalid Example Medium, Large, Small"), Required, StringLength(50)]
        public string Size { get; set; }
        [RegularExpression(@"([1-9][0-9]*)", ErrorMessage = "Invalid must be a number"), Required]
        public string AmountPaid { get; set; }
    }
}
