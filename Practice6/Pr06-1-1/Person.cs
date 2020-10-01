using System;

public class Person
{
	private string Name;
	private string Surname;
	private DateTime Datatime;
	public string name
	{
		get {
			return this.Name;
		}
		set {
			this.Name=value;
		}
	}
	public string surname
	{
		get {
			return this.Surname;
		}
		set {
			this.Surname = value;
		}
	}
	public DateTime datatime
	{
		get {
			return this.Datatime;
		}
		set {
			this.Datatime = value;
		}
	}
	public int yearDate
	{
		get {
			return this.Datatime.Year;
		}
		set {
			this.Datatime = new DateTime(value, Datatime.Month, Datatime.Day);
		}
	}
	public Person(string Name, string Surname, DateTime Datatime)
	{
		name = Name;
		surname = Surname;
		datatime = Datatime;
	}
	public Person()
	{
		name = "";
		surname = "";
		datatime = new DateTime(0,0,0);
	}
	public override string ToString()
	{
		return $"{name} {surname} рожденный {datatime.Day}.{datatime.Month}.{datatime.Year}";
	}
	public virtual string ToShortString()
	{
		return $"{name} {surname}";
	}

}
