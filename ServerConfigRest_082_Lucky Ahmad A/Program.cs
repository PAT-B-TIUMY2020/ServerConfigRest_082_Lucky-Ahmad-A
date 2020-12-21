using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ServiceRest_082_Lucky_Ahmad_A;

namespace ServerConfigRest_082_Lucky_Ahmad_A
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost hostObject = null;

            try
            {
                hostObject = new ServiceHost(typeof(TI_UMY));
                hostObject.Open();
                Console.WriteLine(hostObject);
                Console.WriteLine("Server ready ..");
                Console.ReadLine();
                hostObject.Close();
            }
            catch (Exception ex)
            {
                hostObject = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}