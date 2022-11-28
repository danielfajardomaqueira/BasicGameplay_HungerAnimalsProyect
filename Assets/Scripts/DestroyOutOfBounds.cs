using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    private float upperLimit = 30f;
    private float lowerLimit = -10f;

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

            //mecanica game over
            Debug.Log("GAME OVER");
            
            Time.timeScale = 0;
        }
        // LIMITE SUPERIOR -> Bala Fallida
        if (transform.position.z > upperLimit)
        {
            Destroy(gameObject);
        }
    }
}
