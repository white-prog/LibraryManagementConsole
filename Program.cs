using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementConsole
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Welcome to Library Management");
            Console.WriteLine("-----------------------------");

        
            Admin admin1 = new Admin();
            admin1.username = "jhon";
            admin1.password = "123456";
            Console.Write("Enter username: ");
            string name = Console.ReadLine();
            Console.Write("Enter Password: ");
            string pass = Console.ReadLine();
            if (admin1.username.Equals(name) && admin1.password.Equals(pass)){
                Library library1 = new Library();
                //write code for a condition to choose get name or add name
            
                Console.Write("Enter 'X' to exit: ");
                string exit = Console.ReadLine();
                    
                Console.Write("Member name to add: ");
                string name_of = Console.ReadLine();

                Console.Write("Add book name taken: ");
                string book = Console.ReadLine();
                library1.add_member(name_of,book);
            
        
                library1.get_member();
            
            }else{
                Console.WriteLine("Authentication failed..");
            }
        
            


        }
    }
}


public class Admin{
    public string username{get;set;}
    public string password{get;set;}

}
public class Person{
    public string name{get;set;}
    public string book_name{get;set;}
    


}
//code library class
public class Library{
    //Substitute string with Person details object data type

    public List<Person> Members {get;set;}

    public Library(){
        Members = new List<Person>();
    }

    public void add_member(string nm,string book_nm){
        Person member = new Person();
        member.name = nm;
        member.book_name = book_nm;
        Members.Add(member);
        Console.WriteLine($"Member {member.name} added successfully");
    } 
    public void get_member(){
        Console.WriteLine("Members : ");
        foreach(Person member in Members){
            Console.WriteLine($"Name :  {member.name}");
            Console.WriteLine($"Book : {member.book_name}");
        }
    }
    

}
