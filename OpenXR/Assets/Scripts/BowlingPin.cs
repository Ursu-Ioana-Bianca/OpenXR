using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingPin : MonoBehaviour
{
    public GameObject Cylinder;
    [SerializeField]
    int points=10;  //se seteaza cate puncte valoreaza fiecare popica
    int ok=1;
    static int suma=0;
   
    // Start is called before the first frame update
    void Start()
    { 

    }

    // Update is called once per frame
    void Update()
    {

         ChangePosition();
      
    }
    
 void ChangePosition()
    {

        if (Cylinder.transform.rotation.eulerAngles.z>=10 && Cylinder.transform.rotation.eulerAngles.z<=350)  // daca la rotatie unghiul lui z este este mai mare de 10 grade si mai mic de 350 grade inseamna ca popica s-a inclinat si va cadea, deci se v-a colora 
    {
        // daca popica s-a inclinat cel putin 10 grade atunci o coloram
        if(ok==1){
             var cubeColor = Cylinder.GetComponent<Renderer>();
                 cubeColor.material.SetColor("_Color", Color.red);
                 ok=0;
                 Debug.Log(Cylinder+"colored"); //ce popica a ost doborata
                 suma+=points;  // cate puncte sa se adune pentru fiecare popica doborata
                 Debug.Log(suma+" points");

                              
        }

    }   
    }

}
