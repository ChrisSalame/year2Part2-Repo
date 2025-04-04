using JetBrains.Annotations;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization.FullSerializer;
using UnityEngine;


namespace NodeCanvas.Tasks.Conditions {

	public class playerDigCT : ConditionTask {

		public BBParameter<bool> bugActive;

		public int bugSpawnChance;
		public int bugSpawnRoll;

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit(){
			return null;
		}

		//Called whenever the condition gets enabled.
		protected override void OnEnable() {

        }

		//Called whenever the condition gets disabled.
		protected override void OnDisable() {
			
		}

		//Called once per frame while the condition is active.
		//Return whether the condition is success or failure.
		protected override bool OnCheck() {


			//Each time the player would dig they set 2 variables randomly, if the
			//variables match then the bug value is turned to true and the variables are reset to prevent infinit loop bugs 

			//--------------------------would like to add signifier for audio/ animation if possible--------------------------

            if (Input.GetKeyDown(KeyCode.Space)) 
			{
                bugSpawnRoll = Random.Range(0, 5);
                Debug.Log("bug roll = " + bugSpawnRoll);

                bugSpawnChance = Random.Range(0, 5);
                Debug.Log("bug Chance = " + bugSpawnChance);

				if (bugSpawnRoll == bugSpawnChance) 
				{

					bugActive.value = true;
					//This resets the bugs values
					bugSpawnChance = 1; 
					bugSpawnRoll = 0;
					Debug.Log("BUGS SPAWN BUGS SPAWN BUGS SPAWN"); 
				}
                return true;
			}
			else 
			{
				return false; 
			}


		}
	}
}