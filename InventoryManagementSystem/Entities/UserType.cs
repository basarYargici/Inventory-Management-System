namespace InventoryManagementSystem.Entities
{
    class UserType : IEntity
    {
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

    }
}
