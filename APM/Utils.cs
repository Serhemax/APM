using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace APM
{
	internal class Utils
	{
		public static void TextUpdate(ComboBox comboBox, DataTable dataTable, string name)
		{
			AutoCompleteStringCollection data = new AutoCompleteStringCollection();
			foreach (DataRow row in dataTable.Rows)
			{
				data.Add(row[name].ToString());
			}

			comboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
			comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			comboBox.AutoCompleteCustomSource = data;
		}
		

	}
}
