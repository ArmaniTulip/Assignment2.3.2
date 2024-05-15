namespace Assignment2._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {



            string billTotalInput = "";
            string tipPercentageInput = "";
            decimal billTotal = 0;
            decimal tipPercentage = 0;




            bool isValidInput = false;
            while (!isValidInput)
            {
                Console.Write("Enter the bill total: ");
                billTotalInput = Console.ReadLine();
                try
                {
                    billTotal = Convert.ToDecimal(billTotalInput);
                    isValidInput = true;
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter a valid number for the bill total.");
                }
            }




            isValidInput = false;
            while (!isValidInput)
            {
                Console.Write("Enter the tip percentage: ");
                tipPercentageInput = Console.ReadLine();
                try
                {
                    tipPercentage = Convert.ToDecimal(tipPercentageInput);
                    isValidInput = true;
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter a valid number for the tip percentage.");
                }
            }




            decimal tipAmount = (tipPercentage / 100) * billTotal;

            decimal grandTotal = billTotal + tipAmount;

            Console.WriteLine("Bill Total: {0:C}", billTotal);
            Console.WriteLine("Tip Percentage: {0:P}", tipPercentage / 100); 
            Console.WriteLine("Tip Amount: {0:C}", tipAmount);
            Console.WriteLine("Grand Total: {0:C}", grandTotal);
        }
    }
}
