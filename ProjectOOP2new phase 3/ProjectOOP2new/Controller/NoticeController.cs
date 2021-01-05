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
        public static bool AddNotice(string a, string b)
        {
            bool x = Notices.AddNoticeMdl(a, b);
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
