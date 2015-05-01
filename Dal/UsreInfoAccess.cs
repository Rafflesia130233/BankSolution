using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Entity;


namespace Dal
{
    public class UsreInfoAccess
    {
        User obj_save = new User();
        #region saveUserInfo

        public bool saveUserInfo(User Uobj)
        {
            try
            {
              
                StreamWriter write = new StreamWriter("E:\\All file for project\\BankNew.txt", true);
                String information = Uobj.account_number + ";"+
                    Uobj.name + ";" + Uobj.age + ";" + Uobj.gender + 
                    ";"+Uobj.email+";"+Uobj.contact+";" + Uobj.occupation + ";" + Uobj.address
                    + ";" + Uobj.bank_branch+ ";" + Uobj.bank_balance;
             
                write.WriteLine(information);

                write.Close();

                return true;
            }
            catch (Exception e)
            {
                
                return false;
            }
        }

        #endregion

        #region SearceForUodate
        
        
        public string[] SearceForUpdate(String Acnumber)
        {
            StreamReader read = new StreamReader("E:\\All file for project\\BankNew.txt");
           String Check;
           string[] array;
           while ((Check = read.ReadLine()) != null)
           {
               array = Check.Split(';');
              
               if(array[0].Equals(Acnumber))
               {
                   read.Close();
                   return array;
               }

           }
           
           return null;
        }
        #endregion


        #region Searce
        
        public bool Searce(String acc)
        {
            StreamReader read = new StreamReader("E:\\All file for project\\BankNew.txt");
            String Check;
            string[] array;
            while ((Check = read.ReadLine()) != null)
            {
                array = Check.Split(';');

                if (array[0].Equals(acc))
                {
                    read.Close();
                    return true;
                }

            }
            read.Close();
            return false ;

        }

        #endregion

        #region Save Updated

        public User saveUpdatedInfo(String Uobj)
        {
            //try
            //{

                string[] array;
                array = Uobj.Split(';');
                //StreamReader readd = new StreamReader("E:\\All file for project\\BankNew.txt");
                
                obj_save.account_number= array[0];
                //obj.txtAccount.Enabled = false;
                obj_save.name = array[1];
                obj_save.age = array[2];
                obj_save.gender = array[3];
                obj_save.email = array[4];
                obj_save.contact = array[5];
                obj_save.occupation = array[6];
                obj_save.address = array[7];
                obj_save.bank_branch = array[8];
                obj_save.bank_balance = array[9];

                return obj_save;
                //return array;
            //}
            //catch (Exception e)
            //{

               // return null;
           // }
        }

        #endregion
      
    }
}
