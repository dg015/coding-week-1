using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class ColorChangeUI : ActionTask {

		Renderer light;

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
			//get material renderer reference
			light = GameObject.Find("Light bulb").GetComponent<Renderer>();
			//set it to red
			light.material.color = new Color(255, 0, 0);
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