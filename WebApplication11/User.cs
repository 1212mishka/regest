using System.ComponentModel.DataAnnotations;

namespace WebApplication11
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Введите имя")]

        public string Name { get; set; } = ""; // имя пользователя
        [Range(1, 120, ErrorMessage = "Возраст должен быть от 1 до 120")]

        public int Age { get; set; }
    }
}
