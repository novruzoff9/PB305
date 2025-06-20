using System.Text;

namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            string email = "yagmurgn@gmail.com";
            CheckMail(email);

            //Task 2
            string email = "test.user@code.edu.az";
            string domain = FixEmail(ref email);
            Console.WriteLine(email);
            Console.WriteLine(domain);

            //Task 3
            string wreckedNames = "?yX?N;F?tEH;yuSif;k?MR?n";
            Console.WriteLine(RepairNames(wreckedNames));
        }

        public static string RepairNames(string names)
        {
            names = names.ToLower();
            names = names.Replace('?', 'a');
            string[] nameArr = names.Split(';');
            for (int i = 0; i < nameArr.Length; i++)
            {
                nameArr[i] = nameArr[i].Substring(0, 1).ToUpper() + nameArr[i].Substring(1);
                //ayxan = A + yxan
            }
            string result = string.Join(',', nameArr);

            return result;
        }

        public static string FixEmail(ref string email)
        {
            int index = email.IndexOf('@');
            string domain = email.Substring(index + 1);
            email = email.Substring(0, index);
            return domain;
        }

        public static bool CheckMail(string email)
        {
            bool dogruMail = false;
            if (string.IsNullOrWhiteSpace(email))
            {
                Console.WriteLine("Gelen deyer bosdur");
            }
            if (email.Contains('@'))
            {
                int index = email.IndexOf('@');
                string domain = email.Substring(index);
                if (domain.Contains('.'))
                {
                    dogruMail = true;
                }
                else
                {
                    dogruMail = false;
                }
            }
            else
            {
                dogruMail = false;
            }
            return dogruMail;
        }
    }
}
