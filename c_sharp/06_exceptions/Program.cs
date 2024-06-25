namespace _c_sharp_
{
    class Program
    {
        public class CreditCard
        {
            private string name;

            public string Name
            {
                get { return name; }
                set { name = (!string.IsNullOrWhiteSpace(value) && !string.IsNullOrEmpty(value)) ? value : throw new Exception(); }
            }
            private string lastName;

            public string LastName
            {
                get { return name; }
                set { name = (!string.IsNullOrWhiteSpace(value) && !string.IsNullOrEmpty(value)) ? value : throw new Exception(); }
            }

            private string cardNumber;

            public string CardNumber
            {
                get { return cardNumber; }
                set { cardNumber = (value.Length == 16) ? value : throw new Exception("There are 16 digits in card number."); }
            }
            private string cvcCode;

            public string CvcCode
            {
                get { return cvcCode; }
                set { cvcCode = (value.Length == 3) ? value : throw new Exception("There are 3 digits in cvc code."); }
            }
            private DateTime expirationDate;

            public DateTime ExpirationDate
            {
                get { return expirationDate; }
                set { expirationDate = (value>=DateTime.Now)?value:throw new Exception("Your card is expired"); }
            }
            public CreditCard()
            {
                Name = "Noname";
                LastName= "NoLastName";
                CardNumber = "0000000000000000";
                CvcCode= "000";
                ExpirationDate=new DateTime(1990,01,01);

            }
            public CreditCard(string name,string lastName,string cardNumber,string cvcCode,DateTime date)
            {
                Name = name;
                LastName = lastName;
                try
                {
                    CardNumber = cardNumber;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                try
                {
                    CvcCode = cvcCode;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                try
                {
                    ExpirationDate = date;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }


        }
        static void Main(string[] args)
        {
            // #1
            //try
            //{
            //    int number = int.Parse(Console.ReadLine());
            //}
            //catch (OverflowException e)
            //{
            //    Console.WriteLine("OverflowException");
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine("FormatException");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            // #2
            //Console.WriteLine("Enter name:");
            //string name=Console.ReadLine();
            //Console.WriteLine("Enter last name:");
            //string lastName=Console.ReadLine();
            //Console.WriteLine("Enter card number:");
            //string cardNumber=Console.ReadLine();
            //Console.WriteLine("Enter cvc code:");
            //string cvcCode=Console.ReadLine();
            //Console.WriteLine("Enter expiration date:");
            //DateTime date=DateTime.Parse(Console.ReadLine());
            //try
            //{
            //    CreditCard card = new CreditCard(name,lastName,cardNumber,cvcCode,date);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            Console.WriteLine("Enter a math expresion: ");
            string input=Console.ReadLine();
            try
            {
                string[] parts = input.Split('*');
                int result = 1;

                for (int i =0;i<parts.Length;i++)
                {
                    result *= int.Parse(parts[i]);
                }
                Console.WriteLine("Result: " + result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect format.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка: " + ex.Message);
            }
        }

        static int EvaluateExpression(string expr)
        {
            string[] parts = expr.Split('*');
            int result = 1;

            foreach (string part in parts)
            {
                result *= int.Parse(part.Trim());
            }

            return result;
        



    }
    }
}