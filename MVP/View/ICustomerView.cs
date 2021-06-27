using MVP.Model;
using MVP.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.View
{
    public interface ICustomerView
    {
        IList<string> CustomerList
        {
            get;
            set;
        }
        int SelectedCustomer { get; set; }
         string Address
        {
            get;
            set;
        }
         string FullName
        {
            get;
            set;
        }
        string Email
        {
            get;
            set;
        }
         CustomerPresenter customerPresenter { get; set; }

    }
}
