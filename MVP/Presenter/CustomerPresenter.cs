using MVP.Model;
using MVP.Repository;
using MVP.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Presenter
{
    public class CustomerPresenter
    {
        ICustomerRepository repository;
        ICustomerView view;

        public CustomerPresenter(ICustomerView customerForm,ICustomerRepository repository)
        {
            this.view = customerForm;
            customerForm.customerPresenter = this;
            this.repository = repository;
            UpdateCustomerListView();
        }
        public void UpdateCustomerView(int id)
        {
            Customer customer = repository.GetCustomerById(id);
            view.FullName = customer.FullName;
            view.Address = customer.Address;
            view.Email = customer.Email;
            view.Citizenship = customer.Citizenship;
        }
        public void SaveCustomer()
        {
            Customer customer = new Customer(view.FullName, view.Address, view.Email,view.Citizenship);
            repository.SaveCustomer(view.SelectedCustomer, customer);
            UpdateCustomerListView();
        }
        public void SaveNewCustomer()
        {
            Customer customer = new Customer(view.FullName, view.Address, view.Email, view.Citizenship);
            repository.SaveNewCustomer( customer);
            UpdateCustomerListView();
        }

        private void UpdateCustomerListView()
        {
            var customerNames = repository.GetAllCustomers().Select(x => x.FullName);
            int selectedCustomer = view.SelectedCustomer >= 0 ? view.SelectedCustomer : 0;
            view.CustomerList = customerNames.ToList();
            view.SelectedCustomer = selectedCustomer;

        }
    }
}
