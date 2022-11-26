using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MakePipe : MonoBehaviour
{

    [SerializeField]
    GameObject pipe;


    float timer = 0;


    [SerializeField]
    float timeDiff = 2.5f;

    void Start()
    {
        pipe = Resources.Load<GameObject>("Prefabs/pipe");
    }


    void Update()
    {
        timer += Time.deltaTime;

        if (timer > timeDiff)
        {

            if (pipe != null)
            {

                GameObject newPipe = Instantiate(pipe);
                newPipe.transform.position = new Vector3(3, Random.Range(-2.6f, 6f), 0);


                timer = 0;
                Destroy(newPipe, 10.0f);
            }
        }


    }
}
