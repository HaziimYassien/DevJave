namespace Dependancy_Injection_I_Hate_This_
{
    internal class DepInj
    {
    }
    public class MessageWriter
    {
        public void Write(string message)
        {

            Console.WriteLine($"MessageWriter.Write(message: \"{message}\")");

        }
    }
}
