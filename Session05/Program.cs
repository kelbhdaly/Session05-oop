using Session05.Interface;
using Type = Session05.Interface.Type;

namespace Session05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IType type;
            //Declare From Reference From Type "IType"
            //This Reference Can Refer To An Object From Any Type That Implement Interface "IType
            //ClR Will Allocted 4 Bytes At Stack Referances "

            //type = new Type();
            //type.MyProperty = 5;
            //type.MyMethod();
            //type.Func();


            //Type typeObject = new Type();
            //typeObject.MyProperty = 5;
            //typeObject.MyMethod();
            //typeObject.Func(); //invalid
        }
    }
}
