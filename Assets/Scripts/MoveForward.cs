using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{

    public float speed = 40f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Mover hacia adelante a la velocidad speed
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
