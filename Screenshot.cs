using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Screenshot : MonoBehaviour
{
    [SerializeField] GameObject blink;

    public void TakeAShot()
    {
        StartCoroutine("CaptureIt");
    }

    IEnumerator CaptureIt()
    {
        string timeStamp = System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
        string fileName = "Screenshot" + timeStamp + ".png";
        string pathToSave = fileName;
        GameObject.Find("GameCanvas").GetComponent<Canvas>().enabled = false;
        yield return new WaitForEndOfFrame();
        ScreenCapture.CaptureScreenshot(pathToSave);
        yield return new WaitForEndOfFrame();
        GameObject.Find("GameCanvas").GetComponent<Canvas>().enabled = true;
        Instantiate(blink, new Vector2(0f, 0f), Quaternion.identity, transform.parent);
    }
}
