using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace tutorial_2d
{
	[CreateAssetMenu(fileName = "intVariable", menuName = "Data/Variables/IntVariable")]
	public class IntVariable : ScriptableObject, ISerializationCallbackReceiver
	{

		public int InitialValue { get => initialValue; private set => initialValue = value; }
		public int RunTimeValue { get => runTimeValue; private set => runTimeValue = value; }

		[SerializeField] private int initialValue;
		[SerializeField] private int runTimeValue;

		[SerializeField] private IntEvent notifyObserversEvent;
		[SerializeField] private bool notifyObservers;



		public void AddToRunTimeValue(int _value)
        {
			runTimeValue += _value;
			NotifyObservers(runTimeValue);
			
        }
		public void SubtractFromRunTimeValue(int _value)
        {
			runTimeValue -= _value;
			NotifyObservers(runTimeValue);
        }

		public void SetValue(int _value)
        {
			runTimeValue = _value;
			NotifyObservers(runTimeValue);
        }

		public void ClearValue()
        {
			runTimeValue = initialValue;
			NotifyObservers(runTimeValue);
		}

		private void NotifyObservers(int _value)
        {
			if(notifyObserversEvent != null && notifyObservers)
            {
				notifyObserversEvent.Raise(_value);
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


