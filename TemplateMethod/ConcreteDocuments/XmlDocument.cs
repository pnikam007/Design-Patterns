using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.ConcreteDocuments
{
    public class XmlDocument : Document
    {

        protected override void PrintBody()
        {
            Console.WriteLine("------------------ XML Body Start ------------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("------------------ XML Body End ------------");
        }

        protected override void PrintFooter()
        {
            Console.WriteLine("------------------ XML Footer Start ------------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("------------------ XML Footer End ------------");
        }

        //protected override void PrintHeader()
        //{
        //    Console.WriteLine("------------------ XML Header Start ------------");
        //    Console.WriteLine("--------------------------------------------------");
        //    Console.WriteLine("------------------ XML Header End ------------");
        //}
    }
}
