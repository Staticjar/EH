using UnityEngine;
using System.Collections;

public class InitialForce : MonoBehaviour {
	public float thrust;
	public Rigidbody rb;
	public int x;
	public int y;
	public int z;
	//public void AddForce(float x, float y, float z, ForceMode mode = ForceMode.Force);

	// Use this for initialization
	void Start() {
		//public void AddForce(float x, float y, float z, ForceMode mode = ForceMode.Force);
		rb = GetComponent<Rigidbody>();
		rb.AddRelativeForce(x * thrust, y * thrust, z * thrust);
	}
	
	// Update is called once per frame
	void FixedUpdate() {

	}
}
