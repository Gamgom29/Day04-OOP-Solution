﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Casting_Operator_Overloading
{
    // ViewModel : is a class that represent the data that will be Renderd
    class UserViewModel
    {
        public int Id { get; set; }
        public string?  FName { get; set; }
        public string? LName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }


        public static explicit operator UserViewModel(User user)
        {
            string[]? Names = user?.Name?.Split(" ");
            return new UserViewModel()
            {
                Id = user?.Id ?? 0,
                FName = Names?.Length > 0 ? Names[0] : string.Empty,
                LName = Names?.Length > 1 ? Names[1] : string.Empty,
                Email = user?.Email ?? string.Empty,
                Password = user?.Password ?? string.Empty,
            };
        }
    }
}
