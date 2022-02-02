using System;
using System.Collections;
using System.Dynamic;
using System.Security.Cryptography;
//Project FriendZone by Yossawat Ousirimaneechai 6242079326 and Romrada Lardmarong 6242080926
namespace FriendZone
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable
            char a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, 
                a25, a26, a27, a28, a29, a30, a31, a32,
                s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17, s18, s19, s20, s21, s22, s23, s24,
                s25, s26, s27, s28, s29, s30, s31, s32;
            int ch, gender, Gender, education, Education, age, Age, career, Career, zodiac, Zodiac, bt, BT, i, timeF, typeF, filter = 0, year, month
                , day, hour, min, request,reqcount;
            string name, fname, surname, favorite, personality, Personality, place, Ans;
            char choice, ans,choose = '0';
            DateTime birthday, meetday;
            //Array of TestPersonality
            SortedList persona = new SortedList();
            persona.Add("INTJ", new TestPersonality("The Architect", "(Introverted, Intuitive, Thinking, Judging) is enjoys theoretical and abstract concepts, high expectations, good at listening, takes criticism well, and self-confident and hard-working."));
            persona.Add("INTP", new TestPersonality("The Thinker", "(Introverted, Intuitive, Thinking, Perceiving) is logical and objective, abstract thinker, independent, loyal, and affectionate with loved ones."));
            persona.Add("INFJ", new TestPersonality("The Advocate", "(Introverted, Intuitive, Feeling, Judging) is sensitive to the needs of others, reserved, highly creative and artistic, focused on the future, values close, deep relationships, enjoys thinking about the meaning of life, and idealistic."));
            persona.Add("INFP", new TestPersonality("The Mediator", "(Introverted, Intuitive, Feeling, Perceiving) is loyal and devoted, sensitive to feelings, caring and interested in others, works well alone, values close relationships, and good at seeing 'the big picture.'"));
            persona.Add("ISTJ", new TestPersonality("The Inspector", "(Introverted, Sensing, Thinking, Judging) is detail-oriented, realistic, present-focused, observant, logical and practical, orderly, and organized."));
            persona.Add("ISTP", new TestPersonality("The Crafter", "(Introverted, Sensing, Thinking, Perceiving) is logical, learns by experience, action-oriented, realistic and practical, enjoys new things, self-confident, and easy-going."));
            persona.Add("ISFJ", new TestPersonality("The Protector", "(Introverted, Sensing, Feeling, Judging) is reliable, practical, sensitive, and eye for detail."));
            persona.Add("ISFP", new TestPersonality("The Artist", "(Introverted, Sensing, Feeling, Perceiving) is very aware of their environment, practical, enjoys hands-on learning, and loyal to values and beliefs."));
            persona.Add("ENTJ", new TestPersonality("The Commander", "(Extraverted, Intuitive, Thinking, Judging) is strong leadership skills, self-assured, well-organized, good at making decisions, assertive, outspoken, and strong communication skills."));
            persona.Add("ENTP", new TestPersonality("The Debater", "(Extroverted, Intuitive, Thinking, Perceiving) is innovative, creative, great conversationalist, enjoys debating, and values knowledge."));
            persona.Add("ENFJ", new TestPersonality("The Giver", "(Extraverted, Intuitive, Feeling, Judging) is outgoing and warm-hearted, empathetic, wide social circle, encouraging, and organized."));
            persona.Add("ENFP", new TestPersonality("The Champion", "(Extraverted, Intuitive, Feeling, Perceiving) is warm and enthusiastic, empathetic and caring, strong people skills, strong communication skills, fun and spontaneous, and highly creative."));
            persona.Add("ESTJ", new TestPersonality("The Director", "(Extraverted, Sensing, Thinking, Judging) is practical and realistic, dependable, self-confident, hard-working, traditional, and strong leadership skills."));
            persona.Add("ESTP", new TestPersonality("The Persuader", "(Extraverted, Sensing, Thinking, Perceiving) is gregarious, funny, energetic, influential and persuasive, action-oriented, adaptable and resourceful, and observant."));
            persona.Add("ESFJ", new TestPersonality("The Caregiver", "(Extraverted, Sensing, Feeling, Judging) is kind and loyal, outgoing, organized, practical and dependable, and enjoys helping others."));
            persona.Add("ESFP", new TestPersonality("The Performer", "(Extraverted, Sensing, Feeling, Perceiving) is optimistic and gregarious, enjoys people and socializing, focused on the present, spontaneous, and practical."));
            //Array of User
            SortedList user = new SortedList();
            user.Add("Yossawat", new User("Yossawat", "Ousirimaneechai", 3, "Animal", 2,
                1, 5, new DateTime(2000, 08, 20), 4));
            ((User)user["Yossawat"]).personality(((TestPersonality)persona["INFP"]));
            user.Add("Romrada", new User("Romrada", "Lardmarong", 2, "Game", 2,
                1, 4, new DateTime(2000, 07, 19), 2));
            ((User)user["Romrada"]).personality(((TestPersonality)persona["INFP"]));
            user.Add("Thantawan", new User("Thantawan", "Ruadreo", 2, "Farm", 3,
                7, 7, new DateTime(1960, 05, 12), 1));
            ((User)user["Thantawan"]).personality(((TestPersonality)persona["ESTJ"]));
            user.Add("Supawit", new User("Supawit", "Ruadreo", 1, "Sun", 6,
                3, 12, new DateTime(1998, 10, 07), 3));
            ((User)user["Supawit"]).personality(((TestPersonality)persona["ENTP"]));
            user.Add("Palida", new User("Palida", "Supanyachotesakul", 2, "Drawing", 1,
                2, 2, new DateTime(2001, 02, 15), 2));
            ((User)user["Palida"]).personality(((TestPersonality)persona["ISFP"]));
            user.Add("Phiphatsaphorn", new User("Phiphatsaphorn", "Kanchanamongkolkul", 3, "Goal", 4,
                15, 9, new DateTime(2000, 09, 17), 1));
            ((User)user["Phiphatsaphorn"]).personality(((TestPersonality)persona["ISTP"]));
            user.Add("Siwaporn", new User("Siwaporn", "Suksing", 2, "Dream", 5,
                10, 5, new DateTime(2002, 01, 01), 4));
            ((User)user["Siwaporn"]).personality(((TestPersonality)persona["ISTJ"]));
            user.Add("James", new User("James", "Moriarty", 1, "Math", 6,
                3, 12, new DateTime(1985, 05, 04), 4));
            ((User)user["James"]).personality(((TestPersonality)persona["ENTP"]));
            user.Add("Tom", new User("Tom", "Holland", 1, "Spider-man", 3,
                4, 6, new DateTime(1995, 02, 17), 2));
            ((User)user["Tom"]).personality(((TestPersonality)persona["ENFP"]));
            user.Add("Jadayu", new User("Jadayu", "Pakparkin", 1, "Food", 4,
                14, 12, new DateTime(1996, 02, 21), 2));
            ((User)user["Jadayu"]).personality(((TestPersonality)persona["INTP"]));
            user.Add("Jinn", new User("Jinn", "Arechon", 1, "Music", 5,
                12, 1, new DateTime(2000, 05, 12), 1));
            ((User)user["Jinn"]).personality(((TestPersonality)persona["INTJ"]));

            //Main Program
            Console.WriteLine("menu\n1. Register\n" +
                "2. choose friend\n3. Arrange a meeting\n4. check request meeting " +
                "\n5. Exit");
            try
            {
                ch = Convert.ToInt32(Console.ReadLine());
                if (ch > 5 || ch < 1)
                {
                    throw new ArithmeticException("Error: input must be 1-5");
                }
            }
            catch (Exception e)
            {
                Console.Write("Error: input must be 1-5\nselect (1-5) -> ");
                ch = Convert.ToInt32(Console.ReadLine());
            }
            while (ch != 5)
            {
                if (ch == 1)
                {
                    Console.Write("Welcome to Friend Zone.\nPlease input your name. -> ");//เมื่อใส่ชื่อซ้ำกับที่มีในระบบแล้วให้เด้งแจ้งเตือนว่ามีชื่อผู้ใช้นี้ในระบบแล้ว
                    name = Console.ReadLine();
                    if (user.Contains(name) == true)
                    {
                        Console.WriteLine("You can't input a name that is already in the program.");
                    }
                    else
                    {
                        Console.Write("Please input your surname. -> ");
                        surname = Console.ReadLine();
                        Console.Write("Please input your gender. (1. Male/2. Female/3. Other) -> ");
                        try
                        {
                            gender = Convert.ToInt32(Console.ReadLine());
                            if (gender > 3 || gender < 1)
                            {
                                throw new ArithmeticException("Error: input must be 1-3");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must be 1-3\nselect (1-3) -> ");
                            gender = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Write("Please input your favorite. -> ");
                        favorite = Console.ReadLine();
                        Console.Write("Please input your education. (1. Less than Highschool /2. Highschool /3. Some college but no degree " +
                            "/4. Associate /5. Bachelor's /6.Graduate degree) -> ");
                        try
                        {
                            education = Convert.ToInt32(Console.ReadLine());
                            if (education > 6 || education < 1)
                            {
                                throw new ArithmeticException("Error: input must be 1-6");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must be 1-6\nselect (1-6) -> ");
                            education = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Write("Please input your career. (1. Student /2. Teacher /3. Professor /4. Judge /5. Soldier /" +
                            "6. Doctor /7. Farmer /8. Labor /9. Scientist /10. Merchant /11. Dentist /12. Engineer /13. Politician /14. Freelancer /15. etc. ) -> ");
                        try
                        {
                            career = Convert.ToInt32(Console.ReadLine());
                            if (career > 15 || career < 1)
                            {
                                throw new ArithmeticException("Error: input must be 1-15");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must be 1-15\nselect (1-15) -> ");
                            career = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Write("Please input your zodiac. (1. Aries /2. Taurus /3. Gemini /4. Cancer /5. Leo /6. Virgo /" +
                            "7. Libra /8. Scorpio /9. Sagittarius /10. Capricorn /11. Aquarius /12. Pisces) -> ");
                        try
                        {
                            zodiac = Convert.ToInt32(Console.ReadLine());
                            if (zodiac > 12 || zodiac < 1)
                            {
                                throw new ArithmeticException("Error: input must be 1-12");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must be 1-12\nselect (1-12) -> ");
                            zodiac = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Write("Please input your birthday. Please enter year as A.D. (YYYY-MM-DD) -> ");
                        try
                        {
                            birthday = Convert.ToDateTime(Console.ReadLine());
                            if (birthday.Year > DateTime.Now.Year - 18 || birthday.Year < DateTime.Now.Year - 60)
                            {
                                throw new ArithmeticException("Error: Your age must be 18-60.");
                            }
                            else if (birthday.Year == DateTime.Now.Year - 18 && birthday.Month > DateTime.Now.Month || birthday.Year == DateTime.Now.Year - 60 && birthday.Month > DateTime.Now.Month)
                            {
                                throw new ArithmeticException("Error: Your age must be 18-60.");
                            }
                            else if (birthday.Year == DateTime.Now.Year - 18 && birthday.Month == DateTime.Now.Month && birthday.Day > DateTime.Now.Day || birthday.Year == DateTime.Now.Year - 60 && birthday.Day > DateTime.Now.Day)
                            {
                                throw new ArithmeticException("Error: Your age must be 18-60.");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must in the YYYY-MM-DD format, Year as A.D., and your age must be 18-60.\nPlease input your birthday. Please enter year as A.D. (YYYY-MM-DD) -> ");
                            birthday = Convert.ToDateTime(Console.ReadLine());
                        }
                        Console.Write("Please input your blood type. (1. A/2. B/3. O/4. AB) -> ");
                        try
                        {
                            bt = Convert.ToInt32(Console.ReadLine());
                            if (bt > 4 || bt < 1)
                            {
                                throw new ArithmeticException("Error: input must be 1-4\nselect (1-4) -> ");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must be 1-4\nselect (1-4) -> ");
                            bt = Convert.ToInt32(Console.ReadLine());
                        }
                        user.Add(name, new User(name, surname, gender, favorite, education, career, zodiac, birthday, bt));
                        Console.WriteLine("Finally, please do the personality test calmly");
                        Console.Write("\n1. I like to \nA solve new problems that are complicated.\nB choose to work on things that you have previously completed. \n-> ");
                        try
                        {
                            a1 = Convert.ToChar(Console.ReadLine());
                            if (a1 != 'a' && a1 != 'A' && a1 != 'b' && a1 != 'B')
                            {
                                throw new ArithmeticException("Error: input must be A or B");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must be A or B\nselect (A/B) -> ");
                            a1 = Convert.ToChar(Console.ReadLine());
                        }
                        if (a1 == 'A' || a1 == 'a') { s1 = 'N'; } else { s1 = 'S'; } ((User)user[name]).setscore1 = s1;
                        Console.Write("\n2. I like to \nA work alone in a quiet place.\nB work as a team. \n-> ");
                        try
                        {
                            a2 = Convert.ToChar(Console.ReadLine());
                            if (a2 != 'a' && a2 != 'A' && a2 != 'b' && a2 != 'B')
                            {
                                throw new ArithmeticException("Error: input must be A or B");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must be A or B\nselect (A/B) -> ");
                            a2 = Convert.ToChar(Console.ReadLine());
                        }
                        if (a2 == 'A' || a2 == 'a') { s2 = 'I'; } else { s2 = 'E'; } ((User)user[name]).setscore2 = s2;
                        Console.Write("\n3. I like supervisors that \nA have created and set the criteria for work and decision making.\nB pay attention to employees’ need and help individual employees. \n-> ");
                        try
                        {
                            a3 = Convert.ToChar(Console.ReadLine());
                            if (a3 != 'a' && a3 != 'A' && a3 != 'b' && a3 != 'B')
                            {
                                throw new ArithmeticException("Error: input must be A or B");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must be A or B\nselect (A/B) -> ");
                            a3 = Convert.ToChar(Console.ReadLine());
                        }
                        if (a3 == 'A' || a3 == 'a') { s3 = 'T'; } else { s3 = 'F'; } ((User)user[name]).setscore3 = s3;
                        Console.Write("\n4. When I work on a project, I want to \nA complete and close the project immediately.\nB wait before close the project in case it needs to improves. \n-> ");
                        try
                        {
                            a4 = Convert.ToChar(Console.ReadLine());
                            if (a4 != 'a' && a4 != 'A' && a4 != 'b' && a4 != 'B')
                            {
                                throw new ArithmeticException("Error: input must be A or B");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must be A or B\nselect (A/B) -> ");
                            a4 = Convert.ToChar(Console.ReadLine());
                        }
                        if (a4 == 'A' || a4 == 'a') { s4 = 'J'; } else { s4 = 'P'; } ((User)user[name]).setscore4 = s4;
                        Console.Write("\n5. When you have to make a decision, the most important thing for me to consider is \nA information and opinions.\nB feelings and values of people. \n-> ");
                        try
                        {
                            a5 = Convert.ToChar(Console.ReadLine());
                            if (a5 != 'a' && a5 != 'A' && a5 != 'b' && a5 != 'B')
                            {
                                throw new ArithmeticException("Error: input must be A or B");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must be A or B\nselect (A/B) -> ");
                            a5 = Convert.ToChar(Console.ReadLine());
                        }
                        if (a5 == 'A' || a5 == 'a') { s5 = 'T'; } else { s5 = 'F'; } ((User)user[name]).setscore5 = s5;
                        Console.Write("\n6. When I work on a project, I \nA think twice before deciding how to take action.\nB start working immediately, working along with thinking step by step. \n-> ");
                        try
                        {
                            a6 = Convert.ToChar(Console.ReadLine());
                            if (a6 != 'a' && a6 != 'A' && a6 != 'b' && a6 != 'B')
                            {
                                throw new ArithmeticException("Error: input must be A or B");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must be A or B\nselect (A/B) -> ");
                            a6 = Convert.ToChar(Console.ReadLine());
                        }
                        if (a6 == 'A' || a6 == 'a') { s6 = 'I'; } else { s6 = 'E'; } ((User)user[name]).setscore6 = s6;
                        Console.Write("\n7. When I work on a project, I like to \nA take a traditional approach to work.\nB check for new solutions That can be used to perform. \n-> ");
                        try
                        {
                            a7 = Convert.ToChar(Console.ReadLine());
                            if (a7 != 'a' && a7 != 'A' && a7 != 'b' && a7 != 'B')
                            {
                                throw new ArithmeticException("Error: input must be A or B");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must be A or B\nselect (A/B) -> ");
                            a7 = Convert.ToChar(Console.ReadLine());
                        }
                        if (a7 == 'A' || a7 == 'a') { s7 = 'J'; } else { s7 = 'P'; } ((User)user[name]).setscore7 = s7;
                        Console.Write("\n8. When I am working, I used to \nA do multiple projects at the same time and try to get as much knowledge from each project as possible.\nB choose to take on just one of the most challenging projects and be fully dedicated. \n-> ");
                        try
                        {
                            a8 = Convert.ToChar(Console.ReadLine());
                            if (a8 != 'a' && a8 != 'A' && a8 != 'b' && a8 != 'B')
                            {
                                throw new ArithmeticException("Error: input must be A or B");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must be A or B\nselect (A/B) -> ");
                            a8 = Convert.ToChar(Console.ReadLine());
                        }
                        if (a8 == 'A' || a8 == 'a') { s8 = 'P'; } else { s8 = 'J'; } ((User)user[name]).setscore8 = s8;
                        Console.Write("\n9. I like to \nA Make a list and work plan before starting to work. And will not be particularly dissatisfied if it has been modified from the original plan.\nB Avoid making plans, but will let the work progress on its own while doing so. \n-> ");
                        try
                        {
                            a9 = Convert.ToChar(Console.ReadLine());
                            if (a9 != 'a' && a9 != 'A' && a9 != 'b' && a9 != 'B')
                            {
                                throw new ArithmeticException("Error: input must be A or B");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must be A or B\nselect (A/B) -> ");
                            a9 = Convert.ToChar(Console.ReadLine());
                        }
                        if (a9 == 'A' || a9 == 'a') { s9 = 'J'; } else { s9 = 'P'; } ((User)user[name]).setscore9 = s9;
                        Console.Write("\n10. When discussing problems with friends, I can \nA see the big picture easily.\nB easily understand point in the problem deeply. \n-> ");
                        try
                        {
                            a10 = Convert.ToChar(Console.ReadLine());
                            if (a10 != 'a' && a10 != 'A' && a10 != 'b' && a10 != 'B')
                            {
                                throw new ArithmeticException("Error: input must be A or B");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must be A or B\nselect (A/B) -> ");
                            a10 = Convert.ToChar(Console.ReadLine());
                        }
                        if (a10 == 'A' || a10 == 'a') { s10 = 'N'; } else { s10 = 'S'; } ((User)user[name]).setscore10 = s10;
                        Console.Write("\n11. When the phone rings at work or at home, I usually \nA think that the sound was interferes with your work.\nB don't mind answering that phone call. \n-> ");
                        try
                        {
                            a11 = Convert.ToChar(Console.ReadLine());
                            if (a11 != 'a' && a11 != 'A' && a11 != 'b' && a11 != 'B')
                            {
                                throw new ArithmeticException("Error: input must be A or B");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must be A or B\nselect (A/B) -> ");
                            a11 = Convert.ToChar(Console.ReadLine());
                        }
                        if (a11 == 'A' || a11 == 'a') { s11 = 'I'; } else { s11 = 'E'; } ((User)user[name]).setscore11 = s11;
                        Console.Write("\n12. Which words would describe me better? \nA Analytical\nB Empathetic \n-> ");
                        try
                        {
                            a12 = Convert.ToChar(Console.ReadLine());
                            if (a12 != 'a' && a12 != 'A' && a12 != 'b' && a12 != 'B')
                            {
                                throw new ArithmeticException("Error: input must be A or B");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must be A or B\nselect (A/B) -> ");
                            a12 = Convert.ToChar(Console.ReadLine());
                        }
                        if (a12 == 'A' || a12 == 'a') { s12 = 'T'; } else { s12 = 'F'; } ((User)user[name]).setscore12 = s12;
                        Console.Write("\n13. When I do my homework, I often \nA do it consistently and be consistent.\nB do my best, but have intermittent pauses. \n-> ");
                        try
                        {
                            a13 = Convert.ToChar(Console.ReadLine());
                            if (a13 != 'a' && a13 != 'A' && a13 != 'b' && a13 != 'B')
                            {
                                throw new ArithmeticException("Error: input must be A or B");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must be A or B\nselect (A/B) -> ");
                            a13 = Convert.ToChar(Console.ReadLine());
                        }
                        if (a13 == 'A' || a13 == 'a') { s13 = 'S'; } else { s13 = 'N'; } ((User)user[name]).setscore13 = s13;
                        Console.Write("\n14. When I heard someone say something, I always try to \nA use my old experience to relate and see if it is similar.\nB analyze and evaluate the content. \n-> ");
                        try
                        {
                            a14 = Convert.ToChar(Console.ReadLine());
                            if (a14 != 'a' && a14 != 'A' && a14 != 'b' && a14 != 'B')
                            {
                                throw new ArithmeticException("Error: input must be A or B");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must be A or B\nselect (A/B) -> ");
                            a14 = Convert.ToChar(Console.ReadLine());
                        }
                        if (a14 == 'A' || a14 == 'a') { s14 = 'F'; } else { s14 = 'T'; } ((User)user[name]).setscore14 = s14;
                        Console.Write("\n15. When I come up with a new idea, I often \nA do it.\nB Try to reflect on that new idea several times. \n-> ");
                        try
                        {
                            a15 = Convert.ToChar(Console.ReadLine());
                            if (a15 != 'a' && a15 != 'A' && a15 != 'b' && a15 != 'B')
                            {
                                throw new ArithmeticException("Error: input must be A or B");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must be A or B\nselect (A/B) -> ");
                            a15 = Convert.ToChar(Console.ReadLine());
                        }
                        if (a15 == 'A' || a15 == 'a') { s15 = 'E'; } else { s15 = 'I'; } ((User)user[name]).setscore15 = s15;
                        Console.Write("\n16. When working on a project, I often \nA narrow the framework in order to see the picture more clearly and to the point.\nB expand the scope of work to be able to cover all relevant issues. \n-> ");
                        try
                        {
                            a16 = Convert.ToChar(Console.ReadLine());
                            if (a16 != 'a' && a16 != 'A' && a16 != 'b' && a16 != 'B')
                            {
                                throw new ArithmeticException("Error: input must be A or B");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must be A or B\nselect (A/B) -> ");
                            a16 = Convert.ToChar(Console.ReadLine());
                        }
                        if (a16 == 'A' || a16 == 'a') { s16 = 'S'; } else { s16 = 'N'; } ((User)user[name]).setscore16 = s16;
                        Console.Write("\n17. When I read something, I often \nA focus on the written message.\nB read each line to find key words that related to different ideas. \n-> ");
                        try
                        {
                            a17 = Convert.ToChar(Console.ReadLine());
                            if (a17 != 'a' && a17 != 'A' && a17 != 'b' && a17 != 'B')
                            {
                                throw new ArithmeticException("Error: input must be A or B");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must be A or B\nselect (A/B) -> ");
                            a17 = Convert.ToChar(Console.ReadLine());
                        }
                        if (a17 == 'A' || a17 == 'a') { s17 = 'S'; } else { s17 = 'N'; } ((User)user[name]).setscore17 = s17;
                        Console.Write("\n18. When I need to make an urgent decision, I’m often \nA uncomfortable and in need of more information.\nB able to make decisions based on the information available. \n-> ");
                        try
                        {
                            a18 = Convert.ToChar(Console.ReadLine());
                            if (a18 != 'a' && a18 != 'A' && a18 != 'b' && a18 != 'B')
                            {
                                throw new ArithmeticException("Error: input must be A or B");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must be A or B\nselect (A/B) -> ");
                            a18 = Convert.ToChar(Console.ReadLine());
                        }
                        if (a18 == 'A' || a18 == 'a') { s18 = 'P'; } else { s18 = 'J'; } ((User)user[name]).setscore18 = s18;
                        Console.Write("\n19. In meetings, I often \nA slowly process my thoughts while talking about it.\nB say it only after you have well thought about it. \n-> ");
                        try
                        {
                            a19 = Convert.ToChar(Console.ReadLine());
                            if (a19 != 'a' && a19 != 'A' && a19 != 'b' && a19 != 'B')
                            {
                                throw new ArithmeticException("Error: input must be A or B");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must be A or B\nselect (A/B) -> ");
                            a19 = Convert.ToChar(Console.ReadLine());
                        }
                        if (a19 == 'A' || a19 == 'a') { s19 = 'E'; } else { s19 = 'I'; } ((User)user[name]).setscore19 = s19;
                        Console.Write("\n20. In my work, the issues that I prefer to spend more time are \nA issues of the idea.\nB issues relating to people. \n-> ");
                        try
                        {
                            a20 = Convert.ToChar(Console.ReadLine());
                            if (a20 != 'a' && a20 != 'A' && a20 != 'b' && a20 != 'B')
                            {
                                throw new ArithmeticException("Error: input must be A or B");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must be A or B\nselect (A/B) -> ");
                            a20 = Convert.ToChar(Console.ReadLine());
                        }
                        if (a20 == 'A' || a20 == 'a') { s20 = 'T'; } else { s20 = 'F'; } ((User)user[name]).setscore20 = s20;
                        Console.Write("\n21. In meetings, I am often annoyed by those who \nA like to offer many ideas that are still lacking in clarity.\nB waste time in the meeting to discuss the details of the work too carefully. \n-> ");
                        try
                        {
                            a21 = Convert.ToChar(Console.ReadLine());
                            if (a21 != 'a' && a21 != 'A' && a21 != 'b' && a21 != 'B')
                            {
                                throw new ArithmeticException("Error: input must be A or B");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must be A or B\nselect (A/B) -> ");
                            a21 = Convert.ToChar(Console.ReadLine());
                        }
                        if (a21 == 'A' || a21 == 'a') { s21 = 'S'; } else { s21 = 'N'; } ((User)user[name]).setscore21 = s21;
                        Console.Write("\n22. I like to \nA Get up early.\nB Sleep late. \n-> ");
                        try
                        {
                            a22 = Convert.ToChar(Console.ReadLine());
                            if (a22 != 'a' && a22 != 'A' && a22 != 'b' && a22 != 'B')
                            {
                                throw new ArithmeticException("Error: input must be A or B");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must be A or B\nselect (A/B) -> ");
                            a22 = Convert.ToChar(Console.ReadLine());
                        }
                        if (a22 == 'A' || a22 == 'a') { s22 = 'I'; } else { s22 = 'E'; } ((User)user[name]).setscore22 = s22;
                        Console.Write("\n23. My preparation before attending meetings is \nA just attend the meeting and express opinions at the meeting.\nB fully prepared and drew out the agenda on the subject of the meeting \n-> ");
                        try
                        {
                            a23 = Convert.ToChar(Console.ReadLine());
                            if (a23 != 'a' && a23 != 'A' && a23 != 'b' && a23 != 'B')
                            {
                                throw new ArithmeticException("Error: input must be A or B");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must be A or B\nselect (A/B) -> ");
                            a23 = Convert.ToChar(Console.ReadLine());
                        }
                        if (a23 == 'A' || a23 == 'a') { s23 = 'P'; } else { s23 = 'J'; } ((User)user[name]).setscore23 = s23;
                        Console.Write("\n24. In the meeting, I like the people who are \nA able to express emotions well.\nB focus on work. \n-> ");
                        try
                        {
                            a24 = Convert.ToChar(Console.ReadLine());
                            if (a24 != 'a' && a24 != 'A' && a24 != 'b' && a24 != 'B')
                            {
                                throw new ArithmeticException("Error: input must be A or B");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must be A or B\nselect (A/B) -> ");
                            a24 = Convert.ToChar(Console.ReadLine());
                        }
                        if (a24 == 'A' || a24 == 'a') { s24 = 'F'; } else { s24 = 'T'; } ((User)user[name]).setscore24 = s24;
                        Console.Write("\n25. I like working with agencies that \nA stimulate the use of wisdom in the work for me.\nB committed to goals and missions. \n-> ");
                        try
                        {
                            a25 = Convert.ToChar(Console.ReadLine());
                            if (a25 != 'a' && a25 != 'A' && a25 != 'b' && a25 != 'B')
                            {
                                throw new ArithmeticException("Error: input must be A or B");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must be A or B\nselect (A/B) -> ");
                            a25 = Convert.ToChar(Console.ReadLine());
                        }
                        if (a25 == 'A' || a25 == 'a') { s25 = 'T'; } else { s25 = 'F'; } ((User)user[name]).setscore25 = s25;
                        Console.Write("\n26. In the weekend, I often \nA plan ahead of what to do.\nB go and see what happened. \n-> ");
                        try
                        {
                            a26 = Convert.ToChar(Console.ReadLine());
                            if (a26 != 'a' && a26 != 'A' && a26 != 'b' && a26 != 'B')
                            {
                                throw new ArithmeticException("Error: input must be A or B");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must be A or B\nselect (A/B) -> ");
                            a26 = Convert.ToChar(Console.ReadLine());
                        }
                        if (a26 == 'A' || a26 == 'a') { s26 = 'J'; } else { s26 = 'P'; } ((User)user[name]).setscore26 = s26;
                        Console.Write("\n27. I am a person who \nA likes going out to meet people.\nB prefers thoughtful thinking \n-> ");
                        try
                        {
                            a27 = Convert.ToChar(Console.ReadLine());
                            if (a27 != 'a' && a27 != 'A' && a27 != 'b' && a27 != 'B')
                            {
                                throw new ArithmeticException("Error: input must be A or B");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must be A or B\nselect (A/B) -> ");
                            a27 = Convert.ToChar(Console.ReadLine());
                        }
                        if (a27 == 'A' || a27 == 'a') { s27 = 'E'; } else { s27 = 'I'; } ((User)user[name]).setscore27 = s27;
                        Console.Write("\n28. I like to work with a supervisor who is \nA full of new ideas.\nB a good practitioner. \n-> ");
                        try
                        {
                            a28 = Convert.ToChar(Console.ReadLine());
                            if (a28 != 'a' && a28 != 'A' && a28 != 'b' && a28 != 'B')
                            {
                                throw new ArithmeticException("Error: input must be A or B");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must be A or B\nselect (A/B) -> ");
                            a28 = Convert.ToChar(Console.ReadLine());
                        }
                        if (a28 == 'A' || a28 == 'a') { s28 = 'N'; } else { s28 = 'S'; } ((User)user[name]).setscore28 = s28;
                        Console.Write("\n29. choose one from “a” or “b”. \nA Social\nB Theoretical \n-> ");
                        try
                        {
                            a29 = Convert.ToChar(Console.ReadLine());
                            if (a29 != 'a' && a29 != 'A' && a29 != 'b' && a29 != 'B')
                            {
                                throw new ArithmeticException("Error: input must be A or B");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must be A or B\nselect (A/B) -> ");
                            a29 = Convert.ToChar(Console.ReadLine());
                        }
                        if (a29 == 'A' || a29 == 'a') { s29 = 'F'; } else { s29 = 'T'; } ((User)user[name]).setscore29 = s29;
                        Console.Write("\n30. choose one from “a” or “b”. \nA Ingenuity\nB Practicality \n-> ");
                        try
                        {
                            a30 = Convert.ToChar(Console.ReadLine());
                            if (a30 != 'a' && a30 != 'A' && a30 != 'b' && a30 != 'B')
                            {
                                throw new ArithmeticException("Error: input must be A or B");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must be A or B\nselect (A/B) -> ");
                            a30 = Convert.ToChar(Console.ReadLine());
                        }
                        if (a30 == 'A' || a30 == 'a') { s30 = 'N'; } else { s30 = 'S'; } ((User)user[name]).setscore30 = s30;
                        Console.Write("\n31. choose one from “a” or “b”. \nA Organized\nB Adaptable \n-> ");
                        try
                        {
                            a31 = Convert.ToChar(Console.ReadLine());
                            if (a31 != 'a' && a31 != 'A' && a31 != 'b' && a31 != 'B')
                            {
                                throw new ArithmeticException("Error: input must be A or B");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must be A or B\nselect (A/B) -> ");
                            a31 = Convert.ToChar(Console.ReadLine());
                        }
                        if (a31 == 'A' || a31 == 'a') { s31 = 'J'; } else { s31 = 'P'; } ((User)user[name]).setscore31 = s31;
                        Console.Write("\n32. choose one from “a” or “b”. \nA Active\nB Concentration \n-> ");
                        try
                        {
                            a32 = Convert.ToChar(Console.ReadLine());
                            if (a32 != 'a' && a32 != 'A' && a32 != 'b' && a32 != 'B')
                            {
                                throw new ArithmeticException("Error: input must be A or B");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must be A or B\nselect (A/B) -> ");
                            a32 = Convert.ToChar(Console.ReadLine());
                        }
                        if (a32 == 'A' || a32 == 'a') { s32 = 'E'; } else { s32 = 'I'; } ((User)user[name]).setscore32 = s32;
                        Ans = ((User)user[name]).findpersona();
                        ((User)user[name]).personality(((TestPersonality)persona[Ans]));
                        Console.WriteLine("Your personality is: " + Ans + "\nExplanation\n" + ((User)user[name]).getexp);
                        Console.WriteLine("Thank for registor FriendZone.");
                        ((User)user[name]).showProfile();
                    }
                }
                else if (ch == 2)
                {
                    Console.Write("Enter your name -> ");//ต้องมีในโปรแกรม
                    name = Console.ReadLine();
                    if (user.Contains(name) == true)
                    {
                        Console.Write("How many time do you want to filter? (choose 0,1) -> ");
                        try
                        {
                            timeF = Convert.ToInt32(Console.ReadLine());
                            if (timeF > 1 || timeF < 0)
                            {
                                throw new ArithmeticException("Error: input must be 0-1");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must be 0-1\nselect (0-1) -> ");
                            timeF = Convert.ToInt32(Console.ReadLine());
                        }
                        if (timeF == 0)
                        {
                            for (i = 0; i < user.Count; i++)
                            {
                                if (((User)user[user.GetKey(i)]).getName == name)
                                { }
                                else
                                {
                                    ((User)user[user.GetKey(i)]).showProfile();
                                    Console.Write("Do you want to chat with this person? (y/n) -> ");
                                    try
                                    {
                                        choose = Convert.ToChar(Console.ReadLine());
                                        if (choose != 'y' && choose != 'Y' && choose != 'n' && choose != 'N')
                                        {
                                            throw new ArithmeticException("Error: input must be y or n");
                                        }
                                    }
                                    catch (Exception e)
                                    {
                                        Console.Write("Error: input must be y or n\nselect (y/n) -> ");
                                        choose = Convert.ToChar(Console.ReadLine());
                                    }
                                    if (choose == 'y' || choose == 'Y')
                                    {
                                        Console.Write("Have fun with " + ((User)user[user.GetKey(i)]).getName + "\n");
                                        i = user.Count + 1;
                                    }
                                }
                            }
                            if (choose == '0' || choose == 'n' || choose == 'N')
                            {
                                Console.Write("There is no one that you want\n");
                            }
                        }
                        else
                        {
                            for (i = 1; i <= timeF; i++)
                            {
                                Console.WriteLine("Choose filter type\n1. Gender\n2. Age\n3. Education\n4. Career\n5. Zodiac\n6. Blood Type\n7. Personality");
                                try
                                {
                                    typeF = Convert.ToInt32(Console.ReadLine());
                                    if (typeF > 7 || typeF < 1)
                                    {
                                        throw new ArithmeticException("Error: input must be 1-7");
                                    }
                                }
                                catch (Exception e)
                                {
                                    Console.Write("Error: input must be 1-7\nselect (1-7) -> ");
                                    typeF = Convert.ToInt32(Console.ReadLine());
                                }
                                if (typeF == 1)
                                {
                                    Console.Write("Choose filter gender\n1. Male\n2. Female\n3. Other\n-> ");
                                    try
                                    {
                                        filter = Convert.ToInt32(Console.ReadLine());
                                        if (filter > 3 || filter < 1)
                                        {
                                            throw new ArithmeticException("Error: input must be 1-3");
                                        }
                                    }
                                    catch (Exception e)
                                    {
                                        Console.Write("Error: input must be 1-3\nselect (1-3) -> ");
                                        filter = Convert.ToInt32(Console.ReadLine());
                                    }
                                    ((User)user[name]).chooseFilter(typeF, filter);
                                    Gender = ((User)user[name]).getfilter1(typeF);
                                    for (i = 0; i < user.Count; i++)
                                    {
                                        if (((User)user[user.GetKey(i)]).getName == name)
                                        { }
                                        else
                                        {
                                            gender = ((User)user[user.GetKey(i)]).getGender;
                                            if (Gender == gender)
                                            {
                                                ((User)user[user.GetKey(i)]).showProfile();
                                                Console.Write("Do you want to chat with this person? (y/n) -> ");
                                                try
                                                {
                                                    choose = Convert.ToChar(Console.ReadLine());
                                                    if (choose != 'y' && choose != 'Y' && choose != 'n' && choose != 'N')
                                                    {
                                                        throw new ArithmeticException("Error: input must be y or n");
                                                    }
                                                }
                                                catch (Exception e)
                                                {
                                                    Console.Write("Error: input must be y or n\nselect (y/n) -> ");
                                                    choose = Convert.ToChar(Console.ReadLine());
                                                }
                                                if (choose == 'y' || choose == 'Y')
                                                {
                                                    Console.Write("Have fun with " + ((User)user[user.GetKey(i)]).getName + "\n");
                                                    i = user.Count + 1;
                                                }
                                            }
                                        }
                                    }
                                    if (choose == '0' || choose == 'n' || choose == 'N')
                                    {
                                        Console.Write("There is no one that you want\n");
                                    }
                                }
                                else if (typeF == 2)
                                {
                                    Console.Write("Choose age (choose 18-60) -> ");
                                    try
                                    {
                                        filter = Convert.ToInt32(Console.ReadLine());
                                        if (filter > 60 || filter < 18)
                                        {
                                            throw new ArithmeticException("Error: input must be 18-60");
                                        }
                                    }
                                    catch (Exception e)
                                    {
                                        Console.Write("Error: input must be 18-60\nselect (18-60) -> ");
                                        filter = Convert.ToInt32(Console.ReadLine());
                                    }
                                    ((User)user[name]).chooseFilter(typeF, filter);
                                    Age = ((User)user[name]).getfilter1(typeF);
                                    for (i = 0; i < user.Count; i++)
                                    {
                                        if (((User)user[user.GetKey(i)]).getName == name)
                                        { }
                                        else
                                        {
                                            age = ((User)user[user.GetKey(i)]).getAge;
                                            if (Age == age)
                                            {
                                                ((User)user[user.GetKey(i)]).showProfile();
                                                Console.Write("Do you want to chat with this person? (y/n) -> ");
                                                try
                                                {
                                                    choose = Convert.ToChar(Console.ReadLine());
                                                    if (choose != 'y' && choose != 'Y' && choose != 'n' && choose != 'N')
                                                    {
                                                        throw new ArithmeticException("Error: input must be y or n");
                                                    }
                                                }
                                                catch (Exception e)
                                                {
                                                    Console.Write("Error: input must be y or n\nselect (y/n) -> ");
                                                    choose = Convert.ToChar(Console.ReadLine());
                                                }
                                                if (choose == 'y' || choose == 'Y')
                                                {
                                                    Console.Write("Have fun with " + ((User)user[user.GetKey(i)]).getName + "\n");
                                                    i = user.Count + 1;
                                                }
                                            }
                                        }
                                    }
                                    if (choose == '0' || choose == 'n' || choose == 'N')
                                    {
                                        Console.Write("There is no one that you want\n");
                                    }
                                }
                                else if (typeF == 3)
                                {
                                    Console.Write("Choose filter education\n1. Less than Highschool\n2. Highschool\n3. Some college but no degree" +
                                    "\n4. Associate\n5. Bachelor's\n6. Graduate degree\n-> ");
                                    try
                                    {
                                        filter = Convert.ToInt32(Console.ReadLine());
                                        if (filter > 6 || filter < 1)
                                        {
                                            throw new ArithmeticException("Error: input must be 1-6");
                                        }
                                    }
                                    catch (Exception e)
                                    {
                                        Console.Write("Error: input must be 1-6\nselect (1-6) -> ");
                                        filter = Convert.ToInt32(Console.ReadLine());
                                    }
                                    ((User)user[name]).chooseFilter(typeF, filter);
                                    Education = ((User)user[name]).getfilter1(typeF);
                                    for (i = 0; i < user.Count; i++)
                                    {
                                        if (((User)user[user.GetKey(i)]).getName == name)
                                        { }
                                        else
                                        {
                                            education = ((User)user[user.GetKey(i)]).getEducation;
                                            if (Education == education)
                                            {
                                                ((User)user[user.GetKey(i)]).showProfile();
                                                Console.Write("Do you want to chat with this person? (y/n) -> ");
                                                try
                                                {
                                                    choose = Convert.ToChar(Console.ReadLine());
                                                    if (choose != 'y' && choose != 'Y' && choose != 'n' && choose != 'N')
                                                    {
                                                        throw new ArithmeticException("Error: input must be y or n");
                                                    }
                                                }
                                                catch (Exception e)
                                                {
                                                    Console.Write("Error: input must be y or n\nselect (y/n) -> ");
                                                    choose = Convert.ToChar(Console.ReadLine());
                                                }
                                                if (choose == 'y' || choose == 'Y')
                                                {
                                                    Console.Write("Have fun with " + ((User)user[user.GetKey(i)]).getName + "\n");
                                                    i = user.Count + 1;
                                                }
                                            }
                                        }
                                    }
                                    if (choose == '0' || choose == 'n' || choose == 'N')
                                    {
                                        Console.Write("There is no one that you want\n");
                                    }
                                }
                                else if (typeF == 4)
                                {
                                    Console.Write("Choose filter career\n1. Student\n2. Teacher\n3. Professor\n4. Judge\n5. Soilder\n" +
                                    "6. Doctor\n7. Farmer\n8. Labor\n9. Scientist\n10. Merchant\n11. Dentist\n" +
                                    "12. Engineer\n13. Politician\n14. Freelancer\n15. etc.\n-> ");
                                    try
                                    {
                                        filter = Convert.ToInt32(Console.ReadLine());
                                        if (filter > 15 || filter < 1)
                                        {
                                            throw new ArithmeticException("Error: input must be 1-15");
                                        }
                                    }
                                    catch (Exception e)
                                    {
                                        Console.Write("Error: input must be 1-15\nselect (1-15) -> ");
                                        filter = Convert.ToInt32(Console.ReadLine());
                                    }
                                    ((User)user[name]).chooseFilter(typeF, filter);
                                    Career = ((User)user[name]).getfilter1(typeF);
                                    for (i = 0; i < user.Count; i++)
                                    {
                                        if (((User)user[user.GetKey(i)]).getName == name)
                                        { }
                                        else
                                        {
                                            career = ((User)user[user.GetKey(i)]).getCareer;
                                            if (Career == career)
                                            {
                                                ((User)user[user.GetKey(i)]).showProfile();
                                                Console.Write("Do you want to chat with this person? (y/n) -> ");
                                                try
                                                {
                                                    choose = Convert.ToChar(Console.ReadLine());
                                                    if (choose != 'y' && choose != 'Y' && choose != 'n' && choose != 'N')
                                                    {
                                                        throw new ArithmeticException("Error: input must be y or n");
                                                    }
                                                }
                                                catch (Exception e)
                                                {
                                                    Console.Write("Error: input must be y or n\nselect (y/n) -> ");
                                                    choose = Convert.ToChar(Console.ReadLine());
                                                }
                                                if (choose == 'y' || choose == 'Y')
                                                {
                                                    Console.Write("Have fun with " + ((User)user[user.GetKey(i)]).getName + "\n");
                                                    i = user.Count + 1;
                                                }
                                            }
                                        }
                                    }
                                    if (choose == '0' || choose == 'n' || choose == 'N')
                                    {
                                        Console.Write("There is no one that you want\n");
                                    }
                                }
                                else if (typeF == 5)
                                {
                                    Console.Write("Choose filter zodiac\n1. Aries\n2. Taurus\n3. Gemini\n4. Cancer\n5. Leo\n6. Virgo\n" +
                                    "7. Libra\n8. Scorpio\n9. Sagittarius\n10. Capricorn\n11. Aquarius\n12. Pisces\n-> ");
                                    try
                                    {
                                        filter = Convert.ToInt32(Console.ReadLine());
                                        if (filter > 12 || filter < 1)
                                        {
                                            throw new ArithmeticException("Error: input must be 1-12");
                                        }
                                    }
                                    catch (Exception e)
                                    {
                                        Console.Write("Error: input must be 1-12\nselect (1-12) -> ");
                                        filter = Convert.ToInt32(Console.ReadLine());
                                    }
                                    ((User)user[name]).chooseFilter(typeF, filter);
                                    Zodiac = ((User)user[name]).getfilter1(typeF);
                                    for (i = 0; i < user.Count; i++)
                                    {
                                        if (((User)user[user.GetKey(i)]).getName == name)
                                        { }
                                        else
                                        {
                                            zodiac = ((User)user[user.GetKey(i)]).getZodiac;
                                            if (Zodiac == zodiac)
                                            {
                                                ((User)user[user.GetKey(i)]).showProfile();
                                                Console.Write("Do you want to chat with this person? (y/n) -> ");
                                                try
                                                {
                                                    choose = Convert.ToChar(Console.ReadLine());
                                                    if (choose != 'y' && choose != 'Y' && choose != 'n' && choose != 'N')
                                                    {
                                                        throw new ArithmeticException("Error: input must be y or n");
                                                    }
                                                }
                                                catch (Exception e)
                                                {
                                                    Console.Write("Error: input must be y or n\nselect (y/n) -> ");
                                                    choose = Convert.ToChar(Console.ReadLine());
                                                }
                                                if (choose == 'y' || choose == 'Y')
                                                {
                                                    Console.Write("Have fun with " + ((User)user[user.GetKey(i)]).getName + "\n");
                                                    i = user.Count + 1;
                                                }
                                            }
                                        }
                                    }
                                    if (choose == '0' || choose == 'n' || choose == 'N')
                                    {
                                        Console.Write("There is no one that you want\n");
                                    }
                                }
                                else if (typeF == 6)
                                {
                                    Console.Write("Choose filter blood type\n1. A\n2. B\n3. O\n4. AB\n-> ");
                                    try
                                    {
                                        filter = Convert.ToInt32(Console.ReadLine());
                                        if (filter > 4 || filter < 1)
                                        {
                                            throw new ArithmeticException("Error: input must be 1-4");
                                        }
                                    }
                                    catch (Exception e)
                                    {
                                        Console.Write("Error: input must be 1-4\nselect (1-4) -> ");
                                        filter = Convert.ToInt32(Console.ReadLine());
                                    }
                                    ((User)user[name]).chooseFilter(typeF, filter);
                                    BT = ((User)user[name]).getfilter1(typeF);
                                    for (i = 0; i < user.Count; i++)
                                    {
                                        if (((User)user[user.GetKey(i)]).getName == name)
                                        { }
                                        else
                                        {
                                            bt = ((User)user[user.GetKey(i)]).getBloodType;
                                            if (BT == bt)
                                            {
                                                ((User)user[user.GetKey(i)]).showProfile();
                                                Console.Write("Do you want to chat with this person? (y/n) -> ");
                                                try
                                                {
                                                    choose = Convert.ToChar(Console.ReadLine());
                                                    if (choose != 'y' && choose != 'Y' && choose != 'n' && choose != 'N')
                                                    {
                                                        throw new ArithmeticException("Error: input must be y or n");
                                                    }
                                                }
                                                catch (Exception e)
                                                {
                                                    Console.Write("Error: input must be y or n\nselect (y/n) -> ");
                                                    choose = Convert.ToChar(Console.ReadLine());
                                                }
                                                if (choose == 'y' || choose == 'Y')
                                                {
                                                    Console.Write("Have fun with " + ((User)user[user.GetKey(i)]).getName + "\n");
                                                    i = user.Count + 1;
                                                }
                                            }
                                        }
                                    }
                                    if (choose == '0' || choose == 'n' || choose == 'N')
                                    {
                                        Console.Write("There is no one that you want\n");
                                    }
                                }
                                else if (typeF == 7)
                                {
                                    Console.Write("Choose filter personality\n1. The Architect\n2. The Thinker\n3. The Advocate\n4. The Mediator\n5. The Inspector" +
                                        "\n6. The Crafter\n7. The Protector\n8. The Artist\n9. The Commander\n10. The Debater\n11. The Giver" +
                                        "\n12. The Champion\n13. The Director\n14. The Persuader\n15. The Caregiver\n16. The Performer\n-> ");
                                    try
                                    {
                                        filter = Convert.ToInt32(Console.ReadLine());
                                        if (filter > 16 || filter < 1)
                                        {
                                            throw new ArithmeticException("Error: input must be 1-16");
                                        }
                                    }
                                    catch (Exception e)
                                    {
                                        Console.Write("Error: input must be 1-16\nselect (1-16) -> ");
                                        filter = Convert.ToInt32(Console.ReadLine());
                                    }
                                    ((User)user[name]).chooseFilter(typeF, filter);
                                    Personality = ((User)user[name]).getfilter2();
                                    for (i = 0; i < user.Count; i++)
                                    {
                                        if (((User)user[user.GetKey(i)]).getName == name)
                                        { }
                                        else
                                        {
                                            personality = ((User)user[user.GetKey(i)]).getPersonality;
                                            if (Personality == personality)
                                            {
                                                ((User)user[user.GetKey(i)]).showProfile();
                                                Console.Write("Do you want to chat with this person? (y/n) -> ");
                                                try
                                                {
                                                    choose = Convert.ToChar(Console.ReadLine());
                                                    if (choose != 'y' && choose != 'Y' && choose != 'n' && choose != 'N')
                                                    {
                                                        throw new ArithmeticException("Error: input must be y or n");
                                                    }
                                                }
                                                catch (Exception e)
                                                {
                                                    Console.Write("Error: input must be y or n\nselect (y/n) -> ");
                                                    choose = Convert.ToChar(Console.ReadLine());
                                                }
                                                if (choose == 'y' || choose == 'Y')
                                                {
                                                    Console.Write("Have fun with " + ((User)user[user.GetKey(i)]).getName + "\n");
                                                    i = user.Count + 1;
                                                }
                                            }
                                        }
                                    }
                                    if (choose == '0' || choose == 'n' || choose == 'N')
                                    {
                                        Console.Write("There is no one that you want\n");
                                    }
                                }
                                ((User)user[name]).increasej();
                                choose = '0';
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Your name didn't register in the program.");
                    }
                }
                else if (ch == 3)
                {
                    Console.Write("Enter your name -> ");
                    name = Console.ReadLine();
                    if (user.Contains(name) == true)
                    {
                        Console.Write("Who do you want to arrange a meeting with? -> ");
                        fname = Console.ReadLine();
                        if (user.Contains(fname) == true)
                        {
                            if (name == fname)
                                Console.WriteLine("You cannot send meeting request to yourself.");
                            else
                            {
                                Console.Write("Input year -> ");
                                try
                                {
                                    year = Convert.ToInt32(Console.ReadLine());
                                    if (DateTime.Now.Year > year)
                                    {
                                        throw new ArithmeticException("Error: You cannot input year that passed");
                                    }
                                }
                                catch (Exception e)
                                {
                                    Console.Write("Error: You cannot input year that passed\nInput year -> ");
                                    year = Convert.ToInt32(Console.ReadLine());
                                }
                                Console.Write("Input month -> ");
                                try
                                {
                                    month = Convert.ToInt32(Console.ReadLine());
                                    if (DateTime.Now.Year == year && DateTime.Now.Month > month||month>12||month<1)
                                    {
                                        throw new ArithmeticException("Error: You cannot input month that passed");
                                    }
                                }
                                catch (Exception e)
                                {
                                    Console.Write("Error: You cannot input month that passed and you can input only 1-12\nInput month(1-12) -> ");
                                    month = Convert.ToInt32(Console.ReadLine());
                                }
                                Console.Write("Input day -> ");
                                try
                                {
                                    day = Convert.ToInt32(Console.ReadLine());
                                    if (DateTime.Now.Year == year && DateTime.Now.Month == month && DateTime.Now.Day > day||day>31||day<1)
                                    {
                                        throw new ArithmeticException("Error: You cannot input day that passed and you can input only 1-31");
                                    }
                                }
                                catch (Exception e)
                                {
                                    Console.Write("Error: You cannot input day that passed and you can input only 1-31\nInput day(1-31) -> ");
                                    day = Convert.ToInt32(Console.ReadLine());
                                }
                                Console.Write("Input hour (0-23) -> ");
                                try
                                {
                                    hour = Convert.ToInt32(Console.ReadLine());
                                    if (hour > 23 || hour < 0)
                                    {
                                        throw new ArithmeticException("Error: input must be 0-23");
                                    }
                                }
                                catch (Exception e)
                                {
                                    Console.Write("Error: input must be 0-23\nselect (0-23) -> ");
                                    hour = Convert.ToInt32(Console.ReadLine());
                                }
                                Console.Write("Input minute (0-59) -> ");
                                try
                                {
                                    min = Convert.ToInt32(Console.ReadLine());
                                    if (min > 59 || min < 0)
                                    {
                                        throw new ArithmeticException("Error: input must be 0-59");
                                    }
                                }
                                catch (Exception e)
                                {
                                    Console.Write("Error: input must be 0-23\nselect (0-59) -> ");
                                    min = Convert.ToInt32(Console.ReadLine());
                                }
                                meetday = new DateTime(year, month, day, hour, min, 00);
                                Console.Write("Where do you want to arrange a meeting? -> ");
                                place = Console.ReadLine();
                                ((User)user[name]).createMeeting(name, fname, meetday, place);
                                ((User)user[fname]).createRequest(fname, name, meetday, place);
                                Console.WriteLine("You have arrange a meeting with " + fname + " at " + place + " " + meetday);
                            }
                        }
                        else
                        {
                            Console.WriteLine("This name didn't register in the program.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Your name didn't register in the program.");
                    }
                }
                else if (ch == 4)
                {
                    Console.Write("Enter your name -> ");
                    name = Console.ReadLine();
                    if (user.Contains(name) == true)
                    {
                        Console.Write("Would​ you like to view your 'sent meeting request status'​ or your 'received meeting request'? \n(s/r) -> ");
                        try
                        {
                            choice = Convert.ToChar(Console.ReadLine());
                            if (choice != 's' && choice != 'S' && choice != 'r' && choice != 'R')
                            {
                                throw new ArithmeticException("Error: input must be s or r");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write("Error: input must be s or r\nselect (s/r) -> ");
                            choice = Convert.ToChar(Console.ReadLine());
                        }
                        if (choice == 's'|| choice == 'S')
                        {
                            ((User)user[name]).showMeeting();
                        }
                        else
                        {
                            reqcount=((User)user[name]).showRequest();
                            if (reqcount > 0)
                            {
                                Console.Write("Which request do you want to look -> ");
                                try
                                {
                                    request = Convert.ToInt32(Console.ReadLine());
                                    if (request > reqcount || request < 1)
                                    {

                                        throw new ArithmeticException("Error: input must be 1-" + reqcount);
                                    }
                                }
                                catch (Exception e)
                                {
                                    Console.Write("Error: input must be 1-" + reqcount + "\nselect (1-" + reqcount + ") -> ");
                                    request = Convert.ToInt32(Console.ReadLine());
                                }
                                if (((User)user[name]).getStatus(request) == "Meeting success" || ((User)user[name]).getStatus(request) == "Meeting fail")
                                {
                                    Console.WriteLine("This request is already complete");
                                }
                                else
                                {
                                    fname = ((User)user[name]).showSpecific(request);
                                    Console.Write("Do you want to accept this request (y/n) -> ");
                                    try
                                    {
                                        ans = Convert.ToChar(Console.ReadLine());
                                        if (ans != 'y' && ans != 'Y' && ans != 'n' && ans != 'N')
                                        {
                                            throw new ArithmeticException("Error: input must be y or n");
                                        }
                                    }
                                    catch (Exception e)
                                    {
                                        Console.Write("Error: input must be y or n\nselect (y/n) -> ");
                                        ans = Convert.ToChar(Console.ReadLine());
                                    }
                                    ((User)user[name]).changeStatusRequest(request, ans);
                                    ((User)user[fname]).changeStatusMeeting(name, ans);
                                    ((User)user[name]).showRequest();
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Your name didn't register in the program.");
                    }

                }
                Console.WriteLine("menu\n1. Register\n" +
                "2. choose friend\n3. Arrange a meeting\n4. check request meeting " +
                "\n5. Exit");
                try
                {
                    ch = Convert.ToInt32(Console.ReadLine());
                    if (ch > 5 || ch < 1)
                    {
                        throw new ArithmeticException("Error: input must be 1-5");
                    }
                }
                catch (Exception e)
                {
                    Console.Write("Error: input must be 1-5\nselect (1-5) -> ");
                    ch = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
