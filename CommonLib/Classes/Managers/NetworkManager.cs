using CommonLib.Classes.Network_Tools;
using System;
using System.Net.NetworkInformation;
using System.Text;

namespace CommonLib.Classes.Managers
{
    public class NetworkManager : IDisposable
    {
        private Connectivity _connectivity = new Connectivity();
        private DHCP _dhcp = new DHCP();
        private DNS _dns = new DNS();

        #region Connectivity
        public string LocalPing()
        {
            return _connectivity.LocalPing(new StringBuilder(), new Ping());
        }

        public string TraceRoute(string ipaddress)
        {
            return _connectivity.Traceroute(ipaddress, new StringBuilder());
        }
        #endregion
        #region DHCP
        public string DisplayDhcpServerAddresses()
        {
            return _dhcp.DisplayDhcpServerAddresses(new StringBuilder());
        }
        #endregion
        #region DNS
        public string GetIpFromHostname(string url)
        {
            return _dns.GetIpFromHostname(url);
        }

        public string GetHostnameFromIp(string ip)
        {
            return _dns.GetHostnameFromIp(ip);
        }
        #endregion

        public void Dispose()
        {
            _connectivity = null;
            _dhcp = null;
            _dns = null;
        }
    }
}
