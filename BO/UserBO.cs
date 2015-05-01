using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using Dal;

namespace BO
{
    public class UserBO
    {
            
            UsreInfoAccess objUser = new UsreInfoAccess();
            int a;
        //--------------------------------

            public bool saveUserInfo(User obj)
            {
                return objUser.saveUserInfo(obj);
            }
       //--------------------------------

            public User saveUpdatedInfo(String obj)
            {
                return objUser.saveUpdatedInfo(obj);
            }
      //--------------------------------

            public bool Searce(String obj)
            {
                return objUser.Searce(obj);
            }
     //--------------------------------

            public string[] SearceForUpdate(String Acnum)
            {
                return objUser.SearceForUpdate(Acnum);
            }
    //--------------------------------

            public int Deposite(int a,int b)
            {
                return a + b;
            }


            public int Withdraw(int a, int b)
            {
                return a - b;
            }


            public int Interest(int a)
            {
               
                a = a + Convert.ToInt32(a * (10 / 100));

                return a;
            }
    }
}
