using System.ComponentModel.DataAnnotations;

namespace Lesson24
{
    public class StudentGroup
    {
        [Required(ErrorMessage = "Назва групи є обов'язковим полем.")]
        [StringLength(5, MinimumLength = 2, ErrorMessage = "Назва групи повинна складатися з 2-5 символів.")]
        [RegularExpression(@"^[A-Za-z]{3}-\d{2}$", ErrorMessage = "Неправильний формат назви групи. Має бути: три літери - дві цифри")]
        public string Name {get;set;}
        [Range(1, 6, ErrorMessage = "Поле курс повинно бути додатнім числом менше за 7.")]
        public int Course { get; set; }
    }
}
