using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody myRigidbody;
    private Vector3 my_input;
    public GameObject player_object;
    public Camera mainCamera;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        mainCamera = FindObjectOfType<Camera>();
    }

    void Update()
    {
        my_input = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        Vector3 velocity = my_input.normalized * moveSpeed;
        player_object.gameObject.transform.position += velocity * Time.deltaTime;
        //mainCamera.transform.position += velocity * Time.deltaTime;
    }
    
}
