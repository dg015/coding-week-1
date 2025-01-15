using NodeCanvas.Framework;
using ParadoxNotion.Design;
using TMPro;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class UIUpdateAT : ActionTask {


        TextMeshProUGUI textUI;
        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
			//get the reference to the UI text
            textUI = GameObject.Find("Text").GetComponent<TextMeshProUGUI>();
            EndAction(true);
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
			
		}

		//Called when the task is disabled.
		protected override void OnStop() {
            
			//set text to not ready
            textUI.text = "not ready";
        }

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}