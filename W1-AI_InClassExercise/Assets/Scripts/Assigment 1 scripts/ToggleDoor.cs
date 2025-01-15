using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class ToggleDoor : ActionTask {

        DoorScript DoorScript;

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
            //get script for door script
            DoorScript = GameObject.Find("Door").GetComponent<DoorScript>();
            //check if the script was retrivied
            if (DoorScript = GameObject.Find("Door").GetComponent<DoorScript>())
            {
                //if got the script
                Debug.Log("got script");
            }
            else
            {
                //didnt get the script
                Debug.LogError("DIDNT GET SCRIPT");
            }
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {

            doorToggle();
        }

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}


		private void doorToggle()
		{
            if (Input.GetKeyDown(KeyCode.C))
            {
                DoorScript.DoorToggle();
                if (DoorScript.doorStatus == true)
                {
                    //closes door and set toggle to false
                    DoorScript.doorStatus = false;
                    DoorScript.doorToggle = false;
                    
                }
                else if (DoorScript.doorStatus == false)
                {
                    //Opens door and set toggle to false
                    DoorScript.doorStatus = true;
                    DoorScript.doorToggle = false;
                }
                EndAction(true);
                
            }

            
        }
        
    
	}
}