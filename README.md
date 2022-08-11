# ScriptableObjectsEventArchitecture


Variables can be anything, either base objects or its own classes. Examples are "IntVariable, FloatVariable, BoolVariable, and LevelObjectVariable (class that refers to another scriptable object detailing level details)"

Each variable has an initial value set in the inspector, and a run-time value that can be manipulated during runtime.
Each variable also has the possibility for adding events or "observers" to observe when changes happen to the variable in question.

Variables are then created in the editor and then referenced across the various scripts that need them.

Events builds upon "BaseGameEvent" and "BaseGameEventListener" and is basically just defining various types of events that can be triggered, and can be as simple as a Vector2, int, float, or any base or as complex as your own classes, etc.

Each event consists then of:

IntEvent
UnityIntEvent
IntEventListener

the "UnityIntEvent" is referred to by the script that will trigger an event, and the "IntEventListener" is attached to the gameobject that will listen to the event, and must be connected to a function within a script that handles the event.
