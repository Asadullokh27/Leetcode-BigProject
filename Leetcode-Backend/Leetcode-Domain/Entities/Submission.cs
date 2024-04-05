using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Domain.Entities
{
    public class Submission
    {
        public string Id { get; set; }
        public int UserId { get; set; }
        public int ProblemId { get; set; }
        public string Value { get; set; }
        public bool IsPassed { get; set; }
    }
}
