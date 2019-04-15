using System;
using System.Collections;
using System.Collections.Generic;
using BML_Utilities.ScriptableObject_Assets;
using UnityEngine;
using Valve.VR;

public class CubeSizeChanger : MonoBehaviour {

    public ControllerActionSettings ControllerActions;
    public FloatValue scaleSpeed;
    public FloatValue maxScale;
    public FloatValue minScale;


    void OnEnable() {
        ControllerActions.largerAction.onState += LargerActionEvent;
        ControllerActions.smallerAction.onState += SmallerActionEvent;
    }

    void OnDisable() {
        ControllerActions.largerAction.onState -= LargerActionEvent;
        ControllerActions.smallerAction.onState -= SmallerActionEvent;
    }

    void SmallerActionEvent(SteamVR_Action_Boolean fromaction, SteamVR_Input_Sources fromsource) {
        MakeSmaller();
    }

    void LargerActionEvent(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource) {
        MakeLarger();
    }

    void MakeSmaller() {
        ChangeSize(Direction.Smaller);
    }

    void MakeLarger() {
        ChangeSize(Direction.Bigger);
    }

    enum Direction {
        Bigger,
        Smaller
    }

    void ChangeSize(Direction direction) {
        Vector3 newScale = transform.localScale;

        switch (direction) {
            case Direction.Bigger:
                newScale.x += Time.deltaTime * scaleSpeed;
                break;
            case Direction.Smaller:
                newScale.x += Time.deltaTime * -scaleSpeed;
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
        }

        newScale.x = Mathf.Clamp(newScale.x, minScale, maxScale);
        transform.localScale = newScale;
    }

    public void SetSize(Vector3 size) {
        transform.localScale = size;
    }

    public float ReturnLength() {
        return transform.localScale.x;
    }
}
