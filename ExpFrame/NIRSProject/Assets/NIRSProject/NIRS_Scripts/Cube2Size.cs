using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube2Size : MonoBehaviour {
    GameObject rotater;

    void Start() {
        rotater = GameObject.Find("Cube");
    }
    public void btnChangeHeight() {
        rotater.gameObject.transform.localScale += newVector3(0, 50, 0);
    }
    void OnGUI() {
        if (GUI.RepeatButton(new Rect(40, 60, 70, 21), "Height")) {
            rotater.gameObject.transform.localScale += new Vector3(0, 1, 0);
        }
    }
}
}

// Update is called once per frame
void Update()
    {

}
}



using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour {
void Example() {
// Widen the object by 0.1
transform.localScale += new Vector3(0.1F, 0, 0);
}
}
