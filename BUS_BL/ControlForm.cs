using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalThreeLayer;
using System.Windows;
using CalThreeLayer.DAL_DataAL;
namespace CalThreeLayer.BUS_BL
{
    public class controlForm
    {
        List<Person> admin = new List<Person>();
        ConnectToSql ass = new ConnectToSql();
        public int LoginfromFORMLOGIN(string EmAil, string PassWord)
        {
            int checkControl = 0;           
             Person ta = new Person();
             ta.Email = EmAil;
             ta.Password = PassWord;
             admin.Add(ta);           
            checkControl = ass.SELECT(ta);
            if (checkControl == 1) return 1;
            else return 0;
        }
        public int RegisterfromFORMLOGIN(string EmAil, string PassWord)
        {
            int checkControl = 0;
            Person ta = new Person();
            ta.Email = EmAil;
            ta.Password = PassWord;
            admin.Add(ta);          
            checkControl = ass.REGISTER(ta);
            if (checkControl == 1) return 1;
            else return 0;
        }
        public int ChangefromFORMLOGIN(string EmAil, string PassWord)
        {
            int checkControl = 0;
            Person ta = new Person();
            ta.Email = EmAil;
            ta.Password = PassWord;
            admin.Add(ta);
            checkControl = ass.CHANGE_PASSWORD(ta);
            if (checkControl == 1) return 1;
            else return 0;
        }
    }
}
