using System.Net;

namespace EhoMon
{
    internal class parseDate
    {
        private IPAddress any;
        private int v;

        public parseDate(IPAddress any, int v)
        {
            this.any = any;
            this.v = v;
        }

        public byte[] value { get; internal set; }
    }
}