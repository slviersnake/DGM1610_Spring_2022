using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class if_statments : MonoBehaviour
{ 
    public string ligtcolor;

    public float change;

    public string weather; 

    public bool isnight = ture; 

    public int money;
    
    // Start is called before the first frame update
    void Start()
    {
        money = 300;
        Debug.Log("Money in acount = $" + money);
  
    }

    // Update is called once per frame
    void Update()
    {
     if(lightcolor == "Red")
    {
      Debug.Log("The light is" + lightcolor + "STOP!!!");
    }
     else if(lightcolor == Yellow)
    {
       Debug.Log("The light is" + lightcolor + "Start to Stop of Clear the intersection!!!");
    }
     else if(lightcolor == "Green")
     {
       Debug.Log("The light is" + lightcolor + "Go!!!");
     }
      else
       {
          debug.Log("Wrong color try again");
       }
       if(weather == "Rain" || weather == "Snow")
       {
           debug.Log("The Weather is bad, you should waar a coat!");
       }
       else if(weather == "Sunny" || weather = "pratly Cloudy")
       {
           debug.Log("You do not need a coat");
       }
      if(isnight == ture)
      {
        print ("it is night"); 
      }
       else if(isnigt == false)
       {
        print ("It is day");
       }
       else if(change > 3.00f)
       {
        Debug.Log("you have made a pruchase!");
       }
       
        

        

       

    
         



