﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBook.Business
{
    public class Log
    {
        public Log()
        {
            tasks = new List<TaskItem>();
            users = new List<User>();
        }

        public void AddTaskItem(string Title, string Subject, string Body, string Creator)
        {
            TaskItem task = new TaskItem();
            task.Title = Title;
            task.Subject = Subject;
            task.Body = Body;
            task.Creator = Creator;
            tasks.Add(task);
        }

        public void AddUser(string FirstName, string LastName, string UserCode)
        {
            User user = new User();
            user.FirstName = FirstName;
            user.LastName = LastName;
            user.UserCode = UserCode;
            users.Add(user);
        }

        public string Title;
        public string Creator;
        public List<TaskItem> tasks;
        public List<User> users;
    }
}
