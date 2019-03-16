using System;

namespace WeatherAlerts
{
	class Client
	{
		public static void Main(string[] args) {

			DecisionEngine engine = new DecisionEngine();

			User joe = new Student("Joe");
			Service s1 = new EmailService("", joe);
			engine.Register(s1);
			Service s2 = new SMSService("", joe);
			engine.Register(s2);

			User anthony = new Staff("Anthony");
			Service s3 = new EmailService("", anthony);
			engine.Register(s3);
			Service s4 = new PhoneService("", anthony);
			engine.Register(s4);

			User josh = new Faculty("Josh");
			Service s5 = new SMSService("", josh);
			engine.Register(s5);
			Console.WriteLine();

			string message = "School Closed!";

			engine.Notify(message);
			Console.WriteLine();

			engine.Unregister(s2);
			engine.Unregister(s3);
			Console.WriteLine();

			message = "Classses Delayed until 10:00 pm.";

			engine.Notify(message);
			Console.WriteLine();
		}
	}
}
