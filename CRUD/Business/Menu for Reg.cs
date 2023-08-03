using CRUD.Repository;
using RegLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace CRUD.Business
//{
//    public class MenuReg
//    {
//        public void Menu()
//        {
//            RegCrud obj = new RegCrud();
//            RegModel mod = new RegModel();
//            int n;

//            do
//            {
//                Console.WriteLine("choose the option");
//                Console.WriteLine("0.Exist");
//                Console.WriteLine("1.insert");
//                Console.WriteLine("2.select");
//                Console.WriteLine("3.Update");
//                Console.WriteLine("4.Delete");

//                n=Convert.ToInt16(Console.ReadLine());

//                switch (n)
//                {
//                    case 0: Console.WriteLine("Thank u");
//                        break;

//                    case 1: var mini = obj.Model();
//                        obj.Insert(mini);
//                        break;

//                    case 2: obj.Select();
//                        break;

//                    case 3: 
//                        obj.Update();
//                        break;

//                    case 4:
//                        obj.Delete();
//                        break;
//                }
//            }while(n!=0);


//        }
        
//    }
//}
