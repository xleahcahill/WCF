using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace LeahCahill_AssignmentTwo_WCF
{
    [ServiceContract(CallbackContract = typeof(Iitem))]
    public interface Iitem
    {
        [OperationContract(IsOneWay = true)]
        void SendItem1(string item);

        [OperationContract(IsOneWay = true)]
        void SendItem2(string item2);

        [OperationContract(IsOneWay = true)]
        void SendItem3(string item3);

        [OperationContract(IsOneWay = true)]
        void SendItem4(string item4);

        [OperationContract(IsOneWay = true)]
        void Item1Price(int price1);

        [OperationContract(IsOneWay = true)]
        void Item2Price(int price2);

        [OperationContract(IsOneWay = true)]
        void Item3Price(int price3);

        [OperationContract(IsOneWay = true)]
        void Item4Price(int price4);
    }



    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    class store : Iitem
    {
        Form1 mfp;

        public store(Form1 mfp)
        {
            this.mfp = mfp;
        }


        public void Item1Price(int price1)
        {
            mfp.AddPrice1("10"); // Price of book
        }

        public void Item2Price(int price2)
        {
            mfp.AddPrice2("15"); // price of CD
        }

        public void Item3Price(int price3) // price of DVD
        {
            mfp.AddPrice3("8");
        }

        public void Item4Price(int price4) // price of lamp
        {
            mfp.AddPrice4("20");
        }

        public void SendItem1(string item)
        {
            mfp.AddItem(item); //book 
           
        }

        public void SendItem2(string item2)
        {
            mfp.AddItem2(item2); // CD
        }

        public void SendItem3(string item3)
        {
            mfp.AddItem3(item3); // dvd
        }

        public void SendItem4(string item4)
        {
            mfp.AddItem4(item4); //lamp
        }
    }
}
