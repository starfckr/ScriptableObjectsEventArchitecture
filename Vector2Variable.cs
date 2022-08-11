using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace tutorial_2d
{
    [CreateAssetMenu(fileName = "vector2Variable", menuName = "Data/Variables/Vector2Variable")]
    public class Vector2Variable : ScriptableObject, ISerializationCallbackReceiver
    {

        public Vector2 InitialValue;
        [NonSerialized] public Vector2 RunTimeValue;



        public void OnAfterDeserialize()
        {
            RunTimeValue = InitialValue;
        }

        public void OnBeforeSerialize()
        {
        }
    }

}
