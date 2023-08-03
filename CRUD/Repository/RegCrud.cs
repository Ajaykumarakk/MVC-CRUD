using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegLibrary.Model;
using Dapper;
using System.Data.SqlClient;

namespace CRUD.Repository
{
    public class RegCrud
    {
        public readonly string Connectionstring;

        public RegCrud()
        {
            Connectionstring = $"Data Source = ASUS5-AK; Initial Catalog = RegisterId; Integrated Security = True";
        }

        public RegModel Model()
        {
            RegModel m = new RegModel();
            Console.WriteLine("Enter the ID");
            m.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name");
            m.Fullname = Console.ReadLine();
            Console.WriteLine("Enter the mail ID");
            m.Email = Console.ReadLine();
            Console.WriteLine("Enter the Mobile Number");
            m.MobileNum=Convert.ToInt32(Console.ReadLine()) ;
            Console.WriteLine("Enter the Gender");
            m.Gender=Console.ReadLine();

            return m;
        }

        public void Insert(RegModel a)
        {
            try
            {
                SqlConnection con = new SqlConnection(Connectionstring);

                con.Open();
                con.Execute($"Exec IDInsert '{a.Fullname}','{a.Email}','{a.MobileNum}','{a.Gender}'");
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<RegModel> Select(int Id)
        {
            SqlConnection con = new SqlConnection(Connectionstring);
            List<RegModel> res = new List<RegModel>();

            con.Open();
            res= con.Query<RegModel>($"Exec IDSelect {Id}").ToList();
            con.Close();

           return res;
        }

        public List<RegModel> Select()
        {
            SqlConnection con = new SqlConnection(Connectionstring);
            List<RegModel> res = new List<RegModel>();

            con.Open();
            res = con.Query<RegModel>("select * from RegID").ToList();
            con.Close();

            foreach(var d in res)
            {
                Console.WriteLine($"Id {d.Id},Fullname {d.Fullname},Email {d.Email},Mobileno {d.MobileNum},Gender {d.Gender}");
            }

            return res;
        }

        public void Update(RegModel s)
        {
            try
            {
                SqlConnection con = new SqlConnection(Connectionstring);

                con.Open();
                con.Execute($"Exec IDUpdate '{s.Id}','{s.Fullname}','{s.Email}','{s.MobileNum}','{s.Gender}'");
                con.Close();
            }
            catch (Exception ex) { throw ex; }  
        }

        

        public void Delete(int Id)
        {
            SqlConnection con = new SqlConnection(Connectionstring);

            con.Open();
            con.Execute($"Exec IDDelete '{Id}'");
            con.Close();
        }

        public void Delete()
        {
            SqlConnection con = new SqlConnection(Connectionstring);
            Console.WriteLine("Enter the delete ID");
            var Id =Convert.ToInt32(Console.ReadLine());
            con.Open();
            con.Execute($"Exec IDDelete '{Id}'");
            con.Close();
        }

    }

   
}
