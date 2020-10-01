using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
//using System.Runtime.Serialization.Formatters.Soap;

namespace _Serialize
{
  class Program
  {
    static void Main(string[] args)
    {
      //string data = "This must be stored in a file."; //1

      //FileStream fs1 = new FileStream("SerializedString.Data", FileMode.Create);

      //BinaryFormatter bf1 = new BinaryFormatter();

      //bf1.Serialize(fs1, data);

      //fs1.Close();

      //FileStream fs2 = new FileStream("SerializedDate.Data", FileMode.Create); //2

      //SoapFormatter bf2 = new SoapFormatter();

      //var obj2 = new ShoppingCartItem(1, 100, 10);

      //bf2.Serialize(fs2, obj2);

      //fs2.Close();

      //FileStream fs3 = new FileStream("SerializedString.Data", FileMode.Open); //3

      //BinaryFormatter bf3 = new BinaryFormatter();

      //string data3 = "";

      //data3 = (string)bf3.Deserialize(fs3);

      //fs3.Close();

      //Console.WriteLine(data3);

      //FileStream fs = new FileStream("SerializedDate.Data", FileMode.Open); //4

      //SoapFormatter bf = new SoapFormatter();

      //ShoppingCartItem obj = (ShoppingCartItem)bf.Deserialize(fs);

      //fs.Close();
    }
  }
}