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



        }
    }
}