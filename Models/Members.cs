using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace TeamManagement.Models
{
    public class Member
    {
        public int MemberID {get; set;}

        public string LastName {get; set;}

        public string FirstName {get; set;}

        public List<TasksMembers> TaskMembers {get; set;}
    }
}