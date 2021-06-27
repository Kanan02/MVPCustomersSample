using MVP.Model;
using MVP.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP.View
{
    public partial class CustomerForm : Form,ICustomerView
    {
        public CustomerForm()
        {
            InitializeComponent();
        }
       
        public IList<string> CustomerList
        {
            get { return (IList<string>)listBox1.DataSource; }
            set { listBox1.DataSource = value; }
        }
 
        public string Address
        {
            get { return addressTextBox.Text; }
            set { addressTextBox.Text = value; }
        }
        public string FullName
        {
            get { return nameTextBox.Text; }
            set { nameTextBox.Text = value; }
        }
        public string Email
        {
            get { return emailTextBox.Text; }
            set { emailTextBox.Text = value; }
        }
        public CustomerPresenter customerPresenter { get; set; }
        public int SelectedCustomer { get => listBox1.SelectedIndex; set => listBox1.SelectedIndex=value; }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            customerPresenter.SaveCustomer();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            customerPresenter.SaveCustomer();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            customerPresenter.UpdateCustomerView(listBox1.SelectedIndex);


        }
    }
}
