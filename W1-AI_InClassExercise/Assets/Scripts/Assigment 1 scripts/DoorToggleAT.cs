using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class DoorToggleAT : ActionTask {

        public bool doorToggle = true;
        public bool doorStatus = false;

        //false = door closed 
        //true = door open
        public GameObject door;

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
            ToggleDoor();
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
        private void ToggleDoor()
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                Vector2 DoorPosition = new Vector2(0, 0);
                if (doorStatus == false && doorToggle == true)
                {
                    DoorPosition = new Vector2(5.75f, 3.14f);
                    door.transform.transform.position = DoorPosition;
                    doorStatus = true;
                }
                else if (doorStatus == true && doorToggle == true)
                {
                    DoorPosition = new Vector2(5.75f, -0.4858583f);
                    door.transform.transform.position = DoorPosition;
                    doorStatus = false;
                }
                else
                {
                    Debug.LogError("door not ready for toggle function");

                }

            }
        }
    }

}