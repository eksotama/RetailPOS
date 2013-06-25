//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace RetailPOS.PersistenceLayer.Repository.Entities
{
    public partial class email_history : EntityBase
    {
        #region Primitive Properties
    
        public virtual long id
        {
            get;
            set;
        }
    
        public virtual System.DateTime send_date
        {
            get;
            set;
        }
    
        public virtual Nullable<int> customer_id
        {
            get { return _customer_id; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_customer_id != value)
                    {
                        if (customer != null && customer.id != value)
                        {
                            customer = null;
                        }
                        _customer_id = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<int> _customer_id;
    
        public virtual Nullable<short> staff_id
        {
            get { return _staff_id; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_staff_id != value)
                    {
                        if (staff != null && staff.id != value)
                        {
                            staff = null;
                        }
                        _staff_id = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<short> _staff_id;
    
        public virtual string to_email
        {
            get;
            set;
        }
    
        public virtual string subject
        {
            get;
            set;
        }
    
        public virtual string message
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual customer customer
        {
            get { return _customer; }
            set
            {
                if (!ReferenceEquals(_customer, value))
                {
                    var previousValue = _customer;
                    _customer = value;
                    Fixupcustomer(previousValue);
                }
            }
        }
        private customer _customer;
    
        public virtual staff staff
        {
            get { return _staff; }
            set
            {
                if (!ReferenceEquals(_staff, value))
                {
                    var previousValue = _staff;
                    _staff = value;
                    Fixupstaff(previousValue);
                }
            }
        }
        private staff _staff;

        #endregion
        #region Association Fixup
    
        private bool _settingFK = false;
    
        private void Fixupcustomer(customer previousValue)
        {
            if (previousValue != null && previousValue.email_history.Contains(this))
            {
                previousValue.email_history.Remove(this);
            }
    
            if (customer != null)
            {
                if (!customer.email_history.Contains(this))
                {
                    customer.email_history.Add(this);
                }
                if (customer_id != customer.id)
                {
                    customer_id = customer.id;
                }
            }
            else if (!_settingFK)
            {
                customer_id = null;
            }
        }
    
        private void Fixupstaff(staff previousValue)
        {
            if (previousValue != null && previousValue.email_history.Contains(this))
            {
                previousValue.email_history.Remove(this);
            }
    
            if (staff != null)
            {
                if (!staff.email_history.Contains(this))
                {
                    staff.email_history.Add(this);
                }
                if (staff_id != staff.id)
                {
                    staff_id = staff.id;
                }
            }
            else if (!_settingFK)
            {
                staff_id = null;
            }
        }

        #endregion
    }
}