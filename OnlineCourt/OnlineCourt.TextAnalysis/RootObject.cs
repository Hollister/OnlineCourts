using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourt.TextAnalysis
{
    public class RootObject
    {
        public List<Document> documents { get; set; }
        public List<object> errors { get; set; }
    }
}
