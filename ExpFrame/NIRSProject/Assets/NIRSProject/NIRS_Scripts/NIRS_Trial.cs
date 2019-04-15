using System.Collections;
using System.Data;
using BML_ExperimentToolkit.Scripts.ExperimentParts;
using UnityEngine;
using Valve.VR;

namespace Scenes {
    public class NIRS_Trial : Trial {

        GameObject Cube;
        NIRS_ExperimentRunner nirsRunner;
        CubeSizeChanger cubeSize;

        bool trialDoneFlag;

        public NIRS_Trial(ExperimentRunner runner, DataRow data) : base(runner, data) {
        }

        public override void PreMethod() {
            nirsRunner = (NIRS_ExperimentRunner)Runner;
            Cube = nirsRunner.Cube;
            float length = (float)Data["Length"];
            float width = (float)Data["Width"];
            float height = (float)Data["Height"];
            cubeSize = Cube.GetComponent<CubeSizeChanger>();
            cubeSize.SetSize(new Vector3(x:length, y:width, z:height));
            trialDoneFlag = false;

            nirsRunner.ControllerSettings.responseAction.onStateDown += FlipDoneSwitchEvent;
        }

        
        protected override IEnumerator RunMainCoroutine() {
            bool waiting = true;
            while (waiting) {
                if (trialDoneFlag) {
                    waiting = false;
                }
                yield return null;

            }
        }

        

        protected override void PostMethod() {
            Data["MatchLength"] = cubeSize.ReturnLength();
            


            trialDoneFlag = false;
            nirsRunner.ControllerSettings.responseAction.onStateDown -= FlipDoneSwitchEvent;
        }

        void FlipDoneSwitchEvent(SteamVR_Action_Boolean fromaction, SteamVR_Input_Sources fromsource) {
            FlipTrialDone();
        }

        void FlipTrialDone() {
            trialDoneFlag = true;
        }
    }
}
