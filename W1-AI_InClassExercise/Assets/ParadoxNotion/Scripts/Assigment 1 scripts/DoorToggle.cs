using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorToggle : MonoBehaviour
{
    public bool doorToggle;
    public bool doorStatus = false;
    private GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        door = GameObject.Find("Door").GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (doorStatus == false && doorToggle == true)
        {

        }
        else if (doorStatus == true && doorToggle == true)
        {

        }
        else
        {
            Debug.LogError("door not ready for toggle function");

        }
    }
}
