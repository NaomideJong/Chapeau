using System;
using System.Collections.Generic;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class MenuItemService
    {

        MenuItemDao menuItemdb;

        public MenuItemService()
        {
            menuItemdb = new MenuItemDao();
        }
       
        public List<MenuItem> GetMenuItems(ThreeCourseMeal threeCourseMealCode, bool isLunch)
        {
            return menuItemdb.GetAllMenuItems(threeCourseMealCode, isLunch);
        }
    }
}
