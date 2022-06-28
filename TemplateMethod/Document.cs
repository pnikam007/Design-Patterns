using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class Document
    {
        public void PrintDocument()
        {
            this.PrintHeader();
            this.PrintBody();
            this.PrintFooter();
        }

        protected void PrintHeader()
        {
            Console.WriteLine("---------- Common Header ------------");
        }
        protected abstract void PrintBody();
        protected abstract void PrintFooter();
    }
}
