using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class bugSprayAT : ActionTask {

		public BBParameter<float> digStrength;
		public BBParameter<bool> bugActive;

        public MeshRenderer meshRenderer;

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {

			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {

			//Checks if bug spawn value is true, if it is and the condition was met in the previous CT the char will turn white again and regain his stats
            if (bugActive.value == true)
            {
                digStrength.value = 5;
                bugActive.value = false;
                meshRenderer.material.color = Color.white;

                Debug.Log("bug spray used, effects back to normal");
            }

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