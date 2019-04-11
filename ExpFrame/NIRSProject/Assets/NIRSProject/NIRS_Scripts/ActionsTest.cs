using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ActionsTest : MonoBehaviour
{

    public SteamVR_Input_Sources  handType; // type of hands for input
    public SteamVR_Action_Boolean teleportAction; // reference to the teleport action
    public SteamVR_Action_Boolean grabAction; // reference to the grab action

    public bool GetTeleportDown() // see if teleport was activated, return 'true' if teleport was activated
    {
        return teleportAction.GetStateDown(handType);
    }

    public bool GetGrab() // see if grab was activated
    {
        return grabAction.GetState(handType);
    }

}

// Update is called once per frame
// Checks the methods created and prints a message to the console when these return 'true'
// void Update() 
   // {
  //  if (GetTeleportDown())
//{
        //print("Teleport " + handType);
//}

    //if (GetGrab())
//{
       // print("Grab " + handType);
//}


//}
//}
