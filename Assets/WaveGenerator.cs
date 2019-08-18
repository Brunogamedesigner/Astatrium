using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveGenerator : MonoBehaviour {
    public GameObject[] pool;
    //public List<GameObject> generatedObjects;
    public Transform pivot;
    public Transform begin;
    public Transform end;
    
    public GameObject Generate(Vector3 position)
    {
        int selection = Random.Range(0, pool.Length);
        GameObject g = Instantiate(pool[selection]);
        g.transform.position = position;
        return g;
    }
  
}
