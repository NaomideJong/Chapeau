﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ChapeauModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauDAL
{
    public class MenuItemDao : BaseDao
    {
        public List<MenuItem> GetAllMenuItems(ThreeCourseMeal threeCourseMealCode, bool isLunch)
        {
            string query;
            if(threeCourseMealCode == ThreeCourseMeal.Drinks)
            query = "SELECT menuItem_ID, productName, price, [description] FROM [MenuItem] WHERE menuItem_ID IN (select menuItem_Id FROM Drink_Item)";
            else if (isLunch)
            query = "SELECT menuItem_ID, productName, price, description FROM [MenuItem] WHERE [threeCourseMealCode] = @threeCourseMealCode AND menuItem_ID IN (select * FROM Lunch_Item)";
            else
            query = "SELECT menuItem_ID, productName, price, description FROM [MenuItem] WHERE [threeCourseMealCode] = @threeCourseMealCode AND menuItem_ID IN (select * FROM Dinner_Item)";


            SqlParameter[] sqlParameters = new SqlParameter[1]
            {
                new SqlParameter("@threeCourseMealCode", (int)threeCourseMealCode)
            };

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<MenuItem> ReadTables(DataTable dataTable)
        {
            List<MenuItem> menuItems = new List<MenuItem>();
            try
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    MenuItem menuItem = new MenuItem()
                    {
                        MenuItemId = (int)dr["menuItem_ID"],
                        ProductName = (string)dr["productName"],
                        Price = (double)dr["price"],
                        Description = (string)dr["description"]
                    };
                    menuItems.Add(menuItem);
                }
                return menuItems;

            }
            catch
            {
                throw new Exception("No data found in menuitems");
            }

        }
    }
}
