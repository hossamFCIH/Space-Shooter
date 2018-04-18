using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float movesSpeed = 15.0f;
    private Transform _myTransform;
	// Use this for initialization
	void Start () {
        _myTransform = gameObject.transform;
	}

    // Update is called once per frame
    void Update() {
        //move right
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            _myTransform.Translate(Vector3.right * movesSpeed * Time.deltaTime, Space.World);
            //_myTransform.localEulerAngles = new Vector3(0, -45, 90);
        }
        //move left
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            _myTransform.Translate(Vector3.left * movesSpeed * Time.deltaTime, Space.World);
           // _myTransform.localEulerAngles = new Vector3(0, 45, 90);
        }
        /*else
        {
            _myTransform.localEulerAngles = new Vector3(0, 0, 90);
        }*/
        //move up       
        if (Input.GetAxisRaw("Vertical") > 0 && _myTransform.position.y <= 2)
        {
            _myTransform.Translate(Vector3.up * movesSpeed * Time.deltaTime, Space.World);


        }
        //move down
        else if (Input.GetAxisRaw("Vertical") < 0  && _myTransform.position.y >= -14)
        {
            _myTransform.Translate(Vector3.down * movesSpeed * Time.deltaTime, Space.World);

        }
    }
    
        void LateUpdate ()
        {
            if(_myTransform.position.x >= 10)
            {
                _myTransform.position = new Vector3(-10, _myTransform.position.y, 7);
            }
            else
            if (_myTransform.position.x <= -10)
            {
                _myTransform.position = new Vector3(10, _myTransform.position.y, 7);
            }

          
    }

}
