using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdditionScript : MonoBehaviour
{
	
	public InputField num1;
	public InputField num2;
	public Text output;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void Add()
	{
		var num1a = int.Parse(num1.text);
		var num2a = int.Parse(num2.text);
		var num3 = num1a+num2a;
		Debug.Log(num3);
		output.text = num3.ToString();
	}
	
	public void ClearAll()
	{
		num1.text = "";
		num2.text = "";
		output.text = "0";
	}

}
