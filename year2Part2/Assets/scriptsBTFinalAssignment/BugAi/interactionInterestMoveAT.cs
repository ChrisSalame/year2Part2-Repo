using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class interactionInterestMoveAT : ActionTask {

		public BBParameter<Vector3> acceleration;
		public BBParameter<float> charSpeed;
		public float wanderFrequency;
		public float directionChange;



        private Vector3 randPoint = Vector3.zero;
        private Vector3 AccelDirection = Vector3.zero;

        private float DirectionChangeTime = 0f;

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {

            DirectionChangeTime += Time.deltaTime;
            if (DirectionChangeTime > wanderFrequency)
            {
                randPoint = Random.insideUnitCircle.normalized;
                DirectionChangeTime = 0f;
                AccelDirection = new Vector3(randPoint.x, 0, randPoint.y);
            }
            Debug.DrawLine(agent.transform.position, AccelDirection + agent.transform.position, Color.blue);
            acceleration.value += AccelDirection.normalized * Time.deltaTime * charSpeed.value;
            
			EndAction(true);
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
			
		}

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}