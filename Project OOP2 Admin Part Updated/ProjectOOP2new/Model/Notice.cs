using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP2new.Model
{
    class Notice
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string notice;

        public string Notices
        {
            get { return notice; }
            set { notice = value; }
        }
        private string date;

        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        private string ntcsubject;

        public string NtcSubject
        {
            get { return ntcsubject; }
            set { ntcsubject = value; }
        }


    }
}
