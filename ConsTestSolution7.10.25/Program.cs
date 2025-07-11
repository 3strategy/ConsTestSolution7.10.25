namespace ConsTestSolution7._10._25
{
    public class Program
    {

        /// <summary>
        /// י  25 מועמדים הגיעו לראיון עבודה
        ///   כתוב קטע תוכנית שיקלוט את מספר הזהות של כל מועמד ואת גילו, 
        ///   וידפיס את מספר הזהות של המועמד הצעיר ביותר.
        /// </summary>
        public static void MainQ1()
        {
            int youngestAge = int.MaxValue;
            int youngestId = 0;
            for (int i = 0; i < 25; i++)
            {
                Console.Write("Enter ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Enter age: ");
                int age = int.Parse(Console.ReadLine());

                if (age < youngestAge)
                {
                    youngestAge = age;
                    youngestId = id;
                }
            }
            Console.WriteLine(youngestId);
        }


        //Q2 = מעקב

        public static void MainQ2()
        {
            int m = 0;
            int x, a;
            x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (a < 10 || a > 99)
                    m++;
                else
                    Console.WriteLine(a / 10);
            }
            Console.WriteLine(m);
        }

        // Q3 קטע א סעיף א
        // ההוראה השגויה grade < 0
        // Q3 ב 
        // התיקון:  grade > 0
        // כי נדרש לצאת במקרה שמתקבל 0 או שלילי
        //
        // Q3 קטע ב'
        // סעיף א: ההוראה השגויה
        // double avg = (double)sum/count;
        // סעיף ב: התיקון
        // יש לרשום את ההוראה מחוץ ללולאה אחרת מתבצע חישוב מיותר בכל סיבוב של הלולאה
        // לא יהיה מוגדר מחוץ לללולאה - הקוד לא יתקמפל avg ובנוסף המשתנה 

        /// <summary>
        /// מזנון השבעים
        /// </summary>
        public static void MainQ4() 
        {
            int count = 0, price, discount;
            while (true)
            {
                Console.Write("Enter quantity: ");
                int qty = int.Parse(Console.ReadLine());
                if (qty == 0) // תנאי יציאה
                    break;
                count++; // ספירה ברגע שהקלט חוקי
                Console.Write("Enter type: cheese 0 / avocado 1: ");
                string name = Console.ReadLine(); // אפשר גם לקלוט לשלם
                if (name == "0")
                    price = 10;
                else
                    price = 12; // cheese אין צורך לבדוק תקינות קלט

                discount = qty >= 10 ? 20 : 0; // הנחת כמות עבור 10 ומעלה ternary operation
                // (אבל אין כמו ללמוד מדוגמא שפתרתם כבר - teranary לא למדנו)
                // רגילה if-else כמובן שניקוד מלא על כתיבה של
                Console.WriteLine($"total is : {price * qty - discount}");
                Console.WriteLine($"total V2 : {(name == "0" ? 10 : 12) * qty - (qty >= 10 ? 20 : 0)}");
            }
            Console.WriteLine(count); // בבחינה אין דרישה לחפירות בפלט. שווה להיות לקוני
        }

        /// <summary>
        /// שאלה 5 מספר מושלם
        /// מספר השווה לסכום כל מחלקיו (לא כולל המספר עצמו 
        /// סעיף א 6 = 1 + 2 + 3 ולכן הוא מספר מושלם
        /// </summary>
        public static void MainQ5()  // שאלה 5ב
        {
            Console.Write("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            int count = 1;
            for (int i = 2; i < num1; i++)
                if (num1 % i == 0) // מחלקים שלמים
                    count += i; // סכום המחלקים

            if (count == num1)
                Console.WriteLine($"{num1} is a perfect number.");
            else
                Console.WriteLine($"{num1} is not a perfect number.");
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Running question 1");
            MainQ1(); // שאלה 1 
            Console.WriteLine("Running question 4");
            MainQ4(); // שאלה 4
            Console.WriteLine("Running question 5");
            MainQ5(); // שאלה 5
        }
    }
}
