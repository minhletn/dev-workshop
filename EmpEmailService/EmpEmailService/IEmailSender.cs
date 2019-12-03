using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpEmailService {
	public interface IEmailSender {

		bool SendEmail(string fileLocation, string email);

	}
}
