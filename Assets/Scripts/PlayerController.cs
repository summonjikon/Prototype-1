using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public float turnSpeed;

    private float horizontalInput;
    private float verticalInput;

    public Camera thirdPerson;
    public Camera firstPerson;

    public string inputID;

    public KeyCode key;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        verticalInput = Input.GetAxis("Vertical" + inputID);

        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

        if(Input.GetKeyDown(key))
        {
            thirdPerson.enabled = !thirdPerson.enabled;
            firstPerson.enabled = !firstPerson.enabled; 
        }
    }
}
