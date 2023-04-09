
	public class Student
	{
        public string Name;
        public string SurName;
        public string Group;
        public int Point;
        public bool isGraduate;

		

		public Student(string Name1, string Surname1, string Group1, int Point1, bool isGraduate1)
		{
			this.Name = Name1;
			this.SurName = Surname1;
			this.Group = Group1;
			this.Point = Point1;
			this.isGraduate = isGraduate1;
		}

		public void GetFullName()
		{
			Console.WriteLine($"{this.Name},{this.SurName}");
		}

		public void GetFullInfo()
			{

			Console.WriteLine($"{this.Name},{this.SurName}, {this.Group}, {this.Point}");

			if (this.isGraduate==true)
			{
				Console.WriteLine("Mezun oldunuz");
			}
			else
			{
					Console.WriteLine("mezun ola bilmediniz");
				if (Point>80)
				{
					Console.WriteLine("Amma ikinci imtahana gire biersiniz");
				}
				else
				{
				Console.WriteLine("qaqa basin burax");
				}

			}

		}
		//YAZMAQ ISTEDIM AMA BACARMADIM


		//string BackPoint( );
		
		//public string BackPoint(string input)
		//{
		//	string Point = input;
		//	if (input>80)
		//	{
		//	Console.WriteLine("Imtahana Daxil ola bilersiniz");

		//	}
		//	else
		//	{
		//	Console.WriteLine("Daxil ola bilmersiniz");

		//	}
		//	return input;



		//}
		

	}


