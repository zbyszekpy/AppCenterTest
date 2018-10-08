using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace AppCenter.UITest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp.Android
                  //.PreferIdeSettings()
                  .InstalledApp("com.companyname.AppCenterTestApp")
                  .EnableLocalScreenshots()
                  //.WaitTimes(new EspWaitTimes())
                  .StartApp(Xamarin.UITest.Configuration.AppDataMode.DoNotClear);
      }

            return ConfigureApp.iOS.StartApp();
        }
    }
}