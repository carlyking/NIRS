using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ControllerBindings : MonoBehaviour
{

    public SteamVR_Input_Sources  handType;
    public SteamVR_Action_Boolean grabAction;
    public SteamVR_Action_Boolean holdAction;


    // Update is called once per frame
    void Update() {

        if (CheckGrab()) {
            Debug.Log("GRAB ACTION");

        }
        if (CheckHold()) {
            Debug.Log(message:"HAND ON START");
        }
    }

private bool CheckGrab() {
        return grabAction.GetState(handType);
    }

private bool CheckHold() {
    return holdAction.GetState(handType);
    }

}