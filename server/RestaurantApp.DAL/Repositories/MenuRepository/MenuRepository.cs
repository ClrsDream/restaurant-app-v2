﻿using Microsoft.EntityFrameworkCore;
using RestaurantApp.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RestaurantApp.DAL.Repositories
{
    internal class MenuRepository : BaseRepository<Menu, int>, IMenuRepository
    {
        public MenuRepository(RestaurantAppContext context): base(context)
        {
        }

        public Menu GetActive()
        {
            return base.Context.Menus.FirstOrDefault(x => x.Status == Enum.MenuStatus.Active);
        }
    }
}