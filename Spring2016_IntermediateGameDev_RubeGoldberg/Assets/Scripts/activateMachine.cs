using UnityEngine;
using System.Collections;

public class activateMachine : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey(KeyCode.Space)){
			transform.eulerAngles += new Vector3 (0f, 90f * Time.deltaTime, 0f);
		}
	}
}
