using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRay : MonoBehaviour
{
    RaycastHit hit;
    public GameObject map;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 3f))
            {
                if(!map.activeSelf)
                {
                    if (hit.collider.TryGetComponent<OreDestroy>(out OreDestroy oreDestroy))
                    {
                        oreDestroy.TakeDamage();
                    }
                    else if (hit.collider.TryGetComponent<OpenInvestments>(out OpenInvestments openInvestments))
                    {
                        openInvestments.OpenInv();
                    }
                    else if (hit.collider.TryGetComponent<OpenLoans>(out OpenLoans openLoans))
                    {
                        openLoans.OpenLo();
                    }
                    else if(hit.collider.name == "GoldenGlass")
                    {
                        if (Save.Money >= 1000000)
                        {
                            Save.Money -= 1000000;
                            SceneManager.LoadScene("Victory");
                        }
                    }
                }
            }
        }
    }
}
