using System;
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

namespace WPFNotes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        List<Case> cases = new List<Case>();
        int caseCounter = 0;

        public class Case
        {
            public string customer = null;
            public string feedback = null;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Case tempCase = new Case();
            tempCase.customer = newCustomer.Text;
            bool notInListAlready = true;

            foreach (Case item in cases)
            {
                if (tempCase.customer == item.customer)
                {
                    notInListAlready = false;
                    MessageBox.Show("Customer registered already!");
                    return;
                }
            }

            if (notInListAlready)
            {
                cases.Add(tempCase);
            }

            newCustomer.Text = "";
        }

        private void btnPush_Click(object sender, RoutedEventArgs e)
        {
            Case tempCase = new Case();
            tempCase.customer = customer.Text;
            tempCase.feedback = feedback.Text;
            customer.Text = "";
            feedback.Text = "";
            bool customerInList = false;

            foreach (Case item in cases)
            {
                if(tempCase.customer == item.customer)
                {
                    customerInList = true;
                    item.feedback = tempCase.feedback;
                }
            }

            if (!customerInList)
            {
                MessageBox.Show("Only registered customers can leave feedback!");
            }
        }

        private void btnHistory_Click(object sender, RoutedEventArgs e)
        {
            bool registeredCustomer = false;
            listBox2.Items.Clear();
            foreach (Case element in cases)
            {
                if(element.customer == historyName.Text)
                {
                    registeredCustomer = true;
                    if(element.feedback != null)
                    {
                        listBox2.Items.Add(element.feedback);
                    }
                    else
                    {
                        listBox2.Items.Add("Customer left no feedback!");
                    }
                    break;
                }
            }
            if (!registeredCustomer)
            {
                listBox2.Items.Add("This user is not registered!");
            }
        }

        private void btnLatestCase_Click(object sender, RoutedEventArgs e)
        {
            listBox3.Items.Clear();
            for (int i = 0; i < cases.Count; i++)
            {
                if(cases[i].feedback != null)
                {
                    listBox3.Items.Add(cases[i].customer);
                    listBox3.Items.Add(cases[i].feedback);
                    caseCounter = i;
                    return;
                }
            }
            listBox3.Items.Add("No cases left!");
        }

        private void btnSomething_Click(object sender, RoutedEventArgs e)
        {
            var index = caseCounter;
            cases[index].feedback = null;
            listBox3.Items.Clear();

            for (int i = 0; i < (cases.Count - 1); i++)
            {
                index++;
                if (index == cases.Count)
                {
                    index = 0;
                }
                    
                if (cases[index].feedback != null)
                {
                    listBox3.Items.Add(cases[index].customer);
                    listBox3.Items.Add(cases[index].feedback);
                    caseCounter = index;
                    return;
                }
            }
            listBox3.Items.Add("No cases left!");
        }

        private void btnNothing_Click(object sender, RoutedEventArgs e)
        {
            var index = caseCounter;
            listBox3.Items.Clear();

            for (int i = 0; i < (cases.Count - 1); i++)
            {
                index++;
                if (index == cases.Count)
                {
                    index = 0;
                }


                if (cases[index].feedback != null)
                {
                    listBox3.Items.Add(cases[index].customer);
                    listBox3.Items.Add(cases[index].feedback);
                    caseCounter = index;
                    return;
                }
            }
            listBox3.Items.Add("No cases left!");
        }
    }
}
