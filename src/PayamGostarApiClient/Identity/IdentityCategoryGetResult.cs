﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Identity
{
	public class IdentityCategoryGetResult
	{
		public Guid IdentityId { get; set; }

		public Guid Id { get; set; }

		public string Name { get; set; }

		public string Key { get; set; }

		public string Type { get; set; }
	}
}
