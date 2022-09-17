using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float dogSpawnInterval = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // if (dogSpawnInterval == 0)
            // {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                dogSpawnInterval = 2.0f;
            // }
        }
        // if (dogSpawnInterval != 0)
        // {
        //     dogSpawnInterval -= Time.deltaTime;
        // }
    }
}
