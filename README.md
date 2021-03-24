# UnityGetComponentTool


```cs

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
        UGUIAttribute.Init(this); // must be call
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

```

After 
 
![](https://i.imgur.com/FkPrsHH.png)
