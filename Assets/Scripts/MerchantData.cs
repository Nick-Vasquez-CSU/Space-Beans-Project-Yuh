using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MerchantData : MonoBehaviour
{

	public Text BeansText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

	public void SubtractBeansPistol()
	{
		if (GlobalData.Instance.Beans <= 0)
		{

		}
		else
			GlobalData.Instance.Beans -= 5;
	}
	public void SubtractBeansMachine()
	{
		if (GlobalData.Instance.Beans <= 0)
		{

		}
		else
		{
			GlobalData.Instance.Beans -= 50;
			GlobalData.Instance.Mammo += 30;
		}
	}
	public void SubtractBeansSniper()
	{
		if (GlobalData.Instance.Beans <= 0)
		{

		}
		else
		{
			GlobalData.Instance.Beans -= 20;
			GlobalData.Instance.Snammo += 10;
		}
	}
	public void SubtractBeansShotgun()
	{
		if (GlobalData.Instance.Beans <= 0)
		{

		}
		else
		{
			GlobalData.Instance.Beans -= 15;
			GlobalData.Instance.Sammo += 8;
		}
	}
	// Update is called once per frame
	void Update()
    {
		BeansText.text = "Beans: " + GlobalData.Instance.Beans.ToString();
	}
}
