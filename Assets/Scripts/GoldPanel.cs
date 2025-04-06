using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GoldPanel : MonoBehaviour
{
    public Image panelImage;
    public GameObject ActiveThings;
    public GameObject Mission;
    public GameObject You;
    private TMP_Text MissionT;
    private TMP_Text YouT;
    int a = 0;
    void Start()
    {
        MissionT = Mission.GetComponent<TextMeshProUGUI>(); ;
        YouT = You.GetComponent<TextMeshProUGUI>();
        Invoke("StartChangingAlpha", 3f);
        Invoke("Show", 6f);
    }

    void StartChangingAlpha()
    {
        StartCoroutine(ChangeAlphaOverTime());
    }

    IEnumerator ChangeAlphaOverTime()
    {
        while (panelImage.color.a < 1f) // Keep increasing until fully visible
        {
            Color color = panelImage.color;
            color.a = Mathf.Clamp01(color.a + 0.01f * Time.deltaTime * 60);
            panelImage.color = color;

            yield return null;
        }
    }
    void Show()
    {
        a = Random.Range(1, 11);
        if (a > 0 || a <= 7)
        {
            Save.Money += 20000;
            MissionT.text = "Gold has risen in price";
            YouT.text = "You received 20000 goblings back";
        }
        else if (a > 7)
        {
            MissionT.text = "Gold has fallen in price";
            YouT.text = "You received 0 goblings back";
        }
        ActiveThings.SetActive(true);
    }
}
