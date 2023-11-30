using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanInh
{
	
	internal class Human
	{
		public int ID;
		public string Name;
		public bool hasJob;
		public int age;
		public bool isMarried;

        public Human(int stId, string stName, int agest, bool status, bool job)
		{
			this.ID = stId;
			this.Name = stName;
			this.age = agest;
			this.isMarried = status;
			this.hasJob = job;
		}

		public void Describe()
		{

		}
	}
}
