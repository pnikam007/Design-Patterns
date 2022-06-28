using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.ConcreteDocuments
{
    public class HtmlDocument : Document
    {
        protected override void PrintBody()
        {
            Console.WriteLine("------------------ HTML Body Start ------------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("------------------ HTML Body End ------------");
        }

        protected override void PrintFooter()
        {
            Console.WriteLine("------------------ HTML Footer Start ------------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("------------------ HTML Footer End ------------");
        }

        //protected override void PrintHeader()
        //{
        //    Console.WriteLine("------------------ HTML Header Start ------------");
        //    Console.WriteLine("--------------------------------------------------");
        //    Console.WriteLine("------------------ HTML Header End ------------");
        //}
    }
}
