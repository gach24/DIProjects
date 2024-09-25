namespace PagesDemo
{
	public class Alumno
	{
		private string firstName;

		public string FirstName
		{
			get
			{
				return firstName;
			}
			set
			{
				if (value != null) 
					firstName = value;
			}
		}

		public Alumno()
		{
			FirstName = "Juan";
			string valor = FirstName;
		}
    }
}
