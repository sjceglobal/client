using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private float         _speed;

    public enum playerState{
		run = 0,
		attack1
	}
    public Animator _anim;

    // Start is called before the first frame update
    void Start()
    {
        _speed = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        //float x = this.transform.localPosition.x + (Time.deltaTime * _speed);
		//this.transform.localPosition = new Vector3(x, 22);
        this.transform.Translate(new Vector3(Time.deltaTime *_speed,0));  
		// if(_speed == 0f)
		// 	_anim.SetInteger ("playerState",(int)playerState.attack1);	
    }

    void OnTriggerEnter(Collider other){
        Debug.Log(other.transform);
        //Debug.Log(other == "monster");
		if (other.transform.tag == "enemy") {
			Debug.Log("====Character Trigger start====");
			_speed = 0f;
			//_anim.SetInteger ("playerState",(int)playerState.attack1);
            _anim.Play("attack");
		}
	}
}
