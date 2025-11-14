using TMPro;
using UnityEngine;

public class settext : MonoBehaviour
{
    public TMP_Text textUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetText(string text)
    {
        textUI.text = text;
    }
}
