using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour {

    public GameObject[] _Obj;

	// Use this for initialization
	void Start () {
		for(int i = 0; i < _Obj.Length; i++)
        {
            _Obj[i].SetActive(false);
        }
	}
	
	public void AppearedObject(int inx)
    {
       
        for (int i = 0; i < _Obj.Length; i++)
        {
            if (i == inx)
            {
                _Obj[i].SetActive(true);
            }
            else
            {
                _Obj[i].SetActive(false);
            }
        }
    }
}
