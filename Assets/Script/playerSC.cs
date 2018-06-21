using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSC : MonoBehaviour {
	public float _speed;
	public bool _move = false;
	public GameObject _point;
	private Vector3 _target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			_target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			_target.z = transform.position.z;
			if (_move == false)
				_move = true;
			Instantiate (_point, _target, Quaternion.identity);
		}
		if (_move == true) {
			transform.position = Vector3.MoveTowards (transform.position,_target, _speed * Time.deltaTime);
		}
	}
}
