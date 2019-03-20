using System;
using System.Collections;
using System.Collections.Generic;
using BML_ExperimentToolkit.Scripts.ExperimentParts;
using Scenes;
using UnityEngine;

public class NIRS_Experiment : Experiment
{
    public override Type TrialType {
        get {
            return typeof(NIRS_Trial);
        }
    }
}
