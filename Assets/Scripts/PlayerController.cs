using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10f; //velocidad player
    private float xrange = 15f; // limite horizontal del player
    private float horizontalInput;

    public GameObject projectilePrefab;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento horizontal del player
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        PlayerInBounds(); // mantiene al player en pantalla

        //mecanica de disparo
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireProjectile();
        }

    }

    // funcion para hacer aparecer al proyectil.

    //funcion para tener al jugador dentro de los limites.
    private void PlayerInBounds()
    {
        Vector3 pos = transform.position;
        if (pos.x < -xrange)
        {
            transform.position = new Vector3(-xrange, pos.y, pos.z);
        }

        if (pos.x > xrange)
        {
            transform.position = new Vector3(xrange, pos.y, pos.z);
        }
    }
    private void FireProjectile()
    {
        Instantiate(projectilePrefab, transform.position, Quaternion.identity);
    }
}
