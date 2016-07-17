using UnityEngine;
using System.Collections;

public class SetControllerCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<Canvas>().worldCamera = GameObject.Find("Controller UI Camera").GetComponent<Camera>();
    }
}
