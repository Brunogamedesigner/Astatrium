using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorTrigger : MonoBehaviour {
    WaveGenerator generator;
    public float moviment;
    void Start()
    {
        generator = GetComponentInParent<WaveGenerator>();
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            GameObject g= generator.Generate(this.transform.position);
            transform.position += new Vector3(moviment, 0);
        }
    }
}
