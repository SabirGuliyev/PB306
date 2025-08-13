using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExample.Interface
{
    internal interface ICodeAcademy
    {
        public string CodeEmail { get; set; }
        public string GenerateEmail();
    }
}
