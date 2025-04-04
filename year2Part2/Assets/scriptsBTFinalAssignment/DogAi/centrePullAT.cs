using NodeCanvas.Framework;
using ParadoxNotion.Design;
using Unity.VisualScripting;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class centrePullAT : ActionTask {

		public BBParameter<Vector3> acceleration;
		public BBParameter<float> dogSpeed;
        public Transform pullPosition;

		public float distance;
		public BBParameter<float> speedFactor;

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
		}


		protected override void OnUpdate() {

			distance = Vector3.Distance(pullPosition.position, agent.transform.position);

			acceleration.value += (pullPosition.position - agent.transform.position).normalized * (distance/speedFactor.value) * Time.deltaTime; 



            //float distance = Vector3.Distance(agent.transform.position, pullPosition.position);
            //pullForce = distance / 10 ;
            //agent.transform.position = pullForce * pullPosition.position;
            //Debug.Log("pull force" + pullForce); 


			EndAction(true);


        }

		protected override void OnStop() {
			
		}

		protected override void OnPause() {
			
		}
	}
}