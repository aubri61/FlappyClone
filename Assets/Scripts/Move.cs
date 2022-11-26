using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    [SerializeField]
    float speed = 2f;

 
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * speed; //(-1, 0, 0)
    }
}
