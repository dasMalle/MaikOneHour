using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.rotation = Quaternion.Euler(0f, 0f, transform.rotation.eulerAngles.z + Time.deltaTime * 10);
	}
}
