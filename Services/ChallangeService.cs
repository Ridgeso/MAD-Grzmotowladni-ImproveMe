﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImproveMe.Services
{
    public class ChallangeService
    {
        SQLiteAsyncConnection Database;
        private readonly UserService _userService;
        public ChallangeService(UserService userService)
        {
            _userService = userService;
        }

        async Task Init()
        {
            if (Database is not null)
                return;

            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            var result = await Database.CreateTableAsync<User>();
        }

    }
}
