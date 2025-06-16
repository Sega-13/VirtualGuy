                                                      ** # VirtualGuy**    

A 2D platformer game that contains traps when a Player collides with traps  and  Cherries. Virtual Guy hunts for cherries.    

**What I did** : Created a 2D platformer game, "Virtual Guy," with player movement, collectibles, moving platforms, level transitions, UI menus, and sound effects using Unity and C#. Implemented modular scripts, prefabs, and scene management to build a multi-level gameplay experience.   

**GENRE** : Platformer, Adventure    
**Technology** :    
                •	Unity Engine   
                •	C#    
                •	TextMeshPro   
                •	Unity Scene System   
                •	AudioSource   
                •	Prefab System    
**Design Pattern**
1.	Singleton Pattern
•	Used in LevelManager.cs via LevelManager.Instance.
•	Ensures centralized management of level completion status.
2.	Component-Based Architecture (Unity-native)
•	Each behavior (e.g., movement, rotation, sound) is encapsulated in its own MonoBehaviour.
3.	State Management
•	LevelStatus.cs and LevelManager.cs likely manage progress and unlocked levels.
4.	Encapsulation with Serialized Fields
•	Scripts use [SerializeField] to expose fields in Unity’s Inspector without making them public.

**Images**







