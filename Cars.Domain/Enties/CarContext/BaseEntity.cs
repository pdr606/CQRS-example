using crqs.example.domain.Enties.Notifications;
using crqs.example.domain.Enties.Validation.Interface;

namespace crqs.example.domain.Enties.CarContext
{
    public abstract class BaseEntity : IValidation
    {
        private List<Notification> _notifications = new();

        public Guid Id { get; private set;} = Guid.NewGuid();
        public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; private set; }
        public IReadOnlyCollection<Notification> Notifications => _notifications;

        public void Update()
        {
            this.UpdatedAt = DateTime.UtcNow;
        }

        public void PullNotification(Notification notifications)
        {
            this._notifications.Add(notifications);
        }

        public abstract bool IsValid();
    }
}
