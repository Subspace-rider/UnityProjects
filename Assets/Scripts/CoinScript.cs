using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{ public Rigidbody2D RB;
	
    public float Speed = 1;
	
    public GameObject Player;
    
    
	
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { }

    //The player calls this function on the coin whenever they bump into it
    //You can change its contents if you want something different to happen on collection
    //For example, what if the coin teleported to a new location instead of being destroyed?
    public void GetBumped()
    {
        //This destroys the coin
        Destroy(gameObject);
    }
    void Update()
    { 	
	    Vector2 vel = new Vector2(0,0);
        
	    if (transform.position.x < Player.transform.position.x)
	    {
		    vel.x = -Speed;
	    }
	
	    if (transform.position.x > Player.transform.position.x)
	    {
		    vel.x = Speed;
	    }
		
	    if (transform.position.y < Player.transform.position.y)
	    {
		    vel.y = -Speed;
	    }

	    if (transform.position.y > Player.transform.position.y)
	    {
		    vel.y = Speed;
	    }
	    RB.linearVelocity = vel; 
    }
}
