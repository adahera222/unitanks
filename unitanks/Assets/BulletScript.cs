using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {
	
	public float speed = 100;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody.AddForce(-transform.right * speed, ForceMode.Impulse);
	}
	
	void OnCollisionEnter(Collision col) {
		DestroyObject(this.gameObject);
	}
	
}
