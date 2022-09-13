namespace Task1Doamin.Models
{
    public class Employees
    {
        public int empId { get; set; }
        public string ? name { get; set; }
        public string ? status { get; set; }
        public string ? manager { get; set; }
        public string ? wfmManager { get; set; }
        public string ? email { get; set; }
        public string ? lockStatus { get; set; }
        public decimal experience { get; set; }
        public int profileId { get; set; }

    }
    public class Skill
    {
        public int skillId { get; set; }
        public string ? name { get; set; }
    }
    public class SkillMap
    {
        public int empId { get; set; }
        public int skillId { get; set; }
    }
    public class Users
    {
        public string? userName { get; set; }
        public string? password { get; set; }
        public string? role { get; set; }
        public string? name { get; set; }
        public string? email { get; set; }

    }
    public class SoftLock
    {
        public int empId { get; set; }
        public string? manager { get; set; }
        public DateOnly requestDate { get; set; }
        public string? status { get; set; }
        public DateOnly lastUpdatedDate { get; set; }
        public int lockId { get; set; }
        public string? requestMessage { get; set; }
        public string? wfmremark { get; set; }
        public string? manageStatus { get; set; }
        public string? mgrStatuscomment { get; set; }
        public DateOnly mgrlastupdate { get; set; }

    }
}
