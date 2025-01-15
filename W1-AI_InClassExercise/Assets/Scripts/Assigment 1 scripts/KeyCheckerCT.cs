using NodeCanvas.Framework;
using NodeCanvas.Tasks.Actions;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Conditions {

	public class KeyCheckerCT : ConditionTask {

        DoorScript DoorScript;

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit(){
			return null;
		}

        //Called whenever the condition gets enabled.
        protected override void OnEnable()
        {
            //get the scripts
            DoorScript = GameObject.Find("Door").GetComponent<DoorScript>();
            if (DoorScript = GameObject.Find("Door").GetComponent<DoorScript>())
            {
                Debug.Log("got script");
            }
            else
            {
                Debug.LogError("DIDNT GET SCRIPT");
            }

        }
        //Called whenever the condition gets disabled.
        protected override void OnDisable() {
			
		}

		//Called once per frame while the condition is active.
		//Return whether the condition is success or failure.
		protected override bool OnCheck() {
            Debug.Log("door");
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
                //change colour of lamp
                GameObject.Find("Light bulb").GetComponent<Renderer>().material.color = new Color(255, 0, 0);
                return true;
            }
            return false;
        }
	}
}