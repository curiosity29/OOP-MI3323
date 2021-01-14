using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace RestaurantSimulator
{
    public partial class Form_MakeDish : Form
    {

        List<component_refrigerator> component_refrigerator;
        public bool OK = false;
        List<Recipe> recipes1;
        List<Recipe> recipes2;
        Dictionary<string, string> adapt_component;
        public Form_MakeDish()
        {
            InitializeComponent();
            string aaaa = File.ReadAllText("..\\..\\DataSource\\adapter_component.json");
            adapt_component = JsonConvert.DeserializeObject<Dictionary<string, string>>(aaaa);
            string json = File.ReadAllText("..\\..\\DataSource\\read_re_re.json");
            component_refrigerator = JsonConvert.DeserializeObject<List<component_refrigerator>>(json);
        }
        public void Write_recpies_to_json(string filename, object recipes)
        {
            string data = JsonConvert.SerializeObject(recipes, Formatting.Indented);
            File.WriteAllText(filename, data);
        }
        public List<Recipe> Read_recipes_from_Json(string filename)
        {
            List<Recipe> recipes = new List<Recipe>();
            string raw = File.ReadAllText(filename);
            try
            {
                dynamic list = JsonConvert.DeserializeObject<dynamic>(raw);
                if (list != null)
                {
                    foreach (dynamic element in list)
                    {
                        Recipe recipe1 = new Recipe((string)element.Name);
                        foreach (dynamic c in element.component_List)
                        {
                            Component component;
                            if (c.Name == "Fish")
                            {
                                component = new Fish();
                            }
                            else if (c.Name == "Carrot")
                            {
                                component = new Carrot();
                            }
                            else if (c.Name == "Potato")
                            {
                                component = new Potato();
                            }
                            else if (c.Name == "Chicken")
                            {
                                component = new Chicken();
                            }
                            else if (c.Name == "Coconut")
                            {
                                component = new Coconut();
                            }
                            else if (c.Name == "Coffee")
                            {
                                component = new Coffee();
                            }
                            else if (c.Name == "Milk")
                            {
                                component = new Milk();
                            }
                            else if (c.Name == "Noodle")
                            {
                                component = new Noodle();
                            }
                            else if (c.Name == "Shrimp")
                            {
                                component = new Shrimp();
                            }
                            else if (c.Name == "Taro")
                            {
                                component = new Taro();
                            }
                            else if (c.Name == "Rice")
                            {
                                component = new Rice();
                            }
                            else if (c.Name == "Bubble tea")
                            {
                                component = new Bubble_tea();
                            }
                            else if (c.Name == "Tea")
                            {
                                component = new Tea();
                            }
                            else if (c.Name == "Beef")
                            {
                                component = new Beef();
                            }
                            else
                            {
                                throw new Exception();
                            }
                            component.Quantity = c.Quantity;
                            foreach (dynamic v in c.visitors)
                            {
                                IVisitor visitor;
                                if (v.Type == 1)
                                {
                                    visitor = new ChopVisitor();
                                }
                                else if (v.Type == 2)
                                {
                                    visitor = new FryVisitor();
                                }
                                else if (v.Type == 3)
                                {
                                    visitor = new WashVisitor();
                                }
                                else if (v.Type == 4)
                                {
                                    visitor = new BoilVisitor();
                                }
                                else
                                {
                                    throw new Exception();
                                }
                                component.visitors.Add(visitor);
                            }
                            recipe1.component_List.Add(component);
                        }
                        recipes.Add(recipe1);
                    }
                }      
            }
            catch
            {
                //
            }
            return recipes;
        }

        private void Form_MakeDish_Load(object sender, EventArgs e)
        {
            try
            {
                recipes1 = Read_recipes_from_Json(@"..\..\DataSource\Test2.json");
                recipes2 = Read_recipes_from_Json(@"..\..\DataSource\Test.json");
                foreach (Recipe r in recipes1)
                {
                    listbox1.Items.Add(r.Name);
                }
                foreach (Recipe r in recipes2)
                {
                    listbox2.Items.Add(r.Name);
                }
            }
            catch
            {
                //
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                recipes1.RemoveAt(listbox1.SelectedIndex);
                listbox1.Items.RemoveAt(listbox1.SelectedIndex);
            }
            catch
            {
                //
            }
        }
        public bool check_available(Recipe recipe, ref List<component_refrigerator> component_refrigerator)
        {
            int i, j;
            int k = recipe.component_List.Count;
            foreach (component_refrigerator a in component_refrigerator)
            {
                for (i = 0; i < k; i++)
                {
                    if (recipe.component_List[i].Name == a.Name)
                    {
                        j = a.quantity - recipe.component_List[i].Quantity;
                        if (j < 0)
                            return false;
                    }
                }
            }
            return true;
        }
       
        public void available_return(Recipe recipe, ref List<component_refrigerator> component_refrigerator)
        {
            int i, j, k;
            k = recipe.component_List.Count;
            foreach (component_refrigerator a in component_refrigerator)
            {
                for (i = 0; i < k ; i++)
                {
                    if(recipe.component_List[i].Name == a.Name)
                    {
                        j = a.quantity - recipe.component_List[i].Quantity ;
                        a.quantity = j;
                    }
                }
            }
        }
        public Recipe find_index_recipe(string recipe_name, List<Recipe> list_recipe)
        {
            int i;
            for (i = 0; i < list_recipe.Count; i++)
            {
                if (list_recipe[i].Name == recipe_name)
                    return list_recipe[i];
            }
            return null;
        }
        public bool adapt_dish(Recipe recipe, ref List<component_refrigerator> component_refrigerator)
        {
            Recipe recipe1 = new Recipe_adapter(adapt_component, recipe);
            if (check_available(recipe1, ref component_refrigerator))
            {
                available_return(recipe1, ref component_refrigerator);
                string jsonString = JsonConvert.SerializeObject(component_refrigerator, Formatting.Indented);
                File.WriteAllText(@"..\..\DataSource\read_re_re.json", jsonString);
                return true;
            }
            else
            {
                MessageBox.Show("Out-of-stock" + recipe1.Name, "INFORM");
                return false;
            }
        }
        private void cook_click(object sender, EventArgs e)
        {
            try
            {
                
                Dictionary<string, string> adapt = new Dictionary<string, string>();
                string json1 = File.ReadAllText("..\\..\\DataSource\\adapter.json");
                adapt = JsonConvert.DeserializeObject<Dictionary<string, string>>(json1);
                Recipe recipe1 = recipes1[listbox1.SelectedIndex];
                Recipe recipe2 = recipes2[listbox2.SelectedIndex];
                //Refrigerator refrigerator = new Refrigerator();
                bool a1  = adapt_dish(recipe1, ref component_refrigerator);
                bool a2 = adapt_dish(recipe2, ref component_refrigerator);
                OK = true;
                if(a1 && a2)
                {
                    MessageBox.Show("The dish has cooked","INFORM");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("The dish has not cooked", "INFORM");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Choose item to cook");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                recipes2.RemoveAt(listbox2.SelectedIndex);
                listbox2.Items.RemoveAt(listbox2.SelectedIndex);
            }
            catch
            {
                //
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form_Refrigerator().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Write_recpies_to_json(@"..\..\DataSource\Test2.json", recipes1);
            Write_recpies_to_json(@"..\..\DataSource\Test.json", recipes2);
          
        }
    }
}
