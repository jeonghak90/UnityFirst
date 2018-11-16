using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scpt_InF : MonoBehaviour
{
    public InputField m_IF;

	void Start ()
    {
        //m_IF.text
	}
	
	void Update ()
    {
        Test();

    }

    void Test()
    {
        if (m_IF.text == "2")
        {
            Debug.Log("정답");
            m_IF.text = "";
        }

    }
    
}
