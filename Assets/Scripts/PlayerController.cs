using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float xrange = 15f;
    private float horizontalInput;

    public GameObject projectilePrefab;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        PlayerInBounds();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireProjectile();
        }

    }

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
