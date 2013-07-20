using System;
using System.IO;
using System.Xml.Serialization;

namespace RegistrationSystem
{
	public class User
	{

	}
	public class CreateDatabase
	{
		XmlSerializer XMLW = new XmlSerializer(typeof(CreateUser));
		FileStream File = File.OpenWrite ("data.xml");
		
	}
	[Serializable()]
	public class CreateUser
	{
		string Username;
		string Password;
		public CreateUser(string Username, string Password)
		{
			this.Username = Username;
			this.Password = Password;
		}
	}
	[Serializable()]
	public class UserLogin
	{

	}
}


