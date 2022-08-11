using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace tutorial_2d
{
	[CreateAssetMenu(fileName = "levelObjectVariable", menuName = "Data/Variables/Level Object Variable")]
	public class LevelObjectVariable : ScriptableObject, ISerializationCallbackReceiver
	{

		public LevelObject InitialValue;
		[System.NonSerialized] public LevelObject RunTimeValue;



		public void OnAfterDeserialize()
		{
			RunTimeValue = InitialValue;
		}

		public void OnBeforeSerialize()
		{

		}


	}
}


