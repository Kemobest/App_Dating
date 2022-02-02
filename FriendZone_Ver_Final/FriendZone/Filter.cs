using System;
using System.Collections.Generic;
using System.Text;

namespace FriendZone
{
    class Filter
    {
        private int gender;
        private int age;
        private int education;
        private int career;
        private int zodiac;
        private int bloodType;
        private string personality;
        public Filter ()
        {
            gender = 0;
            age = 0;
            education = 0;
            career = 0;
            zodiac = 0;
            bloodType = 0;
            personality = "";
        }
        public int Gender
        { get { return gender; } set { gender = value; } }
        public int Age
        { get { return age; } set { age = value; } }
        public int Education
        { get { return education; } set { education = value; } }
        public int Career
        { get { return career; } set { career = value; } }
        public int Zodiac
        { get { return zodiac; } set { zodiac = value; } }
        public int BloodType
        { get { return bloodType; } set { bloodType = value; } }
        public string Personality
        { get { return personality; } set { personality = value; } }
    }
}
