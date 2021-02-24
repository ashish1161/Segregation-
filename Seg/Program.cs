using System;

namespace Seg
{
   public interface IPrint
    {
        public void print();
    }
    public interface IScan
    {
        public void scan();
    }
    public interface IFax
    {
        public void fax();
    }
    public class NewMachine : IScan , IPrint , IFax
    {
        public void scan()
        {
            Console.WriteLine("scan is done");
        }
        public void print()
        {
            Console.WriteLine("print is done");
        }
        public void fax()
        {
            Console.WriteLine("fax is done");
        }
    }
    public class OldMachine : IPrint
    {
        public void print()
        {
            Console.WriteLine("printed");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var n = new NewMachine();
            var o = new OldMachine();
            n.fax();
            n.print();
            n.scan();
            o.print();
        }
    }
}
