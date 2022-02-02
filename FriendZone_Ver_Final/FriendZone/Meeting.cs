using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace FriendZone
{
    class Meeting
    {
        private string userName;
        private string friendName;
        private DateTime time;
        private string place;
        private string status;
        public Meeting(string uN, string fN, DateTime t, string p)
        {
            userName = uN;
            friendName = fN;
            time = t;
            place = p;
            status = "In progress";
        }
        public string getUser
        { get { return userName; } }
        public string getFriend
        { get { return friendName; } }
        public string getPlace
        { get { return place; } }
        public DateTime getTime
        { get { return time; } }
        public string getStatus
        {
            get { return status; }
            set { status = value; }
        }
        public void changeStatus(char ans)
        {
            if (ans == 'y' || ans == 'Y')
                status = "Meeting success";
            else
                status = "Meeting fail";
        }
    }
}
