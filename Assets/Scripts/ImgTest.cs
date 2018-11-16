using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImgTest : MonoBehaviour
{
    public Texture2D Icon;
    public Image Img_Test;
    

	void Start ()
    {
        create();

    }
	

	void Update ()
    {
		
	}

    void create()
    {
        Img_Test.sprite = Sprite.Create(Icon, new Rect(0, 410 + 20, 82, 82), new Vector2(0, 0));
    }
}
