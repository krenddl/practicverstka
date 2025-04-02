using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verstkapracticwpf.Models
{
    public partial class Education
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Cvalification { get; set; }

        public string Special {  get; set; }
    }
}
