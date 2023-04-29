namespace BrojanjeStringa
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string strSource = "";
            int nCount = 0;

            Console.WriteLine("Molimo vas da upisete zeljeni string: ");
            strSource = Console.ReadLine();

            foreach (char c in strSource)
            {
                nCount = nCount + 1;
            }

            Console.WriteLine("{0} length is {1}", strSource, nCount.ToString());
            Console.ReadLine();


        }
    }
}