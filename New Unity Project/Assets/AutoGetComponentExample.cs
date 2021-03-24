using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class AutoGetComponentExample : MonoBehaviour
{

    [UGUI(typeof(Image))]
    public Image userImage;
    [UGUI(typeof(Image))]
    public Image levelMark;
    [UGUI(typeof(Text))]
    public Text userName;


    [UGUI(typeof(Image), "ChildTest/")]
    public Image _userIcon;

    private void Awake()
    {
        // 모노비헤비이어 넘겨주면 클래스에있는 Attribute를 읽어서 알아서 집어넣음
        // 이 원리를 응용해서 자기 프로젝트에 맞게 관리하면 될 것 같네요.
        UGUIAttribute.Init(this);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
