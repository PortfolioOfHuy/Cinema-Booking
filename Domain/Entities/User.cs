namespace Domain.Entities
{
    public class User : BaseEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? EmailToken { get; set; }
        public DateTime? VerifyAt { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }  // 1 User có 1 Role
    }
}
