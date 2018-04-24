using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectitle : MonoBehaviour {

	// Use this for initialization
	private static float _movSpeed = 15.0f;
	private static float _dmgAmount = 10.0f;
	public static float MoveSpeed {
		get{ 
			return _movSpeed;
		}
		set { 
			_movSpeed = value;
		}
	}

	public static float dmgAmount{
		get{ 
			return _dmgAmount;
		}
		set{ 
			_dmgAmount = value;
		}
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.Up * _movSpeed * Time.DeltaTime);
	}
	private void LateUpdate(){
	
		if (Transform.position.y >= 10.5f) {
			Destroy (gameObject);
		}
	} 
}
