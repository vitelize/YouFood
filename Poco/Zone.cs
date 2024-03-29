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

namespace Poco
{
    public partial class Zone
    {
        #region Primitive Properties
    
        public virtual int ID
        {
            get;
            set;
        }
    
        public virtual string Description
        {
            get;
            set;
        }
    
        public virtual int RestaurantID
        {
            get { return _restaurantID; }
            set
            {
                if (_restaurantID != value)
                {
                    if (Restaurant != null && Restaurant.ID != value)
                    {
                        Restaurant = null;
                    }
                    _restaurantID = value;
                }
            }
        }
        private int _restaurantID;

        #endregion
        #region Navigation Properties
    
        public virtual ICollection<Serveur> Serveur
        {
            get
            {
                if (_serveur == null)
                {
                    var newCollection = new FixupCollection<Serveur>();
                    newCollection.CollectionChanged += FixupServeur;
                    _serveur = newCollection;
                }
                return _serveur;
            }
            set
            {
                if (!ReferenceEquals(_serveur, value))
                {
                    var previousValue = _serveur as FixupCollection<Serveur>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupServeur;
                    }
                    _serveur = value;
                    var newValue = value as FixupCollection<Serveur>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupServeur;
                    }
                }
            }
        }
        private ICollection<Serveur> _serveur;
    
        public virtual ICollection<Table> Table
        {
            get
            {
                if (_table == null)
                {
                    var newCollection = new FixupCollection<Table>();
                    newCollection.CollectionChanged += FixupTable;
                    _table = newCollection;
                }
                return _table;
            }
            set
            {
                if (!ReferenceEquals(_table, value))
                {
                    var previousValue = _table as FixupCollection<Table>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupTable;
                    }
                    _table = value;
                    var newValue = value as FixupCollection<Table>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupTable;
                    }
                }
            }
        }
        private ICollection<Table> _table;
    
        public virtual Restaurant Restaurant
        {
            get { return _restaurant; }
            set
            {
                if (!ReferenceEquals(_restaurant, value))
                {
                    var previousValue = _restaurant;
                    _restaurant = value;
                    FixupRestaurant(previousValue);
                }
            }
        }
        private Restaurant _restaurant;

        #endregion
        #region Association Fixup
    
        private void FixupRestaurant(Restaurant previousValue)
        {
            if (previousValue != null && previousValue.Zone.Contains(this))
            {
                previousValue.Zone.Remove(this);
            }
    
            if (Restaurant != null)
            {
                if (!Restaurant.Zone.Contains(this))
                {
                    Restaurant.Zone.Add(this);
                }
                if (RestaurantID != Restaurant.ID)
                {
                    RestaurantID = Restaurant.ID;
                }
            }
        }
    
        private void FixupServeur(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Serveur item in e.NewItems)
                {
                    item.Zone = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Serveur item in e.OldItems)
                {
                    if (ReferenceEquals(item.Zone, this))
                    {
                        item.Zone = null;
                    }
                }
            }
        }
    
        private void FixupTable(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Table item in e.NewItems)
                {
                    item.Zone = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Table item in e.OldItems)
                {
                    if (ReferenceEquals(item.Zone, this))
                    {
                        item.Zone = null;
                    }
                }
            }
        }

        #endregion
    }
}
