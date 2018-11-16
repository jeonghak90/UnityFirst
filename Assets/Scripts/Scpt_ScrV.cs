using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scpt_ScrV : MonoBehaviour
{
    public ScrollRect m_ScrollRect;
    public RectTransform m_Content;
   
    

    Texture2D m_Icon;
    Image m_Image;
    Text m_Name;
    Text m_Dec;
    RectTransform m_Prefab;
    void Start ()
    {
        m_Icon = Resources.Load(".UI.Game.Effect.Combo.Combo0") as Texture2D;
        m_Image.sprite = Sprite.Create(m_Icon, new Rect(0, 0, 75, 85), new Vector2(0, 0));

        m_Name.text = "아이템이름";
        m_Dec.text = "아이템설명";
        m_Prefab = Resources.Load(".Prefab.ScrollMenu") as RectTransform;

    }

	void Update ()
    {
		
	}
}
