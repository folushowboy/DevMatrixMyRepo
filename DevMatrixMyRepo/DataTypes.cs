using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    internal class DataTypes
    {
        public void DataTypesInfo()
        {
            // int -> 4 bytes (32 bits) -2,147,483,648 to 2,147,483,647
            // long -> 8 bytes (64 bits) -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            // float -> 4 bytes (32 bits) -3.402823e38 to 3.402823e38
            // double -> 8 bytes (64 bits) -1.7976931348623157e308 to 1.7976931348623157e308
            // decimal -> 16 bytes (128 bits) -7.9228e-28 to 7.9228e28
            // char -> 2 bytes (16 bits) -0 to 65535
            // bool -> 1 byte (8 bits) true or false
            // string -> reference type, can hold a sequence of characters, can be null
            // byte -> 1 byte (8 bits) 0 to 255
            // guid -> 16 bytes (128 bits) globally unique identifier - 32 figures

            int x = 10;
            long y = 20;
            float z = 3.14f;
            double a = 3.14159265358979323846;
            decimal b = 3.1415926535897932384626433832m;
            char c = 'A';
            bool d = true;
            string e = "Hello, World!";
            byte f = 255;
            Guid g = Guid.NewGuid();

            //Implicit Conversion: converting a smaller data type to a larger data type (e.g., int to long)
            int i = 233;
            long j = i; // implicit conversion from int to long
            Console.WriteLine(j);

            // Explicit Conversion: converting a larger data type to a smaller data type (e.g., long to int)
            decimal k = 134.64670m;
            int v = (int)k;
            Console.WriteLine(v);
        }
    }
}
