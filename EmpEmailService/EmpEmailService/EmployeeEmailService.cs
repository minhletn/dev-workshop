using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpEmailService.Entity;

namespace EmpEmailService {
	public class EmployeeEmailService: IEmployeeEmailService {

		public IEmployeeDataService EmployeeDataService { get; set; }
		public IEmployeeFileCreator EmployeeFileCreator { get; set; }
		public IEmailSender EmailSender { get; set; }

		public bool SendEmployeeEmail(int empId, string email) {
			//validate 

			Employee employee = EmployeeDataService.GetEmployeeData(empId);

			string fileLocation = EmployeeFileCreator.CreateFile(employee);

			return EmailSender.SendEmail(fileLocation, email);
		}

	}
}
