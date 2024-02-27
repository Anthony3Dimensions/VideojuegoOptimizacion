using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
   public GameObject enemyPrefab; // Prefab del enemigo a instanciar
    public float spawnInterval = 2f; // Intervalo de tiempo entre generaciones
    public Transform[] spawnPoints; // Puntos de generación de enemigos

    void Start()
    {
        // Comenzar la generación de enemigos en intervalos regulares
        InvokeRepeating("SpawnEnemy", 0f, spawnInterval);
    }

    void SpawnEnemy()
    {
        // Seleccionar un punto de generación aleatorio
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[spawnPointIndex];

        // Instanciar un enemigo en el punto de generación seleccionado
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
