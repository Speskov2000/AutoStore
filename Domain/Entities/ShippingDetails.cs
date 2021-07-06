using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ShippingDetails
    {
        [Display(Name = "Имя")]
        [StringLength(50, ErrorMessage = "{0} должно содержать не более {1} символов.")]
        [Required(ErrorMessage = "Укажите ваше имя")]
        public string Name { get; set;}

        [Display(Name = "Первый адрес")]        
        [StringLength(70, ErrorMessage = "{0} должен содержать не более {1} символов.")]
        [Required(ErrorMessage = "Адрес доставки")]
        public string Line1 { get; set; }

        [Display(Name = "Второй адрес")]
        [StringLength(70, ErrorMessage = "{0} должен содержать не более {1} символов.")]        
        public string Line2 { get; set; }

        [Display(Name = "Третий адрес")]
        [StringLength(70, ErrorMessage = "{0} должен содержать не более {1} символов.")]        
        public string Line3 { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Мобильный номер")]        
        [Phone(ErrorMessage = "Введите корректный номер")]
        [StringLength(15, ErrorMessage = "{0} должен содержать не более {1} символов.")]
        [Required(ErrorMessage = "Укажите ваш номер телефона")]
        public string PhoneNuber { get; set; }

        [Display(Name = "Город")]        
        [StringLength(35, ErrorMessage = "{0} должен содержать не более {1} символов.")]
        [Required(ErrorMessage = "Укажите город")]
        public string City { get; set; }

        [Display(Name = "Страна")]        
        [StringLength(35, ErrorMessage = "{0} должна содержать не более {1} символов.")]
        [Required(ErrorMessage = "Укажите страну")]
        public string Country { get; set; }

       public bool GiftWrap { get; set; }

    }
}
