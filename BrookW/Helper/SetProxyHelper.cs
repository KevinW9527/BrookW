using Microsoft.Win32;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace BrookW.Helper
{
    public static class SetProxyHelper
    {
        private static void FlushEnvironmentVariables()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "/bin/bash",
                    Arguments = "-c \"source ~/.bashrc\"",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                });
            }
        }

        private static RegistryKey? OpenInternetSettingsKey()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                var key = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                if (key == null)
                {
                    throw new InvalidOperationException("Could not open Internet settings key");
                }
                return key;
            }
            return null;
        }

        private static void SetEnvironmentVariable(string name, string value)
        {
            if (string.IsNullOrWhiteSpace(Environment.GetEnvironmentVariable(name)))
            {
                Environment.SetEnvironmentVariable(name, value);
            }
        }

        public static void EnableProxy(string uri)
        {
            if (string.IsNullOrEmpty(uri))
            {
                throw new ArgumentNullException(nameof(uri));
            }

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                using (var registryKey = OpenInternetSettingsKey())
                {
                    if (registryKey != null)
                    {
                        registryKey.SetValue("ProxyOverride", "localhost;127.*;10.*;172.16.*;172.17.*;172.18.*;172.19.*;172.20.*;172.21.*;172.22.*;172.23.*;172.24.*;172.25.*;172.26.*;172.27.*;172.28.*;172.29.*;172.30.*;172.31.*;192.168.*");
                        registryKey.SetValue("ProxyEnable", 1);
                        registryKey.SetValue("ProxyServer", uri);
                    }
                }
            }
            else
            {
                SetEnvironmentVariable("http_proxy", uri);
                SetEnvironmentVariable("https_proxy", uri);
                SetEnvironmentVariable("ftp_proxy", uri);
                SetEnvironmentVariable("all_proxy", uri);

                FlushEnvironmentVariables();
            }
        }

        public static void DisableProxy()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                using (var registryKey = OpenInternetSettingsKey())
                {
                    if (registryKey != null)
                    {
                        registryKey.SetValue("ProxyEnable", 0);
                    }
                }
            }
            else
            {
                Environment.SetEnvironmentVariable("http_proxy", "");
                Environment.SetEnvironmentVariable("https_proxy", "");
                Environment.SetEnvironmentVariable("ftp_proxy", "");
                Environment.SetEnvironmentVariable("all_proxy", "");

                FlushEnvironmentVariables();
            }
        }
    }


}
