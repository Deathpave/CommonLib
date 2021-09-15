using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;

namespace CommonLib.Classes.Network_Tools
{
    /// <summary>
    /// Class for DHCP tools
    /// </summary>
    internal class DHCP
    {
        // Method to dislay dhcp server's ipaddress
        public string DisplayDhcpServerAddresses(StringBuilder stringBuilder)
        {
            stringBuilder.Append("DHCP Servers" + Environment.NewLine);

            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {
                IPInterfaceProperties adapteradapterProperties = adapter.GetIPProperties();
                IPAddressCollection addresses = adapteradapterProperties.DhcpServerAddresses;
                if (addresses.Count > 0)
                {
                    stringBuilder.Append(adapter.Description + Environment.NewLine);

                    foreach (IPAddress address in addresses)
                    {
                        stringBuilder.Append(address.ToString());
                    }
                }
            }
            return stringBuilder.ToString();
        }
    }
}
