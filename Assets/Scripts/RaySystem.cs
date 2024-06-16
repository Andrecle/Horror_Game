using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaySystem : MonoBehaviour
{
    public Transform raypoint;
    public float usingdistantion = 1.75f;
    RaycastHit hit;

    public Text info;

    void LateUpdate()
    {
        if (Physics.Raycast(raypoint.position, raypoint.forward, out hit, usingdistantion))
        {
            if (hit.collider.tag == "Untagged")
            {
                info.text = null;
            }

            if (hit.collider.tag == "Door")
            {
                info.text = "ЛКМ чтобы открыть или закрыть дверь";

                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                	Door door = hit.collider.GetComponent<Door>();
                	door.Using();
                }
            }
            if (hit.collider.tag == "lighter")
            {
                info.text = "Зажигалка";

            }
        }
        else
        {
            info.text = null;
        }
    }

}
