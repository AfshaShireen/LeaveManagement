using Microsoft.AspNetCore.Identity;

namespace LeaveManagement.web.Data
{
    public class Employee : IdentityUser

    {
        public string? First_Name { get; set; }
        public string? Last_Name { get; set; }
        public string ?Tax_id { get; set; }
        public DateTime Date_of_birth { get; set; }
        public DateTime Date_of_join { get; set; }


    }
}
