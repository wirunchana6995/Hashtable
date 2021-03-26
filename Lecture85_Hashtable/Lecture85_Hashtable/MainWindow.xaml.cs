using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lecture85_Hashtable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //ArrayList arrayList;
        Hashtable hashtable;
        public MainWindow()
        {
            InitializeComponent();
            //arrayList = new ArrayList();
            hashtable = new Hashtable();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            //Add
            /*hashtable.Add("Desk","Brown"); //key = object, value = color
            hashtable.Add("Calendar","White");
            hashtable.Add("Telephone","Red");*/

            hashtable.Add(inputKey.Text, inputValue.Text);
            inputKey.Text = null;
            inputValue.Text = null;
        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            //Remove
            hashtable.Remove(inputKey.Text); //ใส่ key
            inputKey.Text = null;
            inputValue.Text = null;
        }

        private void showAllButton_Click(object sender, RoutedEventArgs e)
        {
            ICollection icollection = hashtable.Keys; //จะดึง Key ทั้งหมดที่อยู่ใน hashtable
            string temp_value = null;
            //Show All
            foreach (string key in icollection)
            {
                temp_value += hashtable[key].ToString() + "\n";
            }

            showData.Text = temp_value;
        }

    }
}
