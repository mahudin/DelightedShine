using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassageScript : MonoBehaviour
{
    public Material OwnMaterial;
    public GameObject Plane;
    public GameObject Wall1;
    public GameObject Wall2;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Passenger is triggered");
        if (other.gameObject.tag == "Player")
        {
            MeshRenderer meshRenderer = Plane.GetComponent<MeshRenderer>();
            Plane.GetComponent<MeshRenderer>().material = OwnMaterial;

            //MeshRenderer meshRenderer = Wall1.GetComponent<MeshRenderer>();
            Wall1.GetComponent<MeshRenderer>().material = OwnMaterial;

            //MeshRenderer meshRenderer = Wall2.GetComponent<MeshRenderer>();
            Wall2.GetComponent<MeshRenderer>().material = OwnMaterial;
            //Material oldMaterial = meshRenderer.material;
            //print the material name in the console
            //Debug.Log("Applied Material: " + oldMaterial.name);



            Debug.Log("Player Detected");
        }
    }
}
