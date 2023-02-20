using Kanaban501app;
using System;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;

public class Activity
{
	public Status Status { get; set; }

	public string Name { get; set; }

	public string Resources { get; set; }

	public DateTime CompleteBy { get; set; }

	public string Priority { get; set; }

	public Activity(string name, Status status, string resources, DateTime completeby, string priority)
	{
		Name = name;
		Status = status;
		Resources = resources;
		CompleteBy = completeby;
		Priority = priority;
	}

    public override string ToString()
    {
		return Name;
    }
}
