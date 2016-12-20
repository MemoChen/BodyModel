using UnityEngine;
using System.Collections;

public class CreateBody : MonoBehaviour
{

    private bool isRun = true;
    public GameObject[] bodyParent;
    void Start()
    {
        InitHead();
        InitNeck();
        for(int i=0;i<5;i++)
        {
            InitBody();
        }
      
    }
    private void InitHead()
    {
        GameObject cubeHead;
        for (int i = 0; i < 27; i++)
        {
            cubeHead = Instantiate(Resources.Load("Prefab/Head"), bodyParent[0].transform) as GameObject;
        }

        for (int j = 0; j < 27; j++)
        {
            if (j < 3)
            {
                GameObject[] temp = GameObject.FindGameObjectsWithTag("cube");
                temp[j].transform.position = new Vector3(j / 10f, 0, 0);
            }
            else if (j < 6)
            {
                GameObject[] temp = GameObject.FindGameObjectsWithTag("cube");
                temp[j].transform.position = new Vector3((j - 3f) / 10f, 0.1f, 0);
            }
            else if (j < 9)
            {
                GameObject[] temp = GameObject.FindGameObjectsWithTag("cube");
                temp[j].transform.position = new Vector3((j - 6f) / 10f, -0.1f, 0);
            }
            else if (j < 12)
            {
                GameObject[] temp = GameObject.FindGameObjectsWithTag("cube");
                temp[j].transform.position = new Vector3((j - 9f) / 10f, 0, 0.1f);
            }
            else if (j < 15)
            {
                GameObject[] temp = GameObject.FindGameObjectsWithTag("cube");
                temp[j].transform.position = new Vector3((j - 12f) / 10f, 0.1f, 0.1f);
            }
            else if (j < 18)
            {
                GameObject[] temp = GameObject.FindGameObjectsWithTag("cube");
                temp[j].transform.position = new Vector3((j - 15f) / 10f, -0.1f, 0.1f);

            }
            else if (j < 21)
            {
                GameObject[] temp = GameObject.FindGameObjectsWithTag("cube");
                temp[j].transform.position = new Vector3((j - 18f) / 10f, 0f, 0.2f);
            }
            else if (j < 24)
            {
                GameObject[] temp = GameObject.FindGameObjectsWithTag("cube");
                temp[j].transform.position = new Vector3((j - 21f) / 10f, 0.1f, 0.2f);
            }
            else if (j < 27)
            {
                GameObject[] temp = GameObject.FindGameObjectsWithTag("cube");
                temp[j].transform.position = new Vector3((j - 24f) / 10f, -0.1f, 0.2f);

            }
            //if (j == 26)
            //{
            //    isRun = false;
            //}
        }
    }

    private void InitNeck()
    {
        GameObject cubeNeck = Instantiate(Resources.Load("Prefab/Neck"), bodyParent[1].transform) as GameObject;
        cubeNeck.transform.position = new Vector3(0.1f, -0.225f, 0.1f);
    }

    private void InitBody()
    {
        GameObject cubeNeck;
        GameObject[] temp = null;
        for (int i = 0; i < 80; i++)
        {
            cubeNeck = Instantiate(Resources.Load("Prefab/Body"), bodyParent[2].transform) as GameObject;
            temp = GameObject.FindGameObjectsWithTag("body");
        }
        for (int j = 0; j < 80; j++)
        {
            if (j < 7)
            {
                //temp = GameObject.FindGameObjectsWithTag("body");
                temp[j].transform.position = new Vector3((j / 10f) - 0.2f, -0.325f, 0);
            }
            else if (j < 14)
            {
                //GameObject[] temp = GameObject.FindGameObjectsWithTag("body");
                temp[j].transform.position = new Vector3(((j - 7) / 10f) - 0.2f, -0.325f, 0.1f);
            }
            else if (j < 21)
            {
                //GameObject[] temp = GameObject.FindGameObjectsWithTag("body");
                temp[j].transform.position = new Vector3(((j - 14) / 10f) - 0.2f, -0.325f, 0.2f);
            }
        }
    }
    void Update()
    {
        //if (isRun)
        //{
        //    InitHead();
        //}
    }

}
