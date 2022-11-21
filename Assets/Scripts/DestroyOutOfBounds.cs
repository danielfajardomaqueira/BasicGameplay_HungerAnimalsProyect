using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    public float upperLimit = 20f;
    public float lowerLimit = -10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // LIMITE INFERIOR -> Animales no Alimentados
        if (transform.position.z < lowerLimit)
        {
            Destroy(gameObject);
        }
        // LIMITE SUPERIOR -> Bala Fallida
        if (transform.position.z > upperLimit)
        {
            Destroy(gameObject);
        }
    }
}
