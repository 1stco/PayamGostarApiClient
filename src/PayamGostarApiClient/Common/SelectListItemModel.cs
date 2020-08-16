using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Common
{
    public class SelectListItemModel
    {
        public string name { get; set; }

        public string value { get; set; }

        public bool selected { get; set; }

        public bool disabled { get; set; }
    }
}
