using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace tutorial_2d
{
	[CreateAssetMenu(fileName = "stringVariable", menuName = "Data/Variables/StringVariable")]
	public class StringVariable : ScriptableObject, ISerializationCallbackReceiver
	{
		public string InitialValue;
		public string RunTimeValue;
		


		public void OnAfterDeserialize()
		{
			RunTimeValue = InitialValue;
		}

		public void OnBeforeSerialize()
		{

		}


	}
}


