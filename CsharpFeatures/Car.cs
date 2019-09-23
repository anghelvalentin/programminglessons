using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpFeatures
{
    class Car
    {
        public string Producer { get; set; }

        public string GetOriginCountry()
        {
            switch (Producer)
            {
                case string p when p == "Mercedes" || p == "BMW":
                    return "Germany";

                case string p when p == "Lexus" || p == "Ford":
                    return "USA";

                default:
                    return "Unknown";
            }
        }
    }
}
