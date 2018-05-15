using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SanityUI : MonoBehaviour
{
    Image m_Image;

    public Sprite One_Sanity;
    public Sprite Two_Sanity;
    public Sprite Three_Sanity;
    public Sprite Four_Sanity;
    public Sprite Five_Sanity;

    // Use this for initialization
	void Start ()
    {
        m_Image = GetComponent <Image> ();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            m_Image.sprite = One_Sanity;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            m_Image.sprite = Two_Sanity;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            m_Image.sprite = Three_Sanity;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            m_Image.sprite = Four_Sanity;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            m_Image.sprite = Five_Sanity;
        }
    }
}
