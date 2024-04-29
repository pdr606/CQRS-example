namespace crqs.example.domain.Enties.Notifications
{
    public class Notification
    {
        private Notification(string propertyName, string message)
        {
            PropertyName = propertyName;
            Message = message;
        }   

        public string PropertyName { get; private set; }
        public string Message { get; private set; }

        public static Notification Create(string propertyName, string message)
        {
            return 
                new Notification(propertyName, message);
        }
    }
}
