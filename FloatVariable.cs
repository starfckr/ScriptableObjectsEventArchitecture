using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace tutorial_2d
{
	[CreateAssetMenu(fileName = "floatVariable", menuName = "Data/Variables/FloatVariable")]
	public class FloatVariable : ScriptableObject, ISerializationCallbackReceiver
	{
		[SerializeField] private FloatEvent notifyObserversEvent;
		[SerializeField] private bool notifyObservers;
		public float InitialValue;

		//[NonSerialized]
		public float RunTimeValue;

		public void AddToRunTimeValue(float _value)
		{
			RunTimeValue += _value;
			NotifySubscribers(_value);
		}
		public void SubtractFromRunTimeValue(float _value)
		{
			RunTimeValue -= _value;
			NotifySubscribers(_value);
		}

		private void NotifySubscribers(float _value)
		{
			if (notifyObserversEvent != null && notifyObservers)
			{
				notifyObserversEvent.Raise(_value);
			}
		}

		public void OnAfterDeserialize()
		{
			RunTimeValue = InitialValue;
		}

		public void OnBeforeSerialize()
		{

		}


	}
}



