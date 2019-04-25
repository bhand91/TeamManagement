using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace TeamManagement.Models
{
        public enum Role
    {
        Manager, Researcher, Specialist, Task_Worker
    }
    public class TasksMembers
    {
        
        public int ID {get; set;}
        public int TaskID {get; set;}

        public int MemberID {get; set;}

        public Role? MemberRole {get; set;}

        public Task Task {get; set;}
        public Member Member {get; set;}

    }
}