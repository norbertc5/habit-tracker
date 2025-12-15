using Android;
using Android.App;
using Android.Runtime;

// Essential permissions
[assembly: UsesPermission(Manifest.Permission.Vibrate)]
[assembly: UsesPermission(Manifest.Permission.PostNotifications)]
[assembly: UsesPermission(Manifest.Permission.WakeLock)]
[assembly: UsesPermission(Manifest.Permission.ReceiveBootCompleted)]

// Optional: For exact timing in Calendar/Alarm apps (Android 14+)
[assembly: UsesPermission("android.permission.USE_EXACT_ALARM")] // No user prompt, requires Android 13+
[assembly: UsesPermission("android.permission.SCHEDULE_EXACT_ALARM")] // User can grant permission

namespace MauiApp1
{
    [Application]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}
