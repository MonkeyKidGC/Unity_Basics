using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public int health;
    private float speed;

    private GameObject Bob;

    public GameObject GetGameObject()
    {
        return Instantiate(Bob);;
    }

    public float GetSpeed()
    {
        return speed;
    }

    // Start is called before the first frame update
    void Start()
    {
        string hello = "hello";
        Debug.Log(hello);
    }

    // Update is called once per frame
    void Update()
    {
        string hello = "Mom";
        Debug.Log(hello);
    }
    
}
  