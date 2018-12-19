using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotationScript : MonoBehaviour {

    InputField inputAngle;
    InputField inputX;
    InputField inputY;
    InputField inputZ;

    // Use this for initialization
    void Start () {
        inputAngle = GameObject.FindWithTag("inputAngle").GetComponent<InputField>();
        inputX = GameObject.FindWithTag("inputX").GetComponent<InputField>();
        inputY = GameObject.FindWithTag("inputY").GetComponent<InputField>();
        inputZ = GameObject.FindWithTag("inputZ").GetComponent<InputField>();
    }
    
    // Update is called once per frame
    void Update () {
        
    }

    public void rotateCube() {
        
        //InputField inputAngle = GameObject.FindWithTag("inputAngle").GetComponent<InputField>();
        //InputField inputX = GameObject.FindWithTag("inputX").GetComponent<InputField>();
        //InputField inputY = GameObject.FindWithTag("inputY").GetComponent<InputField>();
        //InputField inputZ = GameObject.FindWithTag("inputZ").GetComponent<InputField>();

        float angle = inputAngle.text.Equals("") ? 0f : float.Parse(inputAngle.text);
        float x = inputX.text.Equals("") ? 0f : float.Parse(inputX.text);
        float y = inputY.text.Equals("") ? 0f : float.Parse(inputY.text);
        float z = inputZ.text.Equals("") ? 0f : float.Parse(inputZ.text);

        Vector3 axis = new Vector3(x, y, z);
        Quaternion q = Quaternion.AngleAxis(angle, axis);

        this.transform.rotation = q * this.transform.rotation; 

    }
}
