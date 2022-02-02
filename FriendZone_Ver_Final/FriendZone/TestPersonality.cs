using System;
using System.Collections.Generic;
using System.Text;

namespace FriendZone
{
    class TestPersonality
    {
        private string persona;
        private string explanation;
        public TestPersonality (string p ,string e)
        {
            persona = p;
            explanation = e;
        }
        public string getpersona
        { get { return persona; } }
        public string getexplanation
        { get { return explanation; } }
    }
}
