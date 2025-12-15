using Plugin.LocalNotification;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            cos();
        }

        async void cos()
        {
            await LocalNotificationCenter.Current.RequestNotificationPermission();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var notification = new NotificationRequest
            {
                NotificationId = 100,
                Title = "Testowe powiadomienie",
                Description = "Test",
                Schedule = new NotificationRequestSchedule
                {
                    NotifyTime = DateTime.Now.AddSeconds(5)
                }
            };

            LocalNotificationCenter.Current.Show(notification);
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            var notification = new NotificationRequest
            {
                NotificationId = 101,
                Title = "Powiadomienie zaplanowane",
                Description = "",
                Schedule = new NotificationRequestSchedule
                {
                    NotifyTime = DatePickerObj.Date.Add(TimePickerObj.Time)
                }
            }; LocalNotificationCenter.Current.Show(notification);
        }
    }
}
