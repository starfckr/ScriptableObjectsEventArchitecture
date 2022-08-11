using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace tutorial_2d
{
	[CreateAssetMenu(fileName = "intListVariable", menuName = "Data/Variables/Int List Variable")]
	public class IntListVariable : ScriptableObject, ISerializationCallbackReceiver
	{

		[SerializeField] private List<int> InitialValue = new List<int>();

		[System.NonSerialized] public List<int> RunTimeValue = new List<int>();

		

		public void OnAfterDeserialize()
		{
			InitialValue = new List<int>();
			RunTimeValue = new List<int>();
			RunTimeValue = InitialValue;
		}

		public void OnBeforeSerialize()
		{

		}


	}
}


