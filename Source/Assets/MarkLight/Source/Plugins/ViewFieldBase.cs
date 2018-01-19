#region Using Statements
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
#endregion

namespace MarkLight
{
    /// <summary>
    /// Base class for dependency view fields.
    /// </summary>
    public class ViewFieldBase
    {
        #region Fields
        [HideInInspector]
        public View ParentView;
        [HideInInspector]
        public string ViewFieldPath;
        [HideInInspector]
        public bool IsMapped;
        [HideInInspector]
        public bool _isSet;
        [HideInInspector]
        public event EventHandler ValueSet;

        #endregion

        #region Methods

        /// <summary>
        /// Triggers the ValueSet event.
        /// </summary>
        public void TriggerValueSet()
        {
            if (ValueSet != null)
            {
                ValueSet(this, EventArgs.Empty);
            }
        }

        #endregion
    }
}
