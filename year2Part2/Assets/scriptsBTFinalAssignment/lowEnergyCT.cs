using NodeCanvas.Framework;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization.FullSerializer;
using Unity.VisualScripting;
using UnityEngine;


namespace NodeCanvas.Tasks.Conditions {

	public class lowEnergyCT : ConditionTask {

        public BBParameter<float> dogEnergy;
		public BBParameter<float> sleep;
		public BBParameter<Transform> dogHouse;

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit(){

			float distanceToHouse = Vector3.Distance(agent.transform.position, dogHouse.value.position);
            sleep.value = 10 + distanceToHouse;
            Debug.Log(distanceToHouse);

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


			if (dogEnergy.value <= 0)
			{
				Debug.Log("energy below 0"); 
				return true;	
			}
			else 
			{
				return false;
			}

		}
	}
}