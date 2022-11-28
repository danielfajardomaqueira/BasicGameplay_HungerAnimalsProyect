using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs; // Array de animales
   
    private int animalIndex; // Indice array de animales

    private float spawnRangeX = 14f;
    private float spawnPosZ = 15f;

    private float StartDelay = 1.5f;
    private float spawnInternal = 2f;

    private void Start()
    {
        //Llama periodicamente a la funcion SpawnRandomAnimal
        InvokeRepeating("SpawnRandomAnimal", StartDelay, spawnInternal);
    }

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        
        
    }

    //Funcion hace aparecer un animal aleatorio en una posicion aleatoria
    private void SpawnRandomAnimal()
    {
        
        animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex],
            RandomSpawnPos(),
            animalPrefabs[animalIndex].transform.rotation);
    }

    //funcion que genera vector aleatorio
    private Vector3 RandomSpawnPos()
    {
        float randomX = Random.Range(-spawnRangeX, spawnRangeX); // Generamos numero aleatorio para la coordenada X
        return new Vector3(randomX, 0, spawnPosZ);
    }
}
