using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            AirTicket();
        }

        static void Welcome()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("ΚΑΛΩΣ ΗΡΘΑΤΕ ΣΤΗΝ ΑΕΡΟΠΟΡΙΚΗ ΕΤΑΙΡΙΑ SKYFLY");
            Console.ResetColor();
            Console.WriteLine();
        }

        static string withOrWithoutReturn()
        {
            Console.WriteLine("ΕΠΙΛΕΞΤΕ ΕΝΑ ΑΠΟ ΤΑ ΠΑΡΑΚΑΤΩ");
            Console.WriteLine();
            Console.WriteLine("ΓΙΑ ΑΠΛΗ ΜΕΤΑΒΑΣΗ ΕΠΙΛΕΞΤΕ : 1");
            Console.WriteLine("ΓΙΑ ΜΕΤΑΒΑΣΗ ΜΕ ΕΠΙΣΤΡΟΦΗ ΕΠΙΛΕΞΤΕ : 2");
            string choice = Console.ReadLine();
            return choice;
        }

        static void AirportsDates(string choice)
        {
            string airportGo;
            string airportArrival;
            string AirportGoReturn;
            string AirportArrivalReturn;
            string dateGo;
            string dateReturn;

            if (choice == "1")
            {
                Console.Write("ΕΠΙΛΕΞΤΕ ΑΕΡΟΔΡΟΜΙΟ ΑΝΑΧΩΡΗΣΗΣ : ");
                airportGo = Console.ReadLine().ToUpper();
                Console.WriteLine();
                Console.Write("ΕΠΙΛΕΞΤΕ ΑΕΡΟΔΡΟΜΙΟ ΑΦΙΞΗΣ : ");
                airportArrival = Console.ReadLine().ToUpper();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("ΗΜΕΡΟΜΗΝΙΕΣ");
                Console.ResetColor();
                Console.WriteLine();
                Console.Write("ΕΠΙΛΕΞΤΕ ΗΜΕΡΟΜΗΝΙΑ ΑΝΑΧΩΡΗΣΗΣ : ");
                dateGo = Console.ReadLine().ToUpper();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("ΠΤΗΣΗ");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine($"{airportGo}-{airportArrival}  {dateGo}");
            }
            else if (choice == "2")
            {

                Console.Write("ΕΠΙΛΕΞΤΕ ΑΕΡΟΔΡΟΜΙΟ ΑΝΑΧΩΡΗΣΗΣ : ");
                airportGo = Console.ReadLine().ToUpper();
                Console.WriteLine();
                Console.Write("ΕΠΙΛΕΞΤΕ ΑΕΡΟΔΡΟΜΙΟ ΑΦΙΞΗΣ : ");
                airportArrival = Console.ReadLine().ToUpper();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("ΕΠΙΣΤΡΟΦΗ");
                Console.ResetColor();
                Console.WriteLine();
                Console.Write("ΕΠΙΛΕΞΤΕ ΑΕΡΟΔΡΟΜΙΟ ΑΝΑΧΩΡΗΣΗΣ : ");
                AirportGoReturn = Console.ReadLine().ToUpper();
                Console.WriteLine();
                Console.Write("ΕΠΙΛΕΞΤΕ ΑΕΡΟΔΡΟΜΙΟ ΑΦΙΞΗΣ : ");
                AirportArrivalReturn = Console.ReadLine().ToUpper();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("ΗΜΕΡΟΜΗΝΙΕΣ");
                Console.ResetColor();
                Console.WriteLine();
                Console.Write("ΕΠΙΛΕΞΤΕ ΗΜΕΡΟΜΗΝΙΑ ΑΝΑΧΩΡΗΣΗΣ : ");
                dateGo = Console.ReadLine().ToUpper();
                Console.WriteLine();
                Console.Write("ΕΠΙΛΕΞΤΕ ΗΜΕΡΟΜΗΝΙΑ ΕΠΙΣΤΡΟΦΗΣ : ");
                dateReturn = Console.ReadLine().ToUpper();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("ΠΤΗΣΕΙΣ");
                Console.ResetColor();
                Console.WriteLine($"{airportGo}-{airportArrival}  {dateGo}");
                Console.WriteLine();
                Console.WriteLine($"{AirportGoReturn}-{AirportArrivalReturn}  {dateReturn}");
                Console.WriteLine();
            }
        }
        
        static string ticketWithReturnOrNot()
        {
            string ticketReturnOrNot;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("ΕΠΙΛΕΞΤΕ ΕΙΣΙΤΗΡΙΟ ΑΝΑΧΩΡΗΣΗΣ ΚΑΙ ΕΠΙΣΤΡΟΦΗΣ");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("1 - ΑΠΛΗ ΜΕΤΑΒΑΣΗ");
            Console.WriteLine("2 - ΜΕ ΕΠΙΣΤΡΟΦΗ");
            Console.WriteLine();
            Console.Write("ΕΠΙΛΕΞΤΕ : ");
            ticketReturnOrNot = Console.ReadLine();
            return ticketReturnOrNot;
        }
        static void Prices(string choice)
        {
            Random priceGo = new Random();
            Random priceReturn = new Random();
                      
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ΚΑΤΗΓΟΡΙΕΣ ΕΙΣΙΤΗΡΙΩΝ ");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("1 - LIGHT (1 ΧΕΙΡΑΠΟΣΚΕΥΗ)");
            Console.WriteLine("2 - FLEX (1 ΧΕΙΡΑΠΟΣΚΕΥΗ ΚΑΙ ΕΝΑ ΣΑΚΙΔΙΟ ΠΛΑΤΗΣ)");
            Console.WriteLine("3 - COMFORTFLEX (1 ΧΕΙΡΑΠΟΣΚΕΥΗ ΕΝΑ ΣΑΚΙΔΙΟ ΠΛΑΤΗΣ ΚΑΙ ΜΙΑ ΑΠΟΣΚΕΥΗ 15 ΚΙΛΑ)");
            Console.WriteLine();
            
            if (choice == "1") {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("ΕΠΙΛΕΞΤΕ ΕΙΣΙΤΗΡΙΟ ΜΕΤΑΒΑΣΗΣ : ");
                Console.ResetColor();
                Console.WriteLine();
                string ticketCostGo = Console.ReadLine();
                switch (ticketCostGo)
                {
                    case "1": Console.WriteLine($"ΤΙΜΗ LIGTH = {priceGo.Next(50, 100)}"); break;
                    case "2": Console.WriteLine($"ΤΙΜΗ FLEX = {priceGo.Next(100, 150)}"); break;
                    case "3": Console.WriteLine($"ΤΙΜΗ COMFORTFLEX = {priceGo.Next(150, 200)}"); break;

                    default:
                        break;
                }

            }
            if (choice == "2")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("ΕΠΙΛΕΞΤΕ ΕΙΣΙΤΗΡΙΟ ΜΕΤΑΒΑΣΗΣ : ");
                Console.ResetColor();               
                string ticketGo = Console.ReadLine();
                switch (ticketGo)
                {
                    case "1": Console.WriteLine($"ΤΙΜΗ LIGTH = {priceGo.Next(50, 100)}"); break;
                    case "2": Console.WriteLine($"ΤΙΜΗ FLEX = {priceGo.Next(100, 150)}"); break;
                    case "3": Console.WriteLine($"ΤΙΜΗ COMFORTFLEX = {priceGo.Next(150, 200)}"); break;

                    default:
                        break;
                }
                Console.WriteLine();
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("ΕΠΙΛΕΞΤΕ ΕΙΣΙΤΗΡΙΟ ΕΠΙΣΤΡΟΦΗΣ : ");
                Console.ResetColor();
                string tickeReturn = Console.ReadLine();
                switch (tickeReturn)
                {
                    case "1": Console.WriteLine($"ΤΙΜΗ LIGTH = {priceReturn.Next(50, 100)}"); break;
                    case "2": Console.WriteLine($"ΤΙΜΗ FLEX = {priceReturn.Next(100, 150)}"); break;
                    case "3": Console.WriteLine($"ΤΙΜΗ COMFORTFLEX = {priceReturn.Next(150, 200)}"); break;

                    default:
                        break;
                }
            }
        }
        static void personalInfo()
        {
            string name;
            string lastName;
            string birthday;
            string phone;
            string address;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("ΠΑΡΑΚΑΛΩ ΣΥΜΠΛΗΡΩΣΤΕ ΤΑ ΣΤΟΙΧΕΙΑ ΣΑΣ");
            Console.ResetColor();
            Console.WriteLine();
            Console.Write("ΟΝΟΜΑ : ");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("ΕΠΙΘΕΤΟ : ");
            lastName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("ΤΗΛΕΦΩΝΟ : ");
            phone = Console.ReadLine();
            Console.WriteLine();
            Console.Write("ΗΜΕΡΟΜΗΝΙΑ ΓΕΝΝΗΣΗΣ(ηη/μμ/εεεε) : ");
            birthday = Console.ReadLine();
            Console.WriteLine();
            Console.Write("ΔΙΕΥΘΥΝΣΗ (ΟΔΟΣ-ΑΡΙΘΜΟΣ-ΠΟΛΗ) : ");
            address = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("ΤΑ ΣΤΟΙΧΕΙΑ ΣΑΣ");
            Console.ResetColor();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("ΟΝΟΜΑ : ");
            Console.ResetColor();
            Console.WriteLine(name);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("ΕΠΙΘΕΤΟ : ");
            Console.ResetColor();
            Console.WriteLine(lastName);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("ΤΗΛΕΦΩΝΟ : ");
            Console.ResetColor();
            Console.WriteLine(phone);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("ΗΜΕΡΟΜΗΝΙΑ ΓΕΝΝΗΣΗΣ : ");
            Console.ResetColor();
            Console.WriteLine(birthday);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("ΔΙΕΥΘΥΝΣΗ (ΟΔΟΣ-ΑΡΙΘΜΟΣ-ΠΟΛΗ) : ");
            Console.ResetColor();
            Console.WriteLine(address);
            Console.WriteLine();
            Console.WriteLine();
        }

        static void Greetings()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("ΕΙΣΑΣΤΕ ΕΤΟΙΜΟΙ!!!");
            Console.WriteLine();
            Console.WriteLine("ΕΥΧΑΡΙΣΤΟΥΜΕ ΠΟΥ ΕΠΙΛΕΞΑΤΕ ΤΗΝ SKYFLY");
            Console.WriteLine();
            Console.WriteLine("ΣΑΣ ΕΥΧΟΜΑΣΤΕ ΚΑΛΗ ΣΥΝΕΧΕΙΑ");
            Console.ResetColor();
        }

        static void AirTicket()
        {
            Welcome();
            string selectTicket = withOrWithoutReturn();
            AirportsDates(selectTicket);
            string ticketWithReturn = ticketWithReturnOrNot();
            Prices(ticketWithReturn);
            personalInfo();
            Greetings();
        }
    }
}