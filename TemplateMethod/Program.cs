using System;
using TemplateMethod.ConcreteDocuments;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Client.Printer(new XmlDocument());
            Console.WriteLine(Environment.NewLine);
            Client.Printer(new HtmlDocument());

            Console.ReadKey();
        }
    }
}
