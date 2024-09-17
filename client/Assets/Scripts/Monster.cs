using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    private float   _speed;

    // Start is called before the first frame update
    void Start()
    {
        _speed=10f;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(new Vector3(-1*Time.deltaTime * _speed,0));  //이동
    }
}
