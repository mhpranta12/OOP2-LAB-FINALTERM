using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectOOP2new.Model;
using System.Collections;

namespace ProjectOOP2new.Controller
{
    class NoticeController
    {
        public static bool AddNotice(string a, string b , string c )
        {
            bool x = Notices.AddNoticeMdl(a, b , c);
            return x;
        }
        public static ArrayList ShowAllNotices()
        {
            ArrayList x = new ArrayList();
            x = Notices.GetAllNotices();
            return x;
        }
    }
}
