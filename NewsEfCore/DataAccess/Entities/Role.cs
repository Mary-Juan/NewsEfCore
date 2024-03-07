namespace NewsEfCore.DataAccess.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string Title { get; set; }

        #region navigation Propety

        public List<User> Users { get; set; }

        #endregion
    }
}
