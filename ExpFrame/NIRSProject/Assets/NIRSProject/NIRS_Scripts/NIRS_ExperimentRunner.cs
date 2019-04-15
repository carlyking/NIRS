using System;
using System.Collections;
using System.Collections.Generic;
using BML_ExperimentToolkit.Scripts.ExperimentParts;
using BML_Utilities.EventSystem;
using Scenes;
using UnityEngine;

public class NIRS_ExperimentRunner : ExperimentRunner
{

    public GameObject Cube;
    public ControllerActionSettings ControllerSettings;


    public override Type TrialType {
        get {
            return typeof(NIRS_Trial);
        }
    }
}
