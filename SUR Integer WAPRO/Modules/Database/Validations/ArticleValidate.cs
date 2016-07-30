using System.Drawing;
using System.Windows.Forms;

namespace SUR_Integer_WAPRO.Modules.Database.Validations
{
    class ArticleValidate
    {
        /// <summary>
        /// Operations value for varchar and null type of columnns in database
        /// </summary>
        /// <param name="keyColumn">key kolumn in database</param>
        /// <param name="newValue">new value</param>
        /// <param name="idCol">index column in data grid view</param>
        /// <param name="row">row in data grid view</param>
        /// <returns></returns>
        public string limitAndNullValue(string keyColumn, string newValue, DataGridViewCell cell, string oldValue)
        {
            if (newValue == null)
            {
                newValue = "";
            }

            switch (keyColumn)
            {
                case "NAZWA":
                    if (newValue.Length > 40)
                    {
                        cell.Style.BackColor = Color.Khaki;
                        return newValue.Substring(0, 40);
                    }
                    else if (newValue.Length == 0)
                    {
                        cell.Style.BackColor = Color.LightCoral;
                        return "null";
                    }
                    else
                    {
                        if (newValue != oldValue)
                        {
                            cell.Style.BackColor = Color.LightGreen;
                        }
                    }
                    break;

                case "NAZWA_ORYG":
                    if (newValue.Length > 40)
                    {
                        cell.Style.BackColor = Color.Khaki;
                        return newValue.Substring(0, 40);
                    }
                    else
                    {
                        if (newValue != oldValue)
                        {
                            cell.Style.BackColor = Color.LightGreen;
                        }
                    }
                    break;

                case "NAZWA2":
                    if (newValue.Length > 40)
                    {
                        cell.Style.BackColor = Color.Khaki;
                        return newValue.Substring(0, 40);
                    }
                    else
                    {
                        if (newValue != oldValue)
                        {
                            cell.Style.BackColor = Color.LightGreen;
                        }
                    }
                    break;

                case "INDEKS_KATALOGOWY":
                    if (newValue.Length > 20)
                    {
                        cell.Style.BackColor = Color.Khaki;
                        return newValue.Substring(0, 20);
                    }
                    else if (newValue.Length == 0)
                    {
                        if (newValue != oldValue)
                        {
                            cell.Style.BackColor = Color.LightGreen;
                        }
                        return "null";
                    }
                    else
                    {
                        cell.Style.BackColor = Color.LightGreen;
                    }
                    break;

                case "INDEKS_HANDLOWY":
                    if (newValue.Length > 20)
                    {
                        cell.Style.BackColor = Color.Khaki;
                        return newValue.Substring(0, 20);
                    }
                    else if (newValue.Length == 0)
                    {
                        cell.Style.BackColor = Color.LightCoral;
                        return "null";
                    }
                    else
                    {
                        if (newValue != oldValue)
                        {
                            cell.Style.BackColor = Color.LightGreen;
                        }
                    }
                    break;

                default:
                    return newValue;

            }
            return newValue;
        }
    }
}
