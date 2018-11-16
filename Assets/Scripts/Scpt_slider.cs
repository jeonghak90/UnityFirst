using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scpt_slider : MonoBehaviour
{
    public Slider m_Slider;

    float m_fstart = 0f;
    float m_fend = 0.5f;


    void Start ()
    {
        m_Slider.value = 1f;
	}
	
	void Update ()
    {
        if (m_fstart + m_fend < Time.time)
        {
            m_Slider.value -= 0.1f;
            m_fstart = Time.time; //현재시간
            //Debug.Log("딜레이 경과");
        }
    }
}
