using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace FriendZone
{
    class User
    {
        private string name;
        private string surname;
        private int gender;
        private int age;
        private string favorite;
        private int education;
        private int career;
        private int zodiac;
        private DateTime birthday;
        private int bloodType;
        private int j,k,l;
        private TestPersonality testpersonality;
        private SortedList filter = new SortedList();
        private SortedList meeting = new SortedList();
        private SortedList request = new SortedList();
        private char score1, score2, score3, score4, score5, score6, score7, score8, score9, score10,
            score11, score12, score13, score14, score15, score16, score17, score18, score19, score20,
            score21, score22, score23, score24, score25, score26, score27, score28, score29, score30, score31, score32;
        public string getexp
        { get { return testpersonality.getexplanation; } }
        public User(string n, string s, int g, string f, int e, int c, int z, DateTime bd, int bt )
        {
            name = n;
            surname = s;
            gender = g;
            favorite = f;
            education = e;
            career = c;
            zodiac = z;
            birthday = bd;
            bloodType = bt;
            j = 1;
            k = 1;
            l = 1;
            age = DateTime.Now.Year - birthday.Year;
            if (DateTime.Now.DayOfYear < birthday.DayOfYear)
                age = age - 1;
            score1 = '0'; score2 = '0'; score3 = '0'; score4 = '0'; score5 = '0'; score6 = '0'; score7 = '0'; score8 = '0';
            score9 = '0'; score10 = '0'; score11 = '0'; score12 = '0'; score13 = '0'; score14 = '0'; score15 = '0'; score16 = '0';
            score17 = '0'; score18 = '0'; score19 = '0'; score20 = '0'; score21 = '0'; score22 = '0'; score23 = '0'; score24 = '0';
            score25 = '0'; score26 = '0'; score27 = '0'; score28 = '0'; score29 = '0'; score30 = '0'; score31 = '0'; score32 = '0';
        }
        public char setscore1        { set { score1 = value; } }        public char setscore2        { set { score2 = value; } }
        public char setscore3        { set { score3 = value; } }        public char setscore4        { set { score4 = value; } }
        public char setscore5        { set { score5 = value; } }        public char setscore6        { set { score6 = value; } }
        public char setscore7        { set { score7 = value; } }        public char setscore8        { set { score8 = value; } }
        public char setscore9        { set { score9 = value; } }        public char setscore10        { set { score10 = value; } }
        public char setscore11        { set { score11 = value; } }        public char setscore12        { set { score12 = value; } }
        public char setscore13        { set { score13 = value; } }        public char setscore14        { set { score14 = value; } }
        public char setscore15        { set { score15 = value; } }        public char setscore16        { set { score16 = value; } }
        public char setscore17        { set { score17 = value; } }        public char setscore18        { set { score18 = value; } }
        public char setscore19        { set { score19 = value; } }        public char setscore20        { set { score20 = value; } }
        public char setscore21        { set { score21 = value; } }        public char setscore22        { set { score22 = value; } }
        public char setscore23        { set { score23 = value; } }        public char setscore24        { set { score24 = value; } }
        public char setscore25        { set { score25 = value; } }        public char setscore26        { set { score26 = value; } }
        public char setscore27        { set { score27 = value; } }        public char setscore28        { set { score28 = value; } }
        public char setscore29        { set { score29 = value; } }        public char setscore30        { set { score30 = value; } }
        public char setscore31        { set { score31 = value; } }        public char setscore32        { set { score32 = value; } }
        public string findpersona()
        {
            char[] allscore = { score1, score2, score3, score4, score5, score6, score7, score8, score9, score10,
            score11, score12, score13, score14, score15, score16, score17, score18, score19, score20,
            score21, score22, score23, score24, score25, score26, score27, score28, score29, score30, score31, score32};
            int I = 0, E = 0, S = 0, N = 0, T = 0, F = 0, J = 0, P = 0;
            for (int i = 0; i < allscore.Length; i++)
            {
                if (allscore[i] == 'N') N++;
                else if (allscore[i] == 'S') S++;
                else if (allscore[i] == 'I') I++;
                else if (allscore[i] == 'E') E++;
                else if (allscore[i] == 'T') T++;
                else if (allscore[i] == 'F') F++;
                else if (allscore[i] == 'J') J++;
                else if (allscore[i] == 'P') P++;
            }
            if (I == E)
                allscore[11-1] = '0';
            if (S == N)
                allscore[16-1] = '0';
            if (J == P)
                allscore[23-1] = '0';
            if (T == F)
                allscore[24-1] = '0';
            I = 0; E = 0; S = 0; N = 0; T = 0; F = 0; J = 0; P = 0;
            for (int i = 0; i < allscore.Length; i++)
            {
                if (allscore[i] == 'N') N++;
                else if (allscore[i] == 'S') S++;
                else if (allscore[i] == 'I') I++;
                else if (allscore[i] == 'E') E++;
                else if (allscore[i] == 'T') T++;
                else if (allscore[i] == 'F') F++;
                else if (allscore[i] == 'J') J++;
                else if (allscore[i] == 'P') P++;
            }
            string ans;
            if (I > E && N > S && T > F && J > P)
                ans = "INTJ";
            else if (I > E && N > S && T > F && J < P)
                ans = "INTP";
            else if (I > E && N > S && T < F && J > P)
                ans = "INFJ";
            else if (I > E && N > S && T < F && J < P)
                ans = "INFP";
            else if (I > E && N < S && T > F && J > P)
                ans = "ISTJ";
            else if (I > E && N < S && T > F && J < P)
                ans = "ISTP";
            else if (I > E && N < S && T < F && J > P)
                ans = "ISFJ";
            else if (I > E && N < S && T < F && J < P)
                ans = "ISFP";
            else if (I < E && N > S && T > F && J > P)
                ans = "ENTJ";
            else if (I < E && N > S && T > F && J < P)
                ans = "ENTP";
            else if (I < E && N > S && T < F && J > P)
                ans = "ENFJ";
            else if (I < E && N > S && T < F && J < P)
                ans = "ENFP";
            else if (I < E && N < S && T > F && J > P)
                ans = "ESTJ";
            else if (I < E && N < S && T > F && J < P)
                ans = "ESTP";
            else if (I < E && N < S && T < F && J > P)
                ans = "ESFJ";
            else
                ans = "ESFP";
            return ans;
        }
        public void personality(TestPersonality t)
        {
            testpersonality = t;
        }
        public string getName
        {
            get { return name; }
        }
        public int getGender
        {
            get { return gender; }
        }
        public int getAge
        {
            get { return age; }
        }
        public int getEducation
        {
            get { return education; }
        }
        public int getCareer
        {
            get { return career; }
        }
        public int getZodiac
        {
            get { return zodiac; }
        }
        public int getBloodType
        {
            get { return bloodType; }
        }
        public string getPersonality
        {
            get { return testpersonality.getpersona; }
        }
        public void showProfile()
        {
            string g, e, c, z, bt;
            if (gender == 1) g = "Male"; else if (gender == 2) g = "Female"; else g = "Other";
            if (education == 1) e = "Less than Highschool"; else if (education == 2) e = "Highschool";
            else if (education == 3) e = "Some college but no degree"; else if (education == 4) e = "Associate";
            else if (education == 5) e = "Bachelor's"; else e = "Graduate degree";
            if (career == 1) c = "Student"; else if (career == 2) c = "Teacher"; else if (career == 3) c = "Professor";
            else if (career == 4) c = "Judge"; else if (career == 5) c = "Soilder"; else if (career == 6) c = "Doctor";
            else if (career == 7) c = "Farmer"; else if (career == 8) c = "Labor"; else if (career == 9) c = "Scientist";
            else if (career == 10) c = "Merchant"; else if (career == 11) c = "Dentist"; else if (career == 12) c = "Engineer";
            else if (career == 13) c = "Politician"; else if (career == 14) c = "Freelancer"; else c = "etc.";
            if (zodiac == 1) z = "Aries"; else if (zodiac == 2) z = "Taurus"; else if (zodiac == 3) z = "Gemini";
            else if (zodiac == 4) z = "Cancer"; else if (zodiac == 5) z = "Leo"; else if (zodiac == 6) z = "Virgo";
            else if (zodiac == 7) z = "Libra"; else if (zodiac == 8) z = "Scorpio"; else if (zodiac == 9) z = "Sagittarius";
            else if (zodiac == 10) z = "Capricorn"; else if (zodiac == 11) z = "Aquarius"; else z = "Pisces";
            if (bloodType == 1) bt = "A"; else if (bloodType == 2) bt = "B"; else if (bloodType == 3) bt = "O"; else bt = "AB";
            Console.WriteLine("\nProfile\n\nName: " + name +"\nSurname: " + surname + "\nGender: " + g
                + "\nAge: " + age + "\nFavorite: " + favorite + "\nEducation: " + e + "\nCareer: " + c
                + "\nZodiac: " + z + "\nBlood type: " + bt + "\nPersonality: " + testpersonality.getpersona+"\n");
        }
        public void chooseFilter(int ch, int f)
        {
            Filter fil = new Filter();
            filter.Add(j, fil);
            if (ch == 1)
            {
                ((Filter)filter[j]).Gender = f;
            }
            else if (ch == 2)
            {
                ((Filter)filter[j]).Age = f;
            }
            else if (ch == 3)
            {
                ((Filter)filter[j]).Education = f;
            }
            else if (ch == 4)
            {
                ((Filter)filter[j]).Career = f;
            }
            else if (ch == 5)
            {
                ((Filter)filter[j]).Zodiac = f;
            }
            else if (ch == 6)
            {
                ((Filter)filter[j]).BloodType = f;
            }
            else if (ch == 7)
            {
                if (f == 1)
                {
                    ((Filter)filter[j]).Personality = "The Architect";
                }
                else if (f == 2)
                {
                    ((Filter)filter[j]).Personality = "The Thinker";
                }
                else if (f == 3)
                {
                    ((Filter)filter[j]).Personality = "The Advocate";
                }
                else if (f == 4)
                {
                    ((Filter)filter[j]).Personality = "The Mediator";
                }
                else if (f == 5)
                {
                    ((Filter)filter[j]).Personality = "The Inspector";
                }
                else if (f == 6)
                {
                    ((Filter)filter[j]).Personality = "The Crafter";
                }
                else if (f == 7)
                {
                    ((Filter)filter[j]).Personality = "The Protector";
                }
                else if (f == 8)
                {
                    ((Filter)filter[j]).Personality = "The Artist";
                }
                else if (f == 9)
                {
                    ((Filter)filter[j]).Personality = "The Commander";
                }
                else if (f == 10)
                {
                    ((Filter)filter[j]).Personality = "The Debater";
                }
                else if (f == 11)
                {
                    ((Filter)filter[j]).Personality = "The Giver";
                }
                else if (f == 12)
                {
                    ((Filter)filter[j]).Personality = "The Champion";
                }
                else if (f == 13)
                {
                    ((Filter)filter[j]).Personality = "The Director";
                }
                else if (f == 14)
                {
                    ((Filter)filter[j]).Personality = "The Persuader";
                }
                else if (f == 15)
                {
                    ((Filter)filter[j]).Personality = "The Caregiver";
                }
                else if (f == 16)
                {
                    ((Filter)filter[j]).Personality = "The Performer";
                }
            }
        }
        public int getfilter1(int ch)
        {
            int c;
            if (ch == 1)
            {
                c = ((Filter)filter[j]).Gender;
                return c;
            }
            else if (ch == 2)
            {
                c = ((Filter)filter[j]).Age;
                return c;
            }
            else if (ch == 3)
            {
                c = ((Filter)filter[j]).Education;
                return c;
            }
            else if (ch == 4)
            {
                c = ((Filter)filter[j]).Career;
                return c;
            }
            else if (ch == 5)
            {
                c = ((Filter)filter[j]).Zodiac;
                return c;
            }
            else
            {
                c = ((Filter)filter[j]).BloodType;
                return c;
            }
        }
        public string getfilter2()
        {
            string c = ((Filter)filter[j]).Personality;
            return c;
        }
        public void increasej()
        {
            j++;
        }
        public void createMeeting(string uN, string fN, DateTime t, string p)
        {
            Meeting meet = new Meeting(uN, fN, t, p);
            meeting.Add(k, meet);
            k++;
        }
        public void createRequest(string uN, string fN, DateTime t, string p)
        {
            Meeting re = new Meeting(uN, fN, t, p);
            request.Add(l, re);
            l++;
        }
        public void showMeeting()
        {
            Console.Write("Meeting\n");
            if (meeting.Count == 0)
                Console.WriteLine("You didn't send any request");
            else
            {
                for (int i = 0; i < meeting.Count; i++)
                    Console.Write((i + 1) + ". Send to " + ((Meeting)meeting[meeting.GetKey(i)]).getFriend + ", meet at " +
                        ((Meeting)meeting[meeting.GetKey(i)]).getPlace + " " + ((Meeting)meeting[meeting.GetKey(i)]).getTime +
                        " status now: " + ((Meeting)meeting[meeting.GetKey(i)]).getStatus+"\n");
            }
        }
        public int showRequest()
        {
            Console.Write("Meeting request\n");
            if (request.Count == 0)
                Console.WriteLine("You don't have any meeting request.");
            else
            {
                for (int i = 0; i < request.Count; i++)
                    {
                        Console.Write((i + 1) + ". From " + ((Meeting)request[request.GetKey(i)]).getFriend + ", meet at " +
                            ((Meeting)request[request.GetKey(i)]).getPlace + " " + ((Meeting)request[request.GetKey(i)]).getTime +
                            " status now: " + ((Meeting)request[request.GetKey(i)]).getStatus + "\n");
                    }
            }
            return request.Count;
        }
        public string showSpecific(int req)
        {
            Console.Write("From "+((Meeting)request[req]).getFriend+ ", meet at " +
                        ((Meeting)request[req]).getPlace + " " + ((Meeting)request[req]).getTime +
                        " status now: " + ((Meeting)request[req]).getStatus+"\n");
            return ((Meeting)request[req]).getFriend;
        }
        public void changeStatusRequest(int req, char ans)
        {
            if (ans == 'y'||ans=='Y')
            {
                ((Meeting)request[req]).changeStatus(ans);
            }
            else
            {
                ((Meeting)request[req]).changeStatus(ans);
            }
        }
        public void changeStatusMeeting(string name, char ans)
        {
            if (ans == 'y' || ans == 'Y')
            {
                for (int i = 0; i < meeting.Count; i++)
                {
                    if (((Meeting)meeting[meeting.GetKey(i)]).getFriend == name)
                        ((Meeting)meeting[meeting.GetKey(i)]).changeStatus(ans);
                }
            }
            else
            {
                for (int i = 0; i < meeting.Count; i++)
                {
                    if (((Meeting)meeting[meeting.GetKey(i)]).getFriend == name)
                        ((Meeting)meeting[meeting.GetKey(i)]).changeStatus(ans);
                }

            }
        }
        public string getStatus(int req)
        {
            string c = ((Meeting)request[req]).getStatus;
            return c;
        }
    }
}
