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
    public partial class Serveur : Personne
    {
        #region Primitive Properties
    
        public virtual int ZoneID
        {
            get { return _zoneID; }
            set
            {
                if (_zoneID != value)
                {
                    if (Zone != null && Zone.ID != value)
                    {
                        Zone = null;
                    }
                    _zoneID = value;
                }
            }
        }
        private int _zoneID;

        #endregion
        #region Navigation Properties
    
        public virtual Zone Zone
        {
            get { return _zone; }
            set
            {
                if (!ReferenceEquals(_zone, value))
                {
                    var previousValue = _zone;
                    _zone = value;
                    FixupZone(previousValue);
                }
            }
        }
        private Zone _zone;

        #endregion
        #region Association Fixup
    
        private void FixupZone(Zone previousValue)
        {
            if (previousValue != null && previousValue.Serveur.Contains(this))
            {
                previousValue.Serveur.Remove(this);
            }
    
            if (Zone != null)
            {
                if (!Zone.Serveur.Contains(this))
                {
                    Zone.Serveur.Add(this);
                }
                if (ZoneID != Zone.ID)
                {
                    ZoneID = Zone.ID;
                }
            }
        }

        #endregion
    }
}
