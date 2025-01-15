using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class DoorToggleAT : ActionTask {

		DoorScript DoorScript;
		
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
			DoorScript = GameObject.Find("Door").GetComponent<DoorScript>();
			if(DoorScript = GameObject.Find("Door").GetComponent<DoorScript>())
			{
				Debug.Log("got script");
			}
			else
			{
                Debug.Log("didnt got script");
            }
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
			Debug.Log("door");
            if (Input.GetKeyDown(KeyCode.C))
            {
				DoorScript.DoorToggle();
				if(DoorScript.doorStatus ==true) 
				{
					DoorScript.doorStatus = false;
				}
				else if(DoorScript.doorStatus ==false)
				{
					DoorScript.doorStatus = true;
				}
                GameObject.Find("Light bulb").GetComponent<Renderer>().material.color = new Color(255,0,0);

            }
        }
    }

}