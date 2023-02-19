using Kanaban501app;
using System;
using System.Security.Cryptography.X509Certificates;

public class Activity
{
	public Status Status { get; set; }

	public string Name { get; set; }

	public string Resources { get; set; }

	public DateTime CompleteBy { get; set; }

	public Activity(string name, Status status, string resources, DateTime completeby)
	{
		Name = name;
		Status = status;
		Resources = resources;
		CompleteBy = completeby;
	}

    public override string ToString()
    {
		return Name;
    }
}
