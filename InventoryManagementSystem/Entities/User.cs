namespace InventoryManagementSystem.Entities
{
    public class User : IEntity
    {
        private string mail;
        private string password;
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        public User(string mail, string password, string type)
        {
            this.mail = mail;
            this.password = password;
            this.type = type;
        }


    }
}
