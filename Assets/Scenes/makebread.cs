using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class makebread : MonoBehaviour
{
    public Image bread;
    float makebread_time = 6.0f;
    float bake_time = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        bread.fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (bake_time <= makebread_time)
        {
            bake_break();
        }
    }

    void bake_break()
    {
        bake_time += Time.deltaTime;
        bread.fillAmount = bake_time / makebread_time;
    }

}
