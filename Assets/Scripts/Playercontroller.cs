using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playercontroller : MonoBehaviour {

    public float speed;
    public Text countText;
    public Text winText;

    private Rigidbody rb;
    private int count;
    

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";

	}

	void FixedUpdate()
	{
		float movehorizontal = Input.GetAxis("Horizontal");
		float movevertical = Input.GetAxis("Vertical");
		//float moveup = input.getaxis(" ")
	    

	    Vector3 movement = new Vector3(movehorizontal, 0.0f, movevertical);

		rb.AddForce(movement*speed);
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pickup"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }

    }

    void SetCountText ()
    {
        countText.text = "count:" + count.ToString();
        if (count >= 12)
        {
            winText.text = "Next level Soon :P";

        }
    }
    

}
