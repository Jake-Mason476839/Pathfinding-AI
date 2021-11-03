using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public enum OccilationFuntion { Sine, Cosine }

    public void Start ()
    {
        StartCoroutine (Oscillate (OccilationFuntion.Sine, 2f));
    }
 
    private IEnumerator Oscillate (OccilationFuntion method, float scalar)
    {
        while (true)
        {
            if (method == OccilationFuntion.Sine)
            {
                transform.position = new Vector3 (0, 0, Mathf.Sin (Time.time) * scalar);
            }
            else if (method == OccilationFuntion.Cosine)
            {
                transform.position = new Vector3(0, 0, Mathf.Cos(Time.time) * scalar);
            }
            yield return new WaitForEndOfFrame ();
        }
    }
}
