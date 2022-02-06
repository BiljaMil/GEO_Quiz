namespace GEO_Quiz.domain
{
    public class LoginService
    {
        private User loggedInUser;

        public bool Login(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                return false;
            }

            this.loggedInUser = new User(username);
            return true;
        }

        public User GetLoggedInUser() { return this.loggedInUser; }
    }
}
