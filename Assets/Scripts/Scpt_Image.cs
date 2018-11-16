using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scpt_Image : MonoBehaviour
{
    public List<Texture2D> m_Icon = new List<Texture2D>();

    public Image Img_Test;

    int m_nCount = 0;           //  이미지 내 아이콘 순서(번호) 카운트
    int m_SkillTabCount = 0;    //  이미지(텍스쳐) 리스트 교환 카운트

    bool m_bCheck;

    void Start()
    {
    }

    void Update()
    {
        key();
        if (m_bCheck)
            render();
    }

    void render()
    {
        int x = 0;
        int y = 410 + 20;

        if (m_nCount > 5)
        {
            x -= 6;
            y -= 82;
        }

        Img_Test.sprite = Sprite.Create(m_Icon[m_SkillTabCount], new Rect((x + m_nCount) * 82, y, 82, 82), new Vector2(0, 0));
        m_bCheck = false;
        //Debug.Log("그린다ㅏㅏㅏ");
    }

    void key()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            m_SkillTabCount = (m_SkillTabCount > 0) ? 0 : 1;
            Debug.Log("슬롯교환");
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            m_SkillTabCount = 0;
            Debug.Log("1번슬롯");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            m_SkillTabCount = 1;
            Debug.Log("2번슬롯");
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            m_nCount = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            m_nCount = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            m_nCount = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            m_nCount = 3;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            m_nCount = 4;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            m_nCount = 5;
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            m_nCount = 6;
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            m_nCount = 7;
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            m_nCount = 8;
        }
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            m_nCount = 9;
        }
        if (Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            m_nCount++;
        }
        if (Input.anyKeyDown)
        {
            m_bCheck = true;
        }
    }

}
