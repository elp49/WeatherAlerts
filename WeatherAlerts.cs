using System;
using System.Collections.Generic;

namespace WeatherAlerts
{

	class ServiceNotifier
	{
		private List<Service> Services = new List<Service>();

		public void Attach(Service service) {
			if (!Services.Contains(service)) {
				Services.Add(service);
				Console.WriteLine("{0} ({1}): Successfully registered for {2}", service.GetUserName(), service.GetUserType(), service.GetServiceType());
			}
		}

		public void Detach(Service service) {
			if (Services.Contains(service)) {
				Services.Remove(service);
				Console.WriteLine("{0} ({1}): Successfully unregistered from {2}", service.GetUserName(), service.GetUserType(), service.GetServiceType());
			}
		}

		public void Notify(string message) {
			foreach (Service service in Services) {
				service.Update(message);
			}
		}
	}


	abstract class User
	{
		protected string Name;

		public User(string name = "\"Default User Name\"") {
			Name = name;
		}

		public string GetUserName() {
			return Name;
		}

		public abstract string GetUserType();
	}


	class Student : User
	{
		public Student(string name = "\"Default User Name\"") {
			Name = name;
		}

		public override string GetUserType() {
			return "Student";
		}
	}


	class Staff : User
	{
		public Staff(string name = "\"Default User Name\"") {
			Name = name;
		}

		public override string GetUserType() {
			return "Staff";
		}
	}


	class Faculty : User
	{
		public Faculty(string name = "\"Default User Name\"") {
			Name = name;
		}

		public override string GetUserType() {
			return "Faculty";
		}
	}


	abstract class Service
	{
		public User User;

		public string GetUserName() {
			try {
				return User.GetUserName();
			}

			catch (NullReferenceException) {
				return "\"Unknown User Name\"";
			}
		}

		public string GetUserType() {
			try {
				return User.GetUserType();
			}

			catch (NullReferenceException) {
				return "\"Unknown User Type\"";
			}
		}

		public abstract string GetServiceType();

		public abstract void Update(string message);
	}


	class EmailService : Service
	{
		private string Email;

		public EmailService(string email, User user = null) {
			Email = email;
			User = user;
		}

		public override string GetServiceType() {
			return "Email Service";
		}

		public override void Update(string message) {
			// connect to email service and send email to Email
			Console.WriteLine("{0} ({1}): Successfully received email notification, \"{2}\"", GetUserName(), GetUserType(), message);
		}
	}


	class PhoneService : Service
	{
		private string PhoneNumber;

		public PhoneService(string phoneNumber, User user = null) {
			PhoneNumber = phoneNumber;
			User = user;
		}

		public override string GetServiceType() {
			return "Phone Service";
		}

		public override void Update(string message) {
			// send voice recording to PhoneNumber
			Console.WriteLine("{0} ({1}): Successfully received voice notification, \"{2}\"", GetUserName(), GetUserType(), message);
		}
	}


	class SMSService : Service
	{
		private string PhoneNumber;

		public SMSService(string phoneNumber, User user = null) {
			PhoneNumber = phoneNumber;
			User = user;
		}

		public override string GetServiceType() {
			return "SMS Service";
		}

		public override void Update(string message) {
			// send SMS message to PhoneNumber
			Console.WriteLine("{0} ({1}): Successfully received SMS notification, \"{2}\"", GetUserName(), GetUserType(), message);
		}
	}


	class DecisionEngine
	{
		private static readonly ServiceNotifier Instance = new ServiceNotifier();

		static DecisionEngine() { }

		public static ServiceNotifier GetInstance {
			get {
				return Instance;
			}
		}


		public void Register(Service service) {
			Instance.Attach(service);
		}

		public void Unregister(Service service) {
			Instance.Detach(service);
		}

		public void Notify(string message) {
			Instance.Notify(message);
		}
	}

}