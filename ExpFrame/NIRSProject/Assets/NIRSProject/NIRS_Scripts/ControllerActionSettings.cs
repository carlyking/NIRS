using UnityEngine;
using Valve.VR;

[CreateAssetMenu]
public class ControllerActionSettings : ScriptableObject {
    public SteamVR_Input_Sources handType;
    public SteamVR_Action_Boolean largerAction;
    public SteamVR_Action_Boolean smallerAction;
    public SteamVR_Action_Boolean responseAction;
    public SteamVR_Action_Boolean holdAction;
}