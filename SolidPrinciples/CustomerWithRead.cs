using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples
{
    class CustomerWithRead : IDataBase, IDataBaseV1
    {
        public void Add()
        {
            Console.WriteLine("Add Method");
        }

        public void Read()
        {
            Console.WriteLine("Read Method");
        }
    }
}
