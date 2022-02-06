namespace GEO_Quiz.domain
{
    public class User
    {
        private string username;
        public User(string username)
        {
            this.username = username;
        }

        public string GetUsername()
        {
            return username;
        }
    }
}
