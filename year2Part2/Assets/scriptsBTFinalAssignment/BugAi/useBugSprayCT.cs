using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Conditions {

	public class useBugSprayCT : ConditionTask {

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


		//when player presses B they will use bug spray and condition returns true
		protected override bool OnCheck() {
            if (Input.GetKeyDown(KeyCode.B))
            {
                Debug.Log("bug spray used");
                return true;
            }
			else { return false; }
        }
	}
}