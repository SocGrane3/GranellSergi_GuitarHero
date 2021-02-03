using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class colision : MonoBehaviour
{
    public KeyCode code;
    public gameManager manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //he intentat que detecti al baixa a tecle pero o es masa precis o no funciona
        if (collision.gameObject.CompareTag("nota") && Input.GetKey(code))
        {
            Debug.Log("Le diste");
            Destroy(collision.gameObject);
            manager.score += 1;
        }
    }
}
