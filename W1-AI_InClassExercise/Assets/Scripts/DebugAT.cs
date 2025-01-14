using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class DebugAT : ActionTask {

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit() {
			//initialize variable values
			//getComponent
			//get the initial possition of character
			//FindObject
			Debug.Log("initializaing the state");
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
            //seting a booelan at the start
            //flipping a character upside down
            //setting dynamic varaibles tat can change over time
            //reseting values when uou jump into the state


            Debug.Log("executing the state");


            EndAction(true);
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
			Debug.Log("update is running");
			//agent.transform.position += agent.transform.forward * 3f * Time.deltaTime;
			//Rigidbody rb = agent.GetComponent<Rigidbody>();
			//agent.gameObject.SetActive(false);
		}

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}