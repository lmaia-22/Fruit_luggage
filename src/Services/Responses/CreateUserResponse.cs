namespace Services
{
    public class CreateUserResponse
    {
        public bool IsSuccess => ErrorCode == null;
        public string ErrorCode { get; set; }
    }
}