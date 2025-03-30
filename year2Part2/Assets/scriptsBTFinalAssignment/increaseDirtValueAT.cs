using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class increaseDirtValueAT : ActionTask {

		public BBParameter<float> dirtValue;

		public BBParameter<float> dogEnergy;

		//Old solution
		//Blackboard agentBlackboard;


		protected override string OnInit() {
			
			//Oldsolution
			//agentBlackboard = agent.GetComponent<Blackboard>();

			return null;
		}

		protected override void OnExecute() {

			//This adds 7 more to the dirt value. This is the dog kicking in dirt into the players flowers/gardening
			dirtValue.value += 7f * Time.deltaTime;
			
			//this heavily reduces the energy of the dog when it "kicks around" the dirt
			dogEnergy.value -= 10f * Time.deltaTime;


			//Below is the old solution

			//Creates valuu that matches global blackboard value
			//float dirtLevel = agentBlackboard.GetVariableValue<float>("dirtValue");
			//adds desired number
			//dirtLevel += 7;
			//sets dirt value equal to new variable, dirtLevel
			//agentBlackboard.SetVariableValue("dirtValue",dirtLevel);

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