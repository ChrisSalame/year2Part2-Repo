using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Conditions {

	public class playerInRangeCT : ConditionTask {

        public BBParameter<Transform> playerChar;
        public float radius;

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit(){
			return null;
		}
		protected override void OnEnable() {
			
		}
		protected override void OnDisable() {
			
		}

		//Called once per frame while the condition is active.
		//Return whether the condition is success or failure.
		protected override bool OnCheck() {
            float distanceToPlayer = Vector3.Distance(agent.transform.position, playerChar.value.position);
            return distanceToPlayer < radius;
		}
	}
}