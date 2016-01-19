using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StartUp : MonoBehaviour {
    public GameObject particleTrap;
    public GameObject initParticle;
    public GameObject lrgParticle;
    public GameObject smllParticle;
    public List<GameObject> startItems;
    //instantiate 3000 particles in a unit sphere
    //give them thrust
    // Use this for initialization
    void Start () {
        GameObject pt = Instantiate(particleTrap);
        Transform target = GameObject.Find("BlackHole").transform;
        for(int i = 0; i < 250; i++)
        {
            Vector3 pos = Random.insideUnitCircle * 250;
            startItems.Add(Instantiate(initParticle, pos, initParticle.transform.rotation) as GameObject);
            startItems[i].transform.LookAt(target);
            startItems[i].transform.parent = target;
        }
        target.Rotate(88, 0, 0);
        target.transform.DetachChildren();


        for (int i = 0; i < 0; i++)
        {
            Vector3 pos = Random.insideUnitSphere * 500;
            GameObject obj = Instantiate(lrgParticle, pos, lrgParticle.transform.rotation) as GameObject;
        }

        Destroy(pt);
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(Input.GetKeyUp("escape"))
        {
            Application.Quit();
        }
        if(Input.GetKeyUp("3"))
        {
            GetComponent("Stereoskopix 3D");
        }
	}
}
