using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FlashLight : MonoBehaviour
{
    public GameObject myMap;
    public GameObject antiMap;
    public GameObject Inv;
    public GameObject Loans;
    private TMP_Text MText;
    
    void Start()
    {
        MText = GameObject.Find("MoneyText").GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if(myMap.activeSelf)
            {
                myMap.SetActive(false);
            }
            else
            {
                myMap.SetActive(true);
            }
        }



        if (Input.GetKeyDown(KeyCode.E))
        {
            Inv.SetActive(false);
            Loans.SetActive(false);
        }



        if (myMap.activeSelf)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            antiMap.SetActive(false);
            Inv.SetActive(false);
            Loans.SetActive(false);
        }
        else if (Inv.activeSelf || Loans.activeSelf)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            antiMap.SetActive(false);
        }
        else if (!myMap.activeSelf && !Inv.activeSelf && !Loans.activeSelf)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            antiMap.SetActive(true);
        }
        


        MText.text = Save.Money.ToString();
    }
}
