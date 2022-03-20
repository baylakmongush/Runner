using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldBuilder : MonoBehaviour
{
    public  GameObject[] platform;
    public  Transform    parent;
    private Transform    _last = null;
    
    private void Start()
    {
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            var position = (!_last) ? parent.position : _last.position;
            GameObject ll = Instantiate(platform[0], position, Quaternion.identity, parent);
            Debug.Log(ll.transform.GetChild(1).position);
            _last = ll.transform.GetChild(1);
        }
    }
}
