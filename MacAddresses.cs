using System.Linq;
using System.Net.NetworkInformation;

namespace NutriTrack
{
    public static class MacAddresses
    {
        public static readonly string FirstMac =
            NetworkInterface.GetAllNetworkInterfaces().First().GetPhysicalAddress().ToString();
    }
}