using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace tutorial_2d
{
	[CreateAssetMenu(fileName = "boolVariable", menuName = "Data/Variables/BoolVariable")]
	public class BoolVariable : ScriptableObject, ISerializationCallbackReceiver
	{

		public bool InitialValue { get => initialValue; private set => initialValue = value; }
		public bool RunTimeValue { get => runTimeValue; private set => runTimeValue = value; }

		[SerializeField] private bool initialValue;
		private bool runTimeValue;

		[SerializeField] private BoolEvent notifyObserversEvent;
		[SerializeField] private bool notifyObservers;

		

		public void SetValue(bool _value)
        {
			runTimeValue = _value;
			NotifyObservers();
        }

		public void ClearValue()
        {
			runTimeValue = initialValue;
			NotifyObservers();
		}

		private void NotifyObservers()
        {
			if(notifyObserversEvent != null && notifyObservers)
            {
				notifyObserversEvent.Raise(runTimeValue);
            }

        }

		public void OnAfterDeserialize()
		{
			ClearValue();
		}

		public void OnBeforeSerialize()
		{

		}

	}
}


