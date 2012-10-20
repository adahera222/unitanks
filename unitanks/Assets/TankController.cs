using UnityEngine;
using System.Collections;

public class TankController : MonoBehaviour {
	
	public float speed = 20;
	public Quaternion initialRotation;
	// Use this for initialization
	void Start () {
		initialRotation = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {

		rigidbody.velocity = Vector3.zero;
		
		if (Input.GetKey(KeyCode.RightArrow)) {
			transform.rotation = initialRotation;
			rigidbody.AddForce(transform.right * speed, ForceMode.Impulse);
			transform.Rotate(new Vector3(0, 180, 0));
		}
		
		if (Input.GetKey(KeyCode.LeftArrow)) {
			transform.rotation = initialRotation;
			rigidbody.AddForce(-transform.right * speed, ForceMode.Impulse);
			transform.Rotate(new Vector3(0, 0, 0));
		}
		
		if (Input.GetKey(KeyCode.DownArrow)) {
			transform.rotation = initialRotation;
			rigidbody.AddForce(-transform.forward * speed, ForceMode.Impulse);
			transform.Rotate(new Vector3(0, -90, 0));
		}
		
		if (Input.GetKey(KeyCode.UpArrow)) {
			transform.rotation = initialRotation;
			rigidbody.AddForce(transform.forward * speed, ForceMode.Impulse);
			transform.Rotate(new Vector3(0, 90, 0));
		}
		
	}
}
