﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Shop_Store_System.BusinesLogic
{
    class User
    {
        private string firstName;
        private string lastName;
        private string email;
        private string username;
        private string password;

        public int Id { get; set; }
        public string FirstName
        {
            get => this.firstName;
            set
            {
                //Валидация на първото име
                if (value.Length <= 3)
                {
                    throw new ArgumentException("Invalid first name!");
                }

                this.firstName = value;
            }
        }
        public string LastName
        {
            get => this.lastName;
            set
            {
                //Валидация на фамилията
                if (value.Length <= 3)
                {
                    throw new ArgumentException("Invalid last name!");
                }

                this.lastName = value;
            }
        }
        public string Email
        {
            get => this.email;
            set
            {
                //Валидация на emaila
                Regex regex = new Regex(@"^([\w-.]+)@(([[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.)|(([\w-]+.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(]?)$");
                Match match = regex.Match(value);
                if (match.Success)
                {
                    this.email = value;
                }
                else
                {
                    throw new ArgumentException(@"Invalid email!");
                }
            }
        }
        public string Username
        {
            get => this.username;
            set
            {
                //Валидация на потребителското име
                if (value.Length < 3)
                {
                    throw new ArgumentException("Invalid username!");
                }

                this.username = value;
            }
        }
        public string Password
        {
            get => this.password;
            set
            {
                //Валидация на паролата
                if (value.Length < 5)
                {
                    throw new ArgumentException("Invalid password!");
                }

                this.password = value;
            }
        }

        public string Address { get; set; }
        public string Contact { get; set; }
        public string Gender { get; set; }
        public string UserType { get; set; }
        public DateTime AddedDate { get; set; }
        public int AddedBy { get; set; }
        public string AddedByName { get; set; }
    }

}
