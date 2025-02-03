using Session05.Interface;
using Session05.Interface_Example_01;
using Type = Session05.Interface.Type;

namespace Session05
{
    internal class Program
    {

        //static void PrintFiveSeries(ISeries series)
        //{
        //    if (series is not null)
        //    {
        //    }
        //    else return;
        //}
        static void Main(string[] args)
        {
            #region Interface
            //IType type;
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
            #endregion

            #region Interface Ex01
            //TypeA typeAObj = new TypeA();
            //PrintFiveSeries(typeAObj);
            //TypeB typeBObj = new TypeB();
            //PrintFiveSeries(typeBObj);


            #endregion
        }
    }
}
