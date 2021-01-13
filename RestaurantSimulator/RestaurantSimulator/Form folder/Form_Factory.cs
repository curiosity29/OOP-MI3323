using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RestaurantSimulator
{
    public partial class Form_Factory : Form
    {

        BindingList<Dish> list = new BindingList<Dish>();
        
        #region source factory

        public static Dictionary<string, long> price_dict = new Dictionary<string, long>();

        private static Dictionary<string, Dish> dict = new Dictionary<string, Dish>();
        public static Dish GetDish(string baseName)
        {
            if (dict.ContainsKey(baseName)) return dict[baseName];
            Dish dish;
            DishPart baseDish;
            switch (baseName)
            {
                case "Mì":
                    baseDish = new DishPart
                    {
                        name = "Mì",
                        price = price_dict["Mì"]
                    };
                    dish = new NoodleDish(baseDish, new Bowl());
                    dict.Add("Mì", dish);
                    break;

                #region more
                case "Cà phê":
                    baseDish = new DishPart
                    {
                        name = "Cà phê",
                        price = price_dict["Cà phê"]
                    };
                    dish = new Cafe(baseDish, new Cup());
                    dict.Add("Cà phê", dish);
                    break;

                case "Trà sữa":
                    baseDish = new DishPart
                    {
                        name = "Trà sữa",
                        price = price_dict["Trà sữa"]
                    };
                    dish = new MilkTea(baseDish, new Cup());
                    dict.Add("Trà sữa", dish);
                    break;

                case "Cơm":
                    baseDish = new DishPart
                    {
                        name = "Cơm",
                        price = price_dict["Cơm"]
                    };
                    dish = new RiceDish(baseDish, new Bowl());
                    dict.Add("Cơm", dish);
                    break;

                default:
                    throw new ArgumentException("Error: unrecognized dish type");
                #endregion
            }

            return dish;
        }


        #endregion

        public Form_Factory()
        {
            InitializeComponent();
        }

        private void Form_Factory_Load(object sender, EventArgs e)
        {
            foreach(KeyValuePair<string,Dish> pair in dict)
            {
                list.Add(pair.Value);
            }
            dataGridView1.DataSource = list;
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Remove(object sender, EventArgs e)
        {
            try
            {
                var row = dataGridView1.SelectedRows[0];
                var dish = row.DataBoundItem as Dish;

                list.RemoveAt(row.Index);
                dict.Remove(dish.baseDish.name);
            }
            catch(Exception)
            {
                // no item to remove
            }
        }
    }
}
