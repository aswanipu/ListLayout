using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListSample.Model;


namespace ListSample.ViewModel
{
    public class SpeakerViewModel
    {
        public List<Speaker> Speakers { get; set; }
        public SpeakerViewModel()
        {
            Speakers = new Speaker().GetSpeakers();
        }
    }

}
