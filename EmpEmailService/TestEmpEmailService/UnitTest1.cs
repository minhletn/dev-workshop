using System;
using EmpEmailService;
using EmpEmailService.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace TestEmpEmailService {
	[TestClass]
	public class UnitTest1 {
		[TestMethod]
		public void TestEmployeeEmailService() {
			//create an instance of employee email service
			var employeeEmailService = new EmployeeEmailService();

			//mock employee data, file creator and email services
			var mockEmployeeDataService = new Mock<IEmployeeDataService>();
			mockEmployeeDataService.Setup(x => x.GetEmployeeData(1)).Returns(new Employee());
			employeeEmailService.EmployeeDataService = mockEmployeeDataService.Object;

			var mockEmployeeFileCreator = new Mock<IEmployeeFileCreator>();
			mockEmployeeFileCreator.Setup(x => x.CreateFile(It.IsAny<Employee>())).Returns("http://allocatefileshare.com/testfile.pdf");
			employeeEmailService.EmployeeFileCreator = mockEmployeeFileCreator.Object;

			var mockEmailSender = new Mock<IEmailSender>();
			mockEmailSender.Setup(x => x.SendEmail("http://allocatefileshare.com/testfile.pdf", "test@allocatesoftware.com")).Returns(true);
			employeeEmailService.EmailSender = mockEmailSender.Object;

			Assert.AreEqual(true, employeeEmailService.SendEmployeeEmail(1, "test@allocatesoftware.com"));
		}
	}
}
