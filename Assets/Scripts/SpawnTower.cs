using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class SpawnTower : MonoBehaviour
{
    public GameObject towerPrefab1;
    public GameObject towerPrefab2;

    private Camera cam = null;

    protected float Timer;

    public int DelayAmount = 1; // Second count

    private void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;

        if (Timer >= DelayAmount)
        {
            Timer = 0f;
            GameControl.currency = GameControl.currency + 1;
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (GameControl.currency >= 5)
            {
                Ray ray = cam.ScreenPointToRay(Mouse.current.position.ReadValue());
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    Instantiate(towerPrefab1, new Vector3(hit.point.x, hit.point.y, hit.point.z), Quaternion.identity);
                    GameControl.currency -= 5;
                }
            }
        }   
        
        if (Input.GetMouseButtonDown(1))
        {
            if (GameControl.currency >= 20)
            {
                Ray ray = cam.ScreenPointToRay(Mouse.current.position.ReadValue());
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    Instantiate(towerPrefab2, new Vector3(hit.point.x, hit.point.y, hit.point.z), Quaternion.identity);
                    GameControl.currency -= 20;
                }
            }
        }

        
    }
}
