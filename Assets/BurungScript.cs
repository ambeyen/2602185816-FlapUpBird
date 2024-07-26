using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class BurungScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float KekuatanTerbang;
    public LogicScript logic;
    public bool BurungHidup = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) == true && BurungHidup == true)
        {
            myRigidbody.velocity = Vector2.up * KekuatanTerbang;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        BurungHidup = false;
    }
}
