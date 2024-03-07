using System.ComponentModel.DataAnnotations.Schema;

namespace NewsEfCore.DataAccess.Entities
{
    public class User
    {
        public User()
        {
            News = new List<News>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Bio { get; set; }
        public string Password { get; set; }
        [ForeignKey("Role")]
        public int RoleId { get; set; }


        #region navigation Propety

        public List<News> News { get; set; }

       
        public Role Role { get; set; }

        #endregion
    }
}
