using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{
    public GameObject Vortex_Left;
    public GameObject Vortex_Right;
    public GameObject Vortex_Up;
    public GameObject[] Obj;

    public GameObject Center;

    public Slider slider;

    public int BossLife = 5;

    public bool BossIsAlive = true;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UnShow();
        StartCoroutine(MyCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = BossLife;
    }

    public void UnShow()
    {
        Vortex_Left.SetActive(false);
        Vortex_Right.SetActive(false);
        Vortex_Up.SetActive(false);
    }

    public void VortexLeft()
    {
        UnShow();
        Vortex_Left.SetActive(true);
    }

    public void VortexRight()
    {
        UnShow();
        Vortex_Right.SetActive(true);
    }

    public void VortexUp()
    {
        UnShow();
        Vortex_Up.SetActive(true);
        StartCoroutine(BossDrop());
    }

    public void BossDamage()
    {
        BossLife -= 1;
    }

    public IEnumerator BossDrop() 
    {
        yield return new WaitForSeconds(2);
        Instantiate(Obj[0], Center.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(2);
        Instantiate(Obj[1], Center.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(2);
        Instantiate(Obj[2], Center.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(2);
        Instantiate(Obj[3], Center.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(2);
        Instantiate(Obj[4], Center.transform.position, Quaternion.identity);
    }

    public IEnumerator MyCoroutine() 
    {
        VortexLeft();
        yield return new WaitForSeconds(5);
        VortexUp();
        yield return new WaitForSeconds(10);
        VortexRight();
        yield return new WaitForSeconds(5);
        VortexUp();
        yield return new WaitForSeconds(10);
        StartCoroutine(MyCoroutine());
    }
}
