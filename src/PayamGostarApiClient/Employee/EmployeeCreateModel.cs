﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Employee
{
	public class EmployeeCreateModel
	{
        public Guid? OrganizationId { get; set; }

        public Guid? PersonId { get; set; }

        public string Profession { get; set; }

        public string JobType { get; set; }

        public string Office { get; set; }

        public string Department { get; set; }
    }
}
