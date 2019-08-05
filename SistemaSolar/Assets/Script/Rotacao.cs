using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacao : MonoBehaviour
{

    [Range(0,80)]
    [SerializeField] private float velocidade;
  
    void Update()
    {
        transform.Rotate(Vector3.up * velocidade * Time.deltaTime);
    }
}
