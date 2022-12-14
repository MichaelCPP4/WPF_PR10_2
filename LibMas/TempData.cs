using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMas
{
    public static class TempData
    {
        /// <summary>
        /// Создаёт визуализацию даннных на DataGrid из передаваемого списков товаров, их затрат на производство и цен
        /// </summary>
        /// <param name="tovar">Коллекция наименований товаров</param>
        /// <param name="productionCosts">коллекция затрат на производство товаров</param>
        /// <param name="price">Коллекция цен на товары</param>
        /// <returns>Представление таблицы</returns>
        public static DataTable ToDataTable(List<string> tovar, List<double> productionCosts, List<double> price)
        {
            var tempData = new DataTable();

            tempData.Columns.Add("Номер", typeof(uint));
            tempData.Columns.Add("Товар", typeof(string));
            tempData.Columns.Add("Цена на производство", typeof(double));
            tempData.Columns.Add("Цена", typeof(double));

            tempData.Columns[0].AutoIncrementSeed = 1;
            tempData.Columns[0].AutoIncrement = true;

            for (int i = 0; i < tovar.Count; i++)
            {
                DataRow row = tempData.NewRow();

                row[1] = tovar[i];
                row[2] = productionCosts[i];
                row[3] = price[i];

                tempData.Rows.Add(row);
            }

            return tempData;
        }
   
    }
}