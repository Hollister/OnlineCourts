using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;

namespace OnlineCourt.TextAnalysis
{
    public class TextAnalysis
    {
        readonly string _baseUrl;
        readonly string _accountKey;

        public TextAnalysis()
        {
            _baseUrl = "https://westus.api.cognitive.microsoft.com/text/analytics/v2.0/";
            _accountKey = "a064f0b419d34961a228375544873b17";
        }

        public string DetectLanguages(string text, out decimal confidence)
        {
            var queryString = HttpUtility.ParseQueryString(string.Empty);
            queryString["numberOfLanguagesToDetect"] = "1".ToString(CultureInfo.InvariantCulture);
            var uriLang = "languages" + "?" + queryString;

            RootObject langaugeRO = PerformTextAnalysis(text, uriLang);

            confidence = Convert.ToDecimal(langaugeRO.documents[0].detectedLanguages[0].score) * 100;
            return langaugeRO.documents[0].detectedLanguages[0].name;
        }

        public string DetectKeyPhrases(string text)
        {
            RootObject keyPhraseRO = PerformTextAnalysis(text, "keyPhrases");

            string keyPhrasesString = string.Empty;

            for (int i = 0; i < keyPhraseRO.documents[0].keyPhrases.Count; i++)
            {
                if (keyPhraseRO.documents[0].keyPhrases[i] != "")
                {
                    keyPhrasesString += keyPhraseRO.documents[0].keyPhrases[i];
                    if (i + 1 != keyPhraseRO.documents[0].keyPhrases.Count) { keyPhrasesString += ", "; }
                }
            }

            return keyPhrasesString;
        }

        private RootObject PerformTextAnalysis(string text, string resourcePath)
        {
            TextAnalytic docDetails = new TextAnalytic();
            docDetails.id = "1";
            docDetails.text = Regex.Replace(text, @"<(.|\n)*?>", @"");

            HttpWebRequest newRequest = (HttpWebRequest)WebRequest.Create(_baseUrl + resourcePath);
            newRequest.Method = "POST";

            string documentToJson = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(docDetails);

            byte[] byteData = Encoding.UTF8.GetBytes("{\"documents\":[" + documentToJson + "]}");
            newRequest.ContentLength = byteData.Length;
            newRequest.AutomaticDecompression = DecompressionMethods.GZip;
            newRequest.Headers.Add("Ocp-Apim-Subscription-Key", _accountKey);
            newRequest.GetRequestStream().Write(byteData, 0, byteData.Length);

            HttpWebResponse newResponse = (HttpWebResponse)newRequest.GetResponse();
            Stream dataStream = newResponse.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            string responseFromServer = reader.ReadToEnd();
            JavaScriptSerializer oJS = new JavaScriptSerializer();
            RootObject oRootObject = new RootObject();
            oRootObject = oJS.Deserialize<RootObject>(responseFromServer);
            return oRootObject;
        }
    }
}
