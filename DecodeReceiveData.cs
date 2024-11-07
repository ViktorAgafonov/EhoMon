using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EhoMon
{
    internal class DecodeReceiveData(string data)
    {
        private string receiveData = data;
        public void DecodeData()
        {
            try
            {
                string[] hexValues = receiveData.Split('-');

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error during data decoding: " + ex.Message);
            }
        }
    }
}
