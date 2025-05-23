using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public float spawnDelay = 0.3f;
    public Transform[] spawnPoints;

    float nextTimeToSpawn = 0f; 
    GameObject newCar;

    int Max_Cars_Count = 100;
    List<Transform> cars = new List<Transform>();


    void Update()
    {
        if (nextTimeToSpawn <= Time.time)
        {
            SpawnCar();
            ControlCarsCount();

            nextTimeToSpawn = Time.time + spawnDelay;
        }
    }

    void SpawnCar()
    {
        int randomIndex = Random.Range(0, 4);
        Transform spawnPoint = spawnPoints[randomIndex];

        newCar = Instantiate(Resources.Load<GameObject>("Car"), spawnPoint.position, spawnPoint.rotation);
        cars.Add(newCar.transform);
    }

    public void ControlCarsCount()
    {
        if (cars.Count >= Max_Cars_Count)
        {
            Destroy(cars[0].gameObject);
            cars.RemoveAt(0);
        }
    }
}
