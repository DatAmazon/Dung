﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBong.DAO
{
    internal class MenuDAO1
    {
        private static MenuDAO1 instance;

        public static MenuDAO1 Instance
        {
            get { if (instance == null) instance = new MenuDAO1(); return MenuDAO1.instance; }
            private set { MenuDAO1.instance = value; }
        }
        private MenuDAO1() { }


        public List<DTO.Menu1> GetList1MenuByTable(int? id)
        {
            List<DTO.Menu1> listMenu1 = new List<DTO.Menu1>();
            string query = "SELECT e.Ten,e.GiaTien FROM dbo.KhuVuc_SanBong AS e where e.ID_KVSB=" + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DTO.Menu1 menu = new DTO.Menu1(item);
                listMenu1.Add(menu);
            }

            return listMenu1;
        }
    }
}
