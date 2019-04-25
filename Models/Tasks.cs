using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace TeamManagement.Models
{
    public class Task
    {
        public int TaskID {get; set;}

        public string TaskName {get; set;}

        [DataType(DataType.Date)]
        public DateTime DueDate {get; set;}

        public string TaskDec {get; set;}

        public List<TasksMembers> TaskMembers {get; set;}
    }
}