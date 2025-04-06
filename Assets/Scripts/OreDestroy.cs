using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OreDestroy : MonoBehaviour
{
    public GameObject prt;
    public GameObject menu;
    private int stoneHp = 3;

    public bool invinsible;
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<OreDestroy>().invinsible == false)
        {
            Destroy(collision.gameObject);
        }
    }
    private void Start()
    {
        StartCoroutine(Bedrock());
    }
    IEnumerator Bedrock()
    {
        invinsible = false;
        yield return new WaitForSeconds(5);
        invinsible = true;
    }
    public void TakeDamage()
    {
        if(stoneHp > 1)
        {
            stoneHp--;
        }
        else
        {
            Destroy(gameObject);
            if(gameObject.name == "CoalOre(Clone)")
            {
                Save.Money += 10;
            }
            else if(gameObject.name == "IronOre(Clone)")
            {
                Save.Money += 100;
            }
            else if (gameObject.name == "GoldOre(Clone)")
            {
                Save.Money += 1000;
            }
            else if (gameObject.name == "RubyOre(Clone)")
            {
                Save.Money += 5000;
            }
            else if (gameObject.name == "EmeraldOre(Clone)")
            {
                Save.Money += 10000;
            }
            else if (gameObject.name == "DiamondOre(Clone)")
            {
                Save.Money += 50000;
            }
            else if (gameObject.name == "GlitchOre(Clone)")
            {
                Save.Money += 1000000;
            }

        }
        Instantiate(prt, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), Quaternion.Euler(-90, 0, 0));
    }
}
