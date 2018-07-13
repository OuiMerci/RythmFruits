using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

    private float _downLength = 0;
    private bool _isDown = false;

    // Blue -> Yellow -> Green -> Red
    [SerializeField] private float _blueLength;
    [SerializeField] private float _yellowLength;
    [SerializeField] private float _greenLength;
    [SerializeField] private float _redLength;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetMouseButtonDown(0))
        {
            OnClickDown();
        }

        else if (Input.GetMouseButtonUp(0))
        {
            OnClickUp();
        }

        if (_isDown)
            _downLength += Time.deltaTime;

    }

    private void OnClickDown()
    {
        _isDown = true;
    }

    private void OnClickUp()
    {
        Debug.Log("Mouse up, down time : " + _downLength);

        GetNote(_downLength);

        _downLength = 0;
        _isDown = false;
    }

    private void GetNote(float inputLength)
    {
        if (inputLength < _blueLength)
        {
            Debug.Log("Note -> Pink");
        }
        else if (inputLength < _yellowLength)
        {
            Debug.Log("Note -> Blue");
        }
        else if (inputLength < _greenLength)
        {
            Debug.Log("Note -> Yellow");
        }
        else if (inputLength < _redLength)
        {
            Debug.Log("Note -> Green");
        }
        else
        {
            Debug.Log("Note -> Red");
        }
    }
}
