using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoManager_2._0
{
    //Класс для распределения юзеров по ролям доступа
    class UsersRole
    {
        public static List<Users> UserManager { get; set; }
        public static List<Users> UserSaler { get; set; }
        public static List<Users> UserOwner { get; set; }
        public static List<Role>Roles{ get; set; }
        
        
    }
}
