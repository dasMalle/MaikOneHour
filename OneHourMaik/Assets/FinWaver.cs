using UnityEngine;
using System.Collections;

public class FinWaver : MonoBehaviour {

	public GameObject leftFin;
	public GameObject rightFin;
	public AudioClip whaleCry;
	public AudioSource Source;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.A)) {
			leftFin.GetComponent<Animation> ().Play ();
		}
		if(Input.GetKeyDown(KeyCode.L)){
			rightFin.GetComponent<Animation> ().Play();
		}

			if(Random.Range(0,4) == 2)
			{
				Source.PlayOneShot(whaleCry);
			}
	}

	
}
