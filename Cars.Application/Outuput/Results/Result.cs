using cqrs.example.application.Outuput.Results.Interfaces;
using crqs.example.domain.Enties.Notifications;

namespace cqrs.example.application.Outuput.Results
{
    public class Result : IResultBase
    {
        private List<Notification> _notifications;

        private Result(int resultCode, string message, bool isOk) 
        {
            ResultCode = resultCode;
            Message = message;
            IsOk = isOk;
            _notifications = new();
        }

        public int ResultCode { get; private set; }
        public string Message { get; private set; }
        public bool IsOk { get; private set; }
        public object Data { get; private set; }
        public IReadOnlyCollection<Notification> Notification => _notifications;

        public static Result Create(int resultCode, string message, bool isOk)
        {
            return
                new Result(resultCode, message, isOk);
        }

        public Result SetNotifications(List<Notification> notifications)
        {
            this._notifications = notifications;
            return 
                this;
        }

        public Result SetData(object data)
        {
            this.Data = data;
            return 
                this;
        }
    }
}
