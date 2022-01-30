using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vribles : MonoBehaviour
{
    // Global Vribles
    public int money; //whole number value 2,14,57, -92, -101
   
    public float change = 1.75f; // Floting point number or decimal 3.15

    public bool isnight = true; //Boolens are true or false

    string loginame = "Bob2345";//string are alpha numeric

    public int tempt = 5; // mesure dreggre of celsius 




    // Start is called before the first frame update
    void Start()
    {
        money = 300;
        Debug.Log("Money in acount = $" + money);

     
        
    }

    // Update is called once per frame
    void Update()
    {
        if(loginame == "Bob2345")
        {
            print("you have logged in!");
        }
        else
        {
            Debug.Log("invalid Login Name!");
            }
            
                 if(isnight == true)
                {
                    print ("It is Night!");
                }
                else if(isnight == false)
                {
                    print("It is Day time");
                }
                else if(change > 3.00f)
                {
                    Debug.Log("you have made a pruchase!");
                }
                
                {
                  
                }
                 
                {

                }
    

                

            }
       




    }
        




