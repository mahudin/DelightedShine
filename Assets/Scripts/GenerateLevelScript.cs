using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevelScript : MonoBehaviour
{
    public GameObject passage;
    public GameObject corridor;
    public GameObject end_corridor;
    public GameObject wall_corridor;
    public GameObject show_pager;

    void Start()
    {
        for (int i = 1; i < 12; i++)
        {
            for (int j = -6; j < 6; j++)
            {
                GameObject go = Instantiate(passage);
                go.transform.position = new Vector3(passage.transform.position.x + (6.0f * i), 0, passage.transform.position.z + (6.0f * j));

                GameObject go2 = Instantiate(corridor);
                go2.transform.position = new Vector3(corridor.transform.position.x + (6.0f * i), 0, passage.transform.position.z + (6.0f * j));

            }
        }
        for (int i = 0; i <= 11; i++)
        {
            for (int j = -5; j < 6; j++)
            {
                GameObject go = Instantiate(passage);
                go.transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
                go.transform.position = new Vector3(passage.transform.position.x + (6.0f * i) + 2.8f, 0, passage.transform.position.z + (6.0f * j) + 2.8f);
                if (i > 0)
                {
                    GameObject go2 = Instantiate(corridor);
                    go2.transform.position = new Vector3(corridor.transform.position.x + (6.0f * i) - 6.0f, 0, passage.transform.position.z + (6.0f * j));
                }
            }
        }
        for (int j = -6; j < 6; j++)
        {
            GameObject go = Instantiate(passage);
            go.transform.position = new Vector3(passage.transform.position.x, 0, passage.transform.position.z + (6.0f * j));
        }
        for (int j = -6; j < 6; j++)
        {
            GameObject go2 = Instantiate(end_corridor);
            go2.transform.position = new Vector3(corridor.transform.position.x - 6.0f, 0, passage.transform.position.z + (6.0f * j));
        }
        for (int i = 0; i <= 11; i++)
        {
            GameObject go3 = Instantiate(end_corridor);
            go3.transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
            go3.transform.position = new Vector3(corridor.transform.position.x + (6.0f * i) -1.0f , 0, passage.transform.position.z + 35.0f);
        }
        for (int i = 0; i <= 11; i++)
        {
            GameObject go4 = Instantiate(wall_corridor);
            go4.transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
            go4.transform.position = new Vector3(corridor.transform.position.x + (6.0f * i) - 1.0f, 0, passage.transform.position.z - 30.0f);
        }
        for (int i = -6; i <= 6; i++)
        {
            GameObject go4 = Instantiate(wall_corridor);
            go4.transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);
            go4.transform.position = new Vector3(corridor.transform.position.x + 65.0f , 0, passage.transform.position.z + (6.0f * i));
        }
        for (int k = 0; k <= 6; k++)
        {
            GameObject go5 = Instantiate(show_pager);
            go5.transform.position = new Vector3(Random.Range(0.0f,10.0f), 0, Random.Range(0.0f, 10.0f));
        }
    }

  
    void Update()
    {
        
    }
}
