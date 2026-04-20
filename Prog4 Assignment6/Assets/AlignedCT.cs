using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Conditions {

	public class AlignedCT : ConditionTask {

		public GameObject player;

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
			if (Vector3.Distance(new Vector3(0, 0, agent.transform.position.z), new Vector3(0, 0, player.transform.position.z)) >= 1)
			{
                return true;
            }
			else
			{
				return false;
			}
		}
	}
}