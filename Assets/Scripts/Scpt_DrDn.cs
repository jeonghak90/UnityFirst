using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scpt_DrDn : MonoBehaviour
{
    public Dropdown m_Drdn;

    public List<string> m_DropOptions = new List<string>();

    void Start ()
    {
        string m_OptionMenu;

        m_Drdn.ClearOptions();

        for (int i = 0; i < 20; i++)
        {
            m_OptionMenu = "Test " + i;
            m_DropOptions.Add(m_OptionMenu);          
        }
        m_Drdn.AddOptions(m_DropOptions);
    }
	
	
	void Update ()
    {
		
	}
}
