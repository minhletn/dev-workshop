using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpEmailService {
	public interface IEmployeeEmailService {

		bool SendEmployeeEmail(int empId, string email);

	}
}
