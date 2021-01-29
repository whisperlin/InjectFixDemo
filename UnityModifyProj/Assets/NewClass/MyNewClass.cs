using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[IFix.Interpret]
public class C1
{
    public string GetStr()
    {
        return "11111";
    }
}

[IFix.Interpret]
public class C2
{
    public string GetStr()
    {
        return "C2";
    }
}
[IFix.Interpret]
public class MyNewClass  
{

    public Text t;

    public int c;
    
    // Update is called once per frame
    public void Update()
    {
 
        if (null != t)
            t.text = c.ToString();
       
    }
}
