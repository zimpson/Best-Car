using Project1.Domain.Enities;
using System.ComponentModel.DataAnnotations;

namespace Project1.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Назва сторінки (заголовок)")]
        public override string Title { get; set; } = "Информаційна сторінка";

        [Display(Name = "Наповнення сторінки")]
        public override string Text { get; set; } = "Наповнення заповнюється адміністратором";
    }
}
