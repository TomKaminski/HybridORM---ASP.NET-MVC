using System.ComponentModel.DataAnnotations;

namespace MvcEfRepoPatternExample.ViewModels
{
    public class AddReportViewModel
    {
        [Required(ErrorMessage = "Pole {0} jest wymagane"), Display(Name = "Imię")]
        [RegularExpression("[A-Ża-ż]*", ErrorMessage = "Pole {0} jest niepoprawne")]
        public string AuthorName { get; set; }

        [Required(ErrorMessage = "Pole {0} jest wymagane"), Display(Name = "Nazwisko")]
        [RegularExpression("[A-Ża-ż]*", ErrorMessage = "Pole {0} jest niepoprawne")]
        public string AuthorLastName { get; set; }

        [Required(ErrorMessage = "Pole {0} jest wymagane"),
         EmailAddress(ErrorMessage = "Podaj poprawny adres email"), Display(Name = "Email")]
        public string AuthorEmail { get; set; }

        [Display(Name = "Imię")]
        [RegularExpression("[A-Ża-ż]*", ErrorMessage = "Pole {0} jest niepoprawne")]
        public string CoAuthorName { get; set; }

        [Display(Name = "Nazwisko")]
        [RegularExpression("[A-Ża-ż]*", ErrorMessage = "Pole {0} jest niepoprawne")]
        public string CoAuthorLastName { get; set; }

        [Required(ErrorMessage = "Pole {0} jest wymagane"), Display(Name = "Imię")]
        [RegularExpression("[A-Ża-ż]*", ErrorMessage = "Pole {0} jest niepoprawne")]
        public string KeeperName { get; set; }

        [Required(ErrorMessage = "Pole {0} jest wymagane"), Display(Name = "Nazwisko")]
        [RegularExpression("[A-Ża-ż]*", ErrorMessage = "Pole {0} jest niepoprawne")]
        public string KeeperLastName { get; set; }

        [Required(ErrorMessage = "Pole {0} jest wymagane"), Display(Name = "Nazwa")]
        public string UniversityName { get; set; }

        [Required(ErrorMessage = "Pole {0} jest wymagane"), Display(Name = "Adres")]
        public string UniversityAddress { get; set; }

        [Required(ErrorMessage = "Pole {0} jest wymagane"), Display(Name = "Tytuł")]
        public string ReportTitle { get; set; }

        [Required(ErrorMessage = "Pole {0} jest wymagane")]
        [Display(Name = "Streszczenie")]
        [MinLength(50,ErrorMessage = "Streszczenie powinno zawierać minimum 50 znaków.")]
        public string ReportSummary { get; set; }
    }
}