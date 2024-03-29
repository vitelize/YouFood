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
    public partial class Commande
    {
        #region Primitive Properties
    
        public virtual int ID
        {
            get;
            set;
        }
    
        public virtual System.DateTime Date
        {
            get;
            set;
        }
    
        public virtual bool Reglement
        {
            get;
            set;
        }
    
        public virtual double Prix
        {
            get;
            set;
        }
    
        public virtual int CuisinierID
        {
            get;
            set;
        }
    
        public virtual int TableID
        {
            get { return _tableID; }
            set
            {
                if (_tableID != value)
                {
                    if (Table != null && Table.ID != value)
                    {
                        Table = null;
                    }
                    _tableID = value;
                }
            }
        }
        private int _tableID;

        #endregion
        #region Navigation Properties
    
        public virtual ICollection<Plat> Plat
        {
            get
            {
                if (_plat == null)
                {
                    var newCollection = new FixupCollection<Plat>();
                    newCollection.CollectionChanged += FixupPlat;
                    _plat = newCollection;
                }
                return _plat;
            }
            set
            {
                if (!ReferenceEquals(_plat, value))
                {
                    var previousValue = _plat as FixupCollection<Plat>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupPlat;
                    }
                    _plat = value;
                    var newValue = value as FixupCollection<Plat>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupPlat;
                    }
                }
            }
        }
        private ICollection<Plat> _plat;
    
        public virtual Table Table
        {
            get { return _table; }
            set
            {
                if (!ReferenceEquals(_table, value))
                {
                    var previousValue = _table;
                    _table = value;
                    FixupTable(previousValue);
                }
            }
        }
        private Table _table;
    
        public virtual ICollection<Notification> Notification
        {
            get
            {
                if (_notification == null)
                {
                    var newCollection = new FixupCollection<Notification>();
                    newCollection.CollectionChanged += FixupNotification;
                    _notification = newCollection;
                }
                return _notification;
            }
            set
            {
                if (!ReferenceEquals(_notification, value))
                {
                    var previousValue = _notification as FixupCollection<Notification>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupNotification;
                    }
                    _notification = value;
                    var newValue = value as FixupCollection<Notification>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupNotification;
                    }
                }
            }
        }
        private ICollection<Notification> _notification;
    
        public virtual ICollection<PlatEnCours> PlatEnCours
        {
            get
            {
                if (_platEnCours == null)
                {
                    var newCollection = new FixupCollection<PlatEnCours>();
                    newCollection.CollectionChanged += FixupPlatEnCours;
                    _platEnCours = newCollection;
                }
                return _platEnCours;
            }
            set
            {
                if (!ReferenceEquals(_platEnCours, value))
                {
                    var previousValue = _platEnCours as FixupCollection<PlatEnCours>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupPlatEnCours;
                    }
                    _platEnCours = value;
                    var newValue = value as FixupCollection<PlatEnCours>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupPlatEnCours;
                    }
                }
            }
        }
        private ICollection<PlatEnCours> _platEnCours;

        #endregion
        #region Association Fixup
    
        private void FixupTable(Table previousValue)
        {
            if (previousValue != null && previousValue.Commande.Contains(this))
            {
                previousValue.Commande.Remove(this);
            }
    
            if (Table != null)
            {
                if (!Table.Commande.Contains(this))
                {
                    Table.Commande.Add(this);
                }
                if (TableID != Table.ID)
                {
                    TableID = Table.ID;
                }
            }
        }
    
        private void FixupPlat(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Plat item in e.NewItems)
                {
                    if (!item.Commande.Contains(this))
                    {
                        item.Commande.Add(this);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Plat item in e.OldItems)
                {
                    if (item.Commande.Contains(this))
                    {
                        item.Commande.Remove(this);
                    }
                }
            }
        }
    
        private void FixupNotification(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Notification item in e.NewItems)
                {
                    if (!item.Commande.Contains(this))
                    {
                        item.Commande.Add(this);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Notification item in e.OldItems)
                {
                    if (item.Commande.Contains(this))
                    {
                        item.Commande.Remove(this);
                    }
                }
            }
        }
    
        private void FixupPlatEnCours(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (PlatEnCours item in e.NewItems)
                {
                    item.Commande = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (PlatEnCours item in e.OldItems)
                {
                    if (ReferenceEquals(item.Commande, this))
                    {
                        item.Commande = null;
                    }
                }
            }
        }

        #endregion
    }
}
