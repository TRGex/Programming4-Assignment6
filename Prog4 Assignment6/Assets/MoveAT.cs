using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions {

	public class MoveAT : ActionTask {

		public BBParameter<Vector3> localTarget;

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

		//Called once per frame while the action is active.
		protected override void OnUpdate() {

            if (agent.transform.position.z >= localTarget.value.z - 1 && agent.transform.position.z <= localTarget.value.z + 1)
            {
                EndAction();
            }

            if (agent.transform.position.z < localTarget.value.z)
            {
				agent.transform.Translate(0,0,2 * Time.deltaTime);
				Debug.Log(agent.transform.position.z + "1");
            }
			else if (agent.transform.position.z > localTarget.value.z)
			{
				agent.transform.Translate(0,0, -2f * Time.deltaTime);
                Debug.Log(agent.transform.position.z + "2");
            }

        }

		//Called when the task is disabled.
		protected override void OnStop() {
			localTarget.value = new Vector3(0,0,0);
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}