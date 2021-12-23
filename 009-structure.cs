using System;

namespace StructureExample
{

	struct Contacts
	{
		public string f_name;
		public string l_name;
		public int tel;
		public string email;
	};

	class Program
	{
		static void Main(string[] args)
		{
			getContactInfo();
		}
		
		static void getContactInfo()
		{
			Contacts contact_1;
		
			// Getting User Inputs...
			Console.WriteLine("Enter Your Information to save Contact");
	
			Console.Write("Enter Your First Name: ");
			contact_1.f_name = Console.ReadLine();

			Console.Write("Enter Your Last Name: ");
			contact_1.l_name = Console.ReadLine();
	
			Console.Write("Enter Your Email: ");
			contact_1.email = Console.ReadLine();
	
			Console.Write("Enter Your Telephone Number: ");
			while(!int.TryParse(Console.ReadLine(), out contact_1.tel));

			Console.WriteLine("\n++++++++++++++++++++++++++++\n");
			Console.WriteLine($"Names : {contact_1.l_name}, {contact_1.f_name}");
			Console.WriteLine($"Tel: {contact_1.tel}");
			Console.WriteLine($"Email :{contact_1.email}");
			Console.WriteLine("\n++++++++++++++++++++++++++++\n");
		}
	}
}
