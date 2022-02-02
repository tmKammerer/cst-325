using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform[] spawnTransforms;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Transform randoTrasform = spawnTransforms[Random.Range(0, spawnTransforms.Length)];
            GameObject instance = Instantiate(ballPrefab);
            //instance.GetComponent<Transform>().position = randoTrasform.position;
            instance.transform.position = randoTrasform.position;

        }
    }
}
