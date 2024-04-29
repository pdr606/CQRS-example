using crqs.example.domain.Enties.Notifications;
using crqs.example.domain.Enties.Validation.Interface;

namespace crqs.example.domain.Enties.CarContext
{
    public abstract class BaseEntity : IValidation
    {
        private List<Notification> _notifications = new();

        public Guid Id => Guid.Empty;
        public DateTime CreatedAt => DateTime.Now;
        public DateTime? UpdatedAt;
        public IReadOnlyCollection<Notification> Notifications => _notifications;

        public void Update()
        {
            this.UpdatedAt = DateTime.Now;
        }

        public void PullNotification(Notification notifications)
        {
            this._notifications.Add(notifications);
        }

        public abstract bool IsValid();
    }
}
