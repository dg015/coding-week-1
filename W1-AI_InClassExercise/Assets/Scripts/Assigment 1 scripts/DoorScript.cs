using NodeCanvas.Tasks.Actions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    //door toggle is variable to check if player can toggle (open/close) door
    public bool doorToggle = true;
    public bool doorStatus = false;
    


    //false = door closed 
    //true = door open
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoorToggle()
    {
        //create new vector
        Vector2 DoorPosition = new Vector2(0, 0);
        if (doorStatus == false && doorToggle == true)
        {
            //opens the door
            DoorPosition = new Vector2(5.75f, 3.14f);
            door.transform.transform.position = DoorPosition;
            //doorStatus = true;
        }
        else if (doorStatus == true && doorToggle == true)
        {
            //closes the door
            DoorPosition = new Vector2(5.75f, -0.4858583f);
            door.transform.transform.position = DoorPosition;
            //doorStatus = false;
        }



    }
}
