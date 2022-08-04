using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAZE_DATA_FEED.Services
{
    public  partial class Results
    {
        public List<Alert>? alerts { get; set; }
        public ulong endTimeMillis { get; set; }
        public ulong startTimeMillis { get; set; }
        public string? startTime { get; set; }
        public string? endTime { get; set; }
        public List<Jam>? jams { get; set; }
    }


    public partial class Root
    {
        
    }
    public partial class Alert
    {
        public string? country { get; set; }
        public string? city { get; set; }
        public int reportRating { get; set; }
        public int confidence { get; set; }
        public int reliability { get; set; }
        public string? type { get; set; }
        public string? uuid { get; set; }
        public int roadType { get; set; }
        public int magvar { get; set; }
        public string? subtype { get; set; }
        public string? street { get; set; }
        public string? reportDescription { get; set; }
        public Location? location { get; set; }
        public ulong pubMillis { get; set; }
        public int? nThumbsUp { get; set; }
    }
    public partial class Location
    {
        public double x { get; set; }
        public double y { get; set; }
    }
    public partial class Jam
    {
        public string? country { get; set; }
        public string? city { get; set; }
        public int level { get; set; }
        public List<Line>? line { get; set; }
        public double speedKMH { get; set; }
        public int length { get; set; }
        public string? turnType { get; set; }
        public string? type { get; set; }
        public ulong uuid { get; set; }
        public string? endNode { get; set; }
        public double speed { get; set; }
        public List<Segment>? segments { get; set; }
        public int roadType { get; set; }
        public int delay { get; set; }
        public string? street { get; set; }
        public ulong id { get; set; }
        public ulong pubMillis { get; set; }
        public string? blockingAlertUuid { get; set; }
    }

    public partial class Line
    {
        public double x { get; set; }
        public double y { get; set; }
    }


    public partial class Segment
    {
    }


}
