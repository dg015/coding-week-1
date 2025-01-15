using NodeCanvas.Framework;
using ParadoxNotion.Design;
using TMPro;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class DoorToggleAT : ActionTask {

		 TextMeshProUGUI textUI;
        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {
			Debug.Log("entered state door");
            return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
			textUI = GameObject.Find("Text").GetComponent<TextMeshProUGUI>();
			textUI.text = "ready";
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
            CallToggleDoor();
            EndAction(true);
        }

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
        private void CallToggleDoor()
        {
			//sets bulb back to green
			GameObject.Find("Light bulb").GetComponent<Renderer>().material.color = new Color(0,255,0);
        }
    }

}