using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScrollView : MonoBehaviour
{
    ScrollRect scrollRect;
    // Start is called before the first frame update
    void Start()
    {
        scrollRect = GetComponent<ScrollRect>();//게임 오브젝트에 있는 ScrollRect가져옴
    }
    void SetContentSize()
    {
        float width = 200.0f;
        float height = 100.0f;

        scrollRect.content.sizeDelta = new Vector2(width, height);
    }
}
