using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Library.Models
{
    public class UserModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public bool OP { get; set; }
        public bool RT { get; set; }
        public bool CB { get; set; }
        public bool Pack { get; set; }
        public bool FirstAider { get; set; }
        public bool FireWarden { get; set; }
    }
}
