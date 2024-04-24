using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Panel : MonoBehaviour
{
    [SerializeField] bool ReopenInitiation = true;
    //[SerializeField] List<UI_Button> panelButtons = new List<UI_Button>();
    [Space(10f)]
    [SerializeField] bool UseScrollbar = false;
    [SerializeField] RectTransform scrollview;
    [SerializeField] RectTransform scrollcontent;
    [SerializeField] Scrollbar scrollbar;
    //UI_Button target = null;
    int lastindex = 0;

    /*
    private void OnEnable()
    {
        initButtons();
    }
    private void OnDisable()
    {
        CheckLastIndex();
    }
    private void Update()
    {
        ScrollCheck();
    }
    
    void initButtons()
    {
        if (panelButtons.Count == 0) return;
        for (int i = 0; i < panelButtons.Count; i++)
        {
            panelButtons[i].ButtonActive(false);
        }
        if (!ReopenInitiation)
        {
            panelButtons[lastindex].ButtonActive(true);
        }
        else
        {
            panelButtons[0].ButtonActive(true);
        }
    }
    
    void CheckLastIndex()
    {
        for (int i = 0; i < panelButtons.Count; i++)
        {
            if (panelButtons[i].Activing)
            {
                lastindex = i;
                break;
            }
        }
    }
    void ScrollCheck()
    {
        if (!UseScrollbar) return;

        if (UI_Button.ActiveButton.gameObject.name == "BackButton")
        {
            scrollbar.value = Mathf.Lerp(scrollbar.value, 0f, 5f * Time.unscaledDeltaTime);
            return;
        }
        if (UI_Button.ActiveButton.transform.parent == scrollcontent.transform)
        {
            target = UI_Button.ActiveButton;
        }

        float maxgap = scrollcontent.rect.height - scrollview.rect.height;
        float result = target.GetComponent<RectTransform>().anchoredPosition.y;
        result *= 1.3f;
        result += maxgap;
        result *= 0.5f;
        result /= maxgap;
        if (result > 1f) result = 1f;
        else if (result < 0f) result = 0f;
        //Debug.Log(result);

        scrollbar.value = Mathf.Lerp(scrollbar.value, result, 5f * Time.unscaledDeltaTime);
    }

    public void UpdateButtonValues()
    {
        for (int i = 0; i < panelButtons.Count; i++)
        {
            panelButtons[i].UpdateValue();
        }
    }
    */
}