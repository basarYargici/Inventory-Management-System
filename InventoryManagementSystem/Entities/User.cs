namespace InventoryManagementSystem.Entities
{
    class User
    {
        private string name;
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
    }
}
