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
        var        position = (!_last) ? parent.position : _last.position;
        GameObject ll       = Instantiate(platform[0], position, Quaternion.identity, parent);
        _last = ll.transform.GetChild(1);
    }
}
