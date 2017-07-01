using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourt.TextAnalysis
{
    public class Document
    {
        public List<string> keyPhrases { get; set; }
        public string id { get; set; }
        public string score { get; set; }
        public List<DetectedLanguages> detectedLanguages { get; set; }
    }
}
