using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LetsCount : MonoBehaviour {

    public Text field;
	
	// Update is called once per frame
	void Update () {
        field.text = Time.fixedTime.ToString();
	}
}
