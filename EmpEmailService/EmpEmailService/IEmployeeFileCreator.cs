using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpEmailService.Entity;

namespace EmpEmailService {
	public interface IEmployeeFileCreator {

		string CreateFile(Employee employee);

	}
}
