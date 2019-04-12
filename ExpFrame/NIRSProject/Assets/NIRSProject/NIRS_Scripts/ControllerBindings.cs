using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ControllerBindings : MonoBehaviour
{

    public SteamVR_Input_Sources  handType;
    public SteamVR_Action_Boolean largerAction;
    public SteamVR_Action_Boolean smallerAction;
    public SteamVR_Action_Boolean holdAction;


    // Update is called once per frame
    void Update() {

        if (CheckLarger()) {
            Debug.Log("CLICKED LARGER");

        }
        if (CheckSmaller()) {
            Debug.Log("CLICKED SMALLER");

        }
        if (CheckHold()) {
            Debug.Log(message:"HAND ON START");
        }
    }

private bool CheckLarger() {
        return largerAction.GetState(handType);
    }

private bool CheckSmaller() {
        return smallerAction.GetState(handType);
    }

    private bool CheckHold() {
        return holdAction.GetState(handType);
    }

}