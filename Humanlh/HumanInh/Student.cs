using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanInh
{
	internal class Student : Human
	{
		string qualification;
		bool isIntern;
		int totalGrade;
		int stHours;


		public Student()
		{
			//empry constructor
		}

		public Student(string qualification, bool isIntern, int totalGrade ) : base( stId,  stName, agest, status, job)
		{
			this.qualification = qualification;
			this.isIntern = isIntern;
			this.totalGrade = totalGrade;
			
			//int stId, string stName, int agest, bool status, bool job
		}

	}
}
