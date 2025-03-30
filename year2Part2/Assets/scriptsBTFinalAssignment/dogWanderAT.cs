using NodeCanvas.Framework;
using ParadoxNotion.Design;
using Unity.VisualScripting;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class dogWanderAT : ActionTask {

		public BBParameter<float> dogEnergy;

        public BBParameter<float> dogSpeed;
        public BBParameter<float> sleep;  
        public BBParameter<Transform> dogHouse;



        public float wanderSampleFrequency;
        public float wanderDirectionChangeFrequency;
        public BBParameter<Vector3> acceleration;

        private Vector3 randomPoint = Vector3.zero;
        private Vector3 currentAccelerationDirection = Vector3.zero;

        private float timeSinceLastDirectionChange = 0f;


        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {


            return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {



            timeSinceLastDirectionChange += Time.deltaTime;
            if (timeSinceLastDirectionChange > wanderDirectionChangeFrequency)
            {
                randomPoint = Random.insideUnitCircle.normalized;
                timeSinceLastDirectionChange = 0f;
                currentAccelerationDirection = new Vector3(randomPoint.x, 0, randomPoint.y);
            }

            Debug.DrawLine(agent.transform.position, currentAccelerationDirection + agent.transform.position);


            acceleration.value += currentAccelerationDirection.normalized * Time.deltaTime * dogSpeed.value;
            dogEnergy.value -= 2 * Time.deltaTime;



            //This has the dogs sleep requirement to be set depending on how far away it is from the doghouse when it runs out of energy
            float distanceToHouse = Vector3.Distance(agent.transform.position, dogHouse.value.position);
            if (dogEnergy.value <= 0)
            {
                sleep.value = 10 + distanceToHouse;
            }
            Debug.Log(distanceToHouse);

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