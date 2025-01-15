using NodeCanvas.Framework;
using ParadoxNotion.Design;
using TMPro;
using UnityEngine;


namespace NodeCanvas.Tasks.Conditions {

	public class WaiterCT : ConditionTask {

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise

        //timer variables
        float runTime;
        float maxTime = 5;


        Renderer light;
        TextMeshProUGUI textUI;
        DoorScript DoorScript;

        protected override string OnInit(){
			return null;
		}

		//Called whenever the condition gets enabled.
		protected override void OnEnable() {
            //get all the references needed
            DoorScript = GameObject.Find("Door").GetComponent<DoorScript>();
            textUI = GameObject.Find("Text").GetComponent<TextMeshProUGUI>();
            light = GameObject.Find("Light bulb").GetComponent<Renderer>();
        }

		//Called whenever the condition gets disabled.
		protected override void OnDisable() {
            //this function works as a way to reset everything to default (green colour, ready text)
            //set colour to green and text to ready
            light.material.color = new Color(0, 255, 0);
            textUI.text = "ready";
            //reset run time so that when script is called again timer works correctly
            runTime = 0;
            DoorScript.doorToggle = true;
        }

		//Called once per frame while the condition is active.
		//Return whether the condition is success or failure.
		protected override bool OnCheck() {
            //timer
            //decrease timer
            runTime += Time.deltaTime;
            //check if its over or not
            if (runTime >= maxTime)
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