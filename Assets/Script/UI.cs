using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    static bool escAble = true;
    public static bool EscAle { get { return escAble;  } set { escAble = value; } }

    public void SetEscAble(bool b)
    {
        EscAle = b;
    }

    static Stack<UI_Panel> PanelStack = new Stack<UI_Panel>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
