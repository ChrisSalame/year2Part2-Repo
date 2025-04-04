using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class goToPlayerAT : ActionTask {

        public BBParameter<Transform> playerChar;
		public BBParameter<float> dogSpeed;

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
            Vector3 directionToMove = (playerChar.value.position - agent.transform.position);
			agent.transform.position += directionToMove.normalized * dogSpeed.value * Time.deltaTime;
            EndAction(true);
        }

		protected override void OnUpdate() {
			
		}
		protected override void OnStop() {
			
		}
		protected override void OnPause() {
			
		}
	}
}