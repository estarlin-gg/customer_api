namespace CRM.Server.Dto
{
    public class CustomerDto
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public bool Active { get; set; } = false;
    }
}
