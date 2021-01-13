using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace RestaurantSimulator
{
    public class Recipe_adapter:Recipe
    {
        public Recipe_adapter(Dictionary<string, string> a, Recipe recipe)
        { 
            string jsonString;
            //this.component_List = recipe.component_List;
            this.Name = recipe.Name;
            Component component;
            foreach (KeyValuePair<string,string> s in a)
            {
                for(int i =0; i < recipe.component_List.Count; i++)
                {
                    if(recipe.component_List[i].Name == s.Key && s.Key!=s.Value)
                    {
                        
                        if (s.Value == "Fish")
                        {
                            component = new Fish();
                        }
                        else if (s.Value == "Carrot")
                        {
                            component = new Carrot();
                        }
                        else if (s.Value == "Potato")
                        {
                            component = new Potato();
                        }
                        else if (s.Value == "Chicken")
                        {
                            component = new Chicken();
                        }
                        else if (s.Value == "Coconut")
                        {
                            component = new Coconut();
                        }
                        else if (s.Value == "Coffee")
                        {
                            component = new Coffee();
                        }
                        else if (s.Value == "Milk")
                        {
                            component = new Milk();
                        }
                        else if (s.Value == "Noodle")
                        {
                            component = new Noodle();
                        }
                        else if (s.Value == "Shrimp")
                        {
                            component = new Shrimp();
                        }
                        else if (s.Value == "Taro")
                        {
                            component = new Taro();
                        }
                        else if (s.Value == "Rice")
                        {
                            component = new Rice();
                        }
                        else if (s.Value == "Bubble tea")
                        {
                            component = new Bubble_tea();
                        }
                        else if (s.Value == "Tea")
                        {
                            component = new Tea();
                        }
                        else if (s.Value == "Beef")
                        {
                            component = new Beef();
                        }
                        else
                        {
                            throw new Exception();
                        }
                        component.Quantity = recipe.component_List[i].Quantity;
                        component.visitors = recipe.component_List[i].visitors;
                        component_List.Add(component);
                    }
                    else if(recipe.component_List[i].Name == s.Key)
                    {
                        if (!component_List.Contains(recipe.component_List[i]))
                        {
                            component_List.Add(recipe.component_List[i]);
                        }
                    }
                }
            }
            jsonString = JsonConvert.SerializeObject(this.component_List, Formatting.Indented);
            File.AppendAllText("D:\\check_adapt_com.json", jsonString);
        }
    }
}
