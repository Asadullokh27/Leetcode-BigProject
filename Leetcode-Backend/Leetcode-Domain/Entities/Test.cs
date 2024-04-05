using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Domain.Entities
{
    public class Test
    {
        public int Id { get; set; }
        public Problem ProblemId { get; set; }
        public string Input { get; set; }
        public string Output { get; set; }

    }
}
