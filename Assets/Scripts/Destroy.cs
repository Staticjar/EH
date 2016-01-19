using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {
    //destroys whatever it collides with
	private void OnCollisionEnter(Collision collision)
	{
			Destroy(collision.gameObject);
	}
}
