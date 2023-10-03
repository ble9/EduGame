using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QAdestroy : MonoBehaviour
{
    public GameObject prefab;
    private void OnMouseDown(){
        Instantiate(prefab,transform.position, transform.rotation);
        Destroy(gameObject);
    }
}