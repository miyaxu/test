using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private static Player _instance;
    public static Player Instance
    {
        get
        {
            return _instance;
        }
    }

    //Rigidbody2D playerRigid;

    private void Awake()
    {
        //playerRigid = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        //playerRigid.bodyType = RigidbodyType2D.Static;
    }

    private void Jump(RaycastHit2D hit)
    {
        //playerRigid.bodyType = RigidbodyType2D.Dynamic;
        //hit.collider.attachedRigidbody.AddForce(Vector2.up * 25, ForceMode2D.Impulse);
    }

    public void Hello()
    {
        Debug.Log("Player 123456789");
    }

    void OnGUI()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null)
            {
                Debug.Log(hit.collider.gameObject.name);
                //Jump(hit);
            }
        }
    }
}
