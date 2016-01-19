using UnityEngine;
using System.Collections;

public class FauxGravityBody : MonoBehaviour
{

    public FauxGravityAttractor[] inattractor;
    //public FauxGravityAttractor inattractor2;
    private Transform myTransform;
    private GameObject[] objs;
    public static FauxGravityAttractor attractor;
    // Use this for initialization
    void Start()
    {
        objs = GameObject.FindGameObjectsWithTag("Gravity");
        GatherAttractors();
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        GetComponent<Rigidbody>().useGravity = false;
        myTransform = transform;
    }

    void GatherAttractors()
    {
        inattractor = new FauxGravityAttractor[objs.Length];
        for (int i = 0; i < inattractor.Length; i++)
        {
            inattractor[i] = objs[i].GetComponent<FauxGravityAttractor>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        objs = GameObject.FindGameObjectsWithTag("Gravity");
        if (objs.Length != inattractor.Length)
        {
            GatherAttractors();
        }
        for (int i = 0; i < inattractor.Length; i++)   
        {
            if(inattractor[i] != null)
            {
                attractor = inattractor[i];
            }
            attractor.Attract(myTransform);
        }
    }
}
