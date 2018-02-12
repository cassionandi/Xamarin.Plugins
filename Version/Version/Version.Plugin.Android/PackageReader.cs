using System;
using Android.App;
using Android.Content.PM;

namespace Version.Plugin
{
    internal class PackageReader
    {
        public static string GetPackageVersion()
        {
            try
            {
                var appVersionName = Application.Context.PackageManager.GetPackageInfo(
                    Application.Context.PackageName, PackageInfoFlags.MetaData).VersionName;
                var appVersionCode = Application.Context.PackageManager.GetPackageInfo(
                    Application.Context.PackageName, PackageInfoFlags.MetaData).VersionCode;
                
                return String.Format("{0}.{1}", appVersionName, appVersionCode);
            }
            catch
            {
                return String.Empty;
            }
        }
    }
}