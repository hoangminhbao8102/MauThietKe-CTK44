namespace Nhom10
{
    public class UserService
    {
        private readonly Subject _subject;

        public UserService(Subject subject)
        {
            _subject = subject;
        }

        public void AddUser(string type, string name)
        {
            // Factory: tạo user
            var user = UserFactory.CreateUser(type, name);

            // Singleton: lưu database
            var db = DatabaseConnection.GetInstance();
            db.SaveUser(user);

            // Observer: thông báo logger
            _subject.Notify($"User '{user.Name}' of type '{type}' added.");

            // Hiển thị role
            user.DisplayRole();
        }
    }
}
