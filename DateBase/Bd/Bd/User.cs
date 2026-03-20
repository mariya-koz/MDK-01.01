using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bd
{
    class User
    {
        [DisplayName("Логин")]
        public string Login { get; set; }
        [DisplayName("Имя")]
        public string Name { get; set; }
        [DisplayName("Пароль")]
        public string Password { get; set; }
        [DisplayName("Фамилия")]
        public string Last_name { get; set; }
        [DisplayName("Телефон")]
        public string Phone { get; set; }
        [DisplayName("Почта")]
        public string EMail { get; set; }
    }
}
