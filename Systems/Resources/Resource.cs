using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DK
{
    public struct Resource<T>
    {
        public event System.Action<T> OnValueChanged;

        T _value;
        public T value
        {
            get => _value;
            set => UpdateValue(value);
        }

        void UpdateValue(T newValue)
        {
            if (!newValue.Equals(_value))
            {
                _value = newValue;
                OnValueChanged(newValue);
            }
        }
    }    
}
