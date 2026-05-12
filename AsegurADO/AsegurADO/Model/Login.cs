using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsegurADO.Model
{
    public class Login
    {
        public int id_login { get; set; }
        public string username { get; set; }
        public string password_hash { get; set; }
        public DateTime last_access { get; set; }
        public int state_account { get; set; }
    }
}
