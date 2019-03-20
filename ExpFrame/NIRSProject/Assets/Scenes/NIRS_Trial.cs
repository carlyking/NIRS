using System.Collections;
using System.Data;
using BML_ExperimentToolkit.Scripts.ExperimentParts;
using UnityEngine;

namespace Scenes {
    public class NIRS_Trial : Trial {

        GameObject Cube;
        NIRSExp_ConfigOptions config;

        public NIRS_Trial(Experiment experiment, DataRow data) : base(experiment, data) {
        }

        protected override IEnumerator Pre() {
            config = (NIRSExp_ConfigOptions)Experiment.ConfigOptions;
            Cube = config.Cube;
            float size = (float)Data["Size"];
            Cube.transform.localScale = new Vector3(size, size, size);
            yield return null; 
        }


        protected override IEnumerator Main() {
            bool waiting = true;
            while (waiting) {
                if (IsParticipantResponse()) {
                    waiting = false;
                }
                yield return null;

            }
        }

        bool IsParticipantResponse() {
            if (Input.GetKeyDown(KeyCode.A)) {
                return true;
            }
            else {
                return false;
            }
        }

        protected override IEnumerator Post() {
            Data["RT"] = 5;
            yield return null;
        }
    }
}
