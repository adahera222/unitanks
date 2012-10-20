using UnityEngine;
using System.Collections;

public class AIController : MonoBehaviour {
	public float speed = 20;
	public Quaternion initialRotation;
	public GameObject mBullet;
	public GameObject playerTank;
	
	// Use this for initialization
	void Start () {
		initialRotation = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {

		rigidbody.velocity = Vector3.zero;
		
		rigidbody.AddForce(-transform.right * speed, ForceMode.Impulse);
			
		int shoot = Random.Range(1, 100);
		if (shoot == 1) {
			Instantiate(mBullet, transform.position, transform.rotation);
		}
		
	}
	
	
	void OnCollisionEnter(Collision col) {
		int type = Random.Range(1, 3);
		if (type == 1) {
			transform.rotation = initialRotation;
			rigidbody.AddForce(transform.right * speed, ForceMode.Impulse);
			transform.Rotate(new Vector3(0, 180, 0));
		}
		
		if (type == 2) {
			transform.rotation = initialRotation;
			rigidbody.AddForce(-transform.forward * speed, ForceMode.Impulse);
			transform.Rotate(new Vector3(0, -90, 0));
		}
		
		if (type == 3) {
			transform.rotation = initialRotation;
			rigidbody.AddForce(transform.forward * speed, ForceMode.Impulse);
			transform.Rotate(new Vector3(0, 90, 0));
		}
		
		DestroyObject(this.gameObject);
	}
}
