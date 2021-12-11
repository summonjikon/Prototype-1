using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCar : MonoBehaviour
{
    public GameObject Car;

    private Vector3 offset = new Vector3(0f, 5.15f, -6.76f);
 
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Car.transform.position + offset;

    }


}
