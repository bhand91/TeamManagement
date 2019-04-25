using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace TeamManagement.Models
{
    public enum Role
    {
        Manager, Researcher, Specialist, Task_Worker
    }
    public class Member
    {
        public int MemberID {get; set;}

        public string MemberName {get; set;}

        public Role? MemberRole {get; set;}

        public List<TasksMembers> TaskMembers {get; set;}
    }
}