using UnityEngine;
using System.Collections;





public class Arrow_Left_Movement : MonoBehaviour {

	// Use this for initialization
	public void Start (Transform Arrow, Transform SP) {
		Arrow.position = SP.position;
		Arrow.position = Arrow.position + new Vector3 (0, .5f, -.3f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
