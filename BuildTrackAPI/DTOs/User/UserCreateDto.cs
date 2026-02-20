namespace BuildTrackAPI.DTOs.User
{
    public class UserCreateDto
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }
        public bool IsPlatformAdmin { get; set; }
    }
}
