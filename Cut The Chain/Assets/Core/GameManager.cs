using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    [SerializeField] private Balls _balls;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null)
            {
                if (hit.collider.CompareTag("Center_1") || hit.collider.CompareTag("Center_2"))
                {
                    hit.collider.gameObject.SetActive(false);
                    _balls.hingeControl[hit.collider.tag].enabled = false;
                }
            }
            
        }
    }
}
