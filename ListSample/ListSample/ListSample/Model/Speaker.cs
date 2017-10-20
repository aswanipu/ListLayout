using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSample.Model
{
   public class Speaker
    {
        public string SpeakerName { get; set; }
        public string ShortDescription { get; set; }
        public string Topic { get; set; }
        public string ImgUrl { get; set; }

        public List<Speaker> GetSpeakers()
        {
            List <Speaker> speakers= new List<Speaker>()
            {
                new Speaker() { SpeakerName="Aswani",Topic="Xamarin",ImgUrl="icon.png",ShortDescription="Native mobile App development"},
                new Speaker() { SpeakerName="Aswathi",Topic="Asp",ImgUrl="f2.jpg",ShortDescription="Web development"},

            };
            return speakers;
        }
    }

}
