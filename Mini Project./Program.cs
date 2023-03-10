using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
//Mini Project 
// Name : Shahul Singh(Shillong)
namespace ado
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;

        static void Main(string[] args)
        {
            string ch;
            int num;
            //SelectData();
            //Console.Read();

            do
            {
               //int num;
                Console.WriteLine("Menu Driven program For Employee Working in a company");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("*******************************************************");
                Console.WriteLine("\t 1. Display the details of   employee");
                Console.WriteLine("\t 2. Insert  the detail of  employee");
                Console.WriteLine("\t 3. Update the detail of  employee");
                Console.WriteLine("\t 4. Delete the detail of  employee");
                Console.WriteLine("\t 5. Exit");
                Console.WriteLine("*******************************************************");
                Console.WriteLine("-------------------------------------------------------");
                Console.Write("Enter Your Choice \t");
                
                num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        //Console.WriteLine("Details");
                        SelectData();
                        break;

                    case 2:
                        //Console.WriteLine("Inserttion");
                        InsertData();
                        break;

                    case 3:
                       // Console.WriteLine("update");
                        Updatedata();
                        break;

                    case 4:
                        DeleteData();
                       // Console.WriteLine("Delete");
                        break;

                    default:
                        Console.WriteLine("invalid");
                        break;
                }
            }
            while (num != 5);

        Environment.Exit(0);
        Console.ReadKey();
        }


        public static SqlConnection getConnection()
        {
            con = new SqlConnection(" data source = LAPTOP-UT42LIIT; Initial Catalog = mydata ; integrated security = true;");
            con.Open();
            return con;        
        }

        public static void SelectData()
        {
            try
            {
                con = getConnection();
                cmd = new SqlCommand("select * from employee", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                   // Console.WriteLine(dr[0] + " |" + dr[1] + "| " + dr[2]);
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("Employee Id : {0}", dr[0]);
                    Console.WriteLine("Employee first : {0}", dr[1]);
                    Console.WriteLine("Employee last : {0}", dr[2]);
                    Console.WriteLine("city: {0}", dr[3]);
                    Console.WriteLine("doj: {0}", dr[4]);
                    Console.WriteLine("deptid: {0} \n\n", dr[5]);
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine("Some Error Occured.. Try after sometime");
                Console.WriteLine(se.Message);
            }
        }


        public static void InsertData()

        {
            con = getConnection();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("\t Enter Details of New Employee");
            Console.Write("Enter Employee ID: \t");
            int empid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter First Name : \t ");
            string firstname = Console.ReadLine();
            Console.Write("Enter Last Name :\t ");
            string lastname = Console.ReadLine();
            Console.Write("Enter City Name :\t ");
            string city = Console.ReadLine();
            Console.Write("Enter Date of joinging Name :\t ");
            DateTime doj = Convert.ToDateTime(  Console.ReadLine());
            Console.Write("Enter Department ID :\t ");
            int deptid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------------");

            cmd = new SqlCommand("insert into employee values (@eid, @efn, @eln, @ecity, @edoj, @edid) ", con);

            cmd.Parameters.AddWithValue("@eid", empid);
            cmd.Parameters.AddWithValue("@efn", firstname);
            cmd.Parameters.AddWithValue("@eln", lastname);
            cmd.Parameters.AddWithValue("@ecity", city);
            cmd.Parameters.AddWithValue("@edoj", doj);
            cmd.Parameters.AddWithValue("@edid", deptid);
            

           // cmd.Connection = con;
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                Console.WriteLine("Record Inserted Successfully.");
            }
            else
                Console.WriteLine("Not Inserted..");
        }



        public static void Updatedata()
        {
            con = getConnection();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Change Department No Of Employee");
            Console.Write("Enter Employee id : \t");
            int empid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter new Dept no :\t");
            int edno = Convert.ToInt32(Console.ReadLine());

            SqlCommand cmd1 = new SqlCommand("Select * from employee where empid=@ecode");
            cmd1.Parameters.AddWithValue("@ecode", empid);
            cmd1.Connection = con;

            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                for (int i = 0; i < dr1.FieldCount; i++)
                {
                    Console.WriteLine(dr1[i]);
                }
            }
            con.Close();
            Console.WriteLine("Are you sure want to update ? Y/N");
            string answer = Console.ReadLine();
            Console.WriteLine("-------------------------------------------------------");
            if (answer == "y" || answer == "Y")
            {
                cmd = new SqlCommand("Update employee SET deptid = @edno where empid=@ecode", con);
                cmd.Parameters.AddWithValue("@ecode", empid);
                cmd.Parameters.AddWithValue("@edno", edno);
                con.Open(); int rw = cmd.ExecuteNonQuery();
                if (rw > 0)
                {
                    Console.WriteLine("Updated Sucessfully.");
                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("New dept id :" + edno);
                }
                else
                    Console.WriteLine("Not Updated");
            }
        }


        public static void DeleteData()
        {
            con = getConnection();
            Console.WriteLine("-------------------------------------------------------");
            Console.Write("Enter Employee id Whose Data need to be Deleted : \t");
            int empid = Convert.ToInt32(Console.ReadLine());
            SqlCommand cmd1 = new SqlCommand("Select * from employee where empid=@ecode");
            cmd1.Parameters.AddWithValue("@ecode", empid);
            cmd1.Connection = con;

            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                for (int i = 0; i < dr1.FieldCount; i++)
                {
                    Console.WriteLine(dr1[i]);
                }
            }
            con.Close();
            Console.WriteLine("Are you sure to delete this employee ? Y/N");
            string answer = Console.ReadLine();
            if (answer == "y" || answer == "Y")
            {
                cmd = new SqlCommand("delete from employee where empid=@ecode", con);
                cmd.Parameters.AddWithValue("@ecode", empid);
                con.Open();
                int rw = Convert.ToInt32(cmd.ExecuteNonQuery());
                if (rw > 0)
                    Console.WriteLine("Record Deleted..");
                else
                    Console.WriteLine("Not deleted");

            }
        }



    }
}
