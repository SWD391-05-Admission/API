using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionAPI.v1._0.Models
{
    public class Talkshow : BaseEntity
    {

        public TalkshowStatus TalkshowStatus { get; set; }
        public Counselor Counselor { get; set; }
    }
}
