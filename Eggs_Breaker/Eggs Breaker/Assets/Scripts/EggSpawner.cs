using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggSpawner : MonoBehaviour
{
    
    [SerializeField]
    public Egg EggPrefab;
    private int playWidth = 7;
    private float distanceBetweenEgg = 0.75f;

    private List<Egg> EggSpawned = new List<Egg>();
    private void Spawn()
    {
        for(int i = 0; i < 1; i++)
        {
            SpawnRowOfEggs();
        }
    }
    private void SpawnRowOfEggs()
    {

        foreach(var egg in EggSpawned)
        {
            if(egg != null && EggPrefab.InsideDontSpawn == false)
            {
                egg.transform.position += Vector3.down * distanceBetweenEgg;
            }
        }


        for(int i = 0; i < playWidth; i++)
        {
            if (UnityEngine.Random.Range(0, 100) <= 50)
            {
                var egg = Instantiate(EggPrefab, GetPosition(i), Quaternion.identity);

                EggSpawned.Add(egg);
            }
        }
    }

    private Vector3 GetPosition(int i)
    {
        Vector3 position = transform.position;
        position += Vector3.right * i * distanceBetweenEgg;
        return position;
    }


   // public float period = 5.0f;
     void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            SpawnRowOfEggs();
        }
        InvokeRepeating("SpawnRowOfEggs", 2.0f, 5.0f);
    }
    void Update()
    {
       // if (period > 5.0f && EggPrefab.InsideDontSpawn == false)
       // {
       //     Spawn();
       //     period = 0;
       // }
        //period += UnityEngine.Time.deltaTime;
    }

}
