using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TTDestroy : MonoBehaviour
{
    [SerializeField]
    private GameObject circle;

    void OnDestroyGameObject()
    {
        Debug.Log("Destroy Circle");
        Destroy(circle);
    }

    void OnDestroyDelay()
    {
        Debug.Log("Destroy Circle in 5 seconds");
        Destroy(circle, 5f);
    }

    void OnDestroyThisScript()
    {
        Debug.Log("Destroy This Script");
        Destroy(this);
    }

    void OnDestroySelf()
    {
        Debug.Log("Destroy This Game Object: " + gameObject.name);
        Destroy(gameObject, 1f);
    }
}