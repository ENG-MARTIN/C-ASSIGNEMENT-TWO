using System;
using System.Collections;
using System.Collections.Generic;
namespace ASSIGNEMENT__2

{
    
    public delegate void StudentDetails(string a );
    internal class Program
    {
        private String studentAdress;
       
        public static void getStudentName(String name)
        {
           // return name;
        }
        public static void getStudentiD(int ID)
        {
            //return ID;
            Console.WriteLine("the id is: "+ID);
        }
        public String Adress
        {
            get { return studentAdress; }
        }
        static void Main(string[] args)

        {
            Program PR = new Program();
            string _name = "martin";
            int _ID = 003;
            string stID = Convert.ToString(_ID);
            StudentDetails sd = new StudentDetails(getStudentName);
            Console.WriteLine("Student name: "+_name);
            Console.WriteLine("His ID is: "+_ID);

            ///number two...............................
            PR.studentAdress = "KAMPALA";
            Console.WriteLine("His address is :"+PR.Adress);


            /// number three...................................................
            Dictionary<String,String> dic = new Dictionary<String,String>();
            dic.Add("Name: ",_name);
            dic.Add("ID: ",stID);
            dic.Add("Address:", PR.studentAdress);
            ICollection objCollect = dic.Keys;

            foreach (string k in objCollect)
            {
                Console.WriteLine(k +"\t" + dic[k]);

            }
            
        }
    }
}