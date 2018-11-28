using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class ButtonControl : MonoBehaviour {

    public PlayerControl pc;
    public GameObject playerBall;
    bool UpButtonPressed = false;
    bool DownButtonPressed = false;
    bool LeftButtonPressed = false;
    bool RightButtonPressed = false;
    private void Update()
    {
        if (UpButtonPressed == true)
        {
            pc.rb.velocity = new Vector2(0f, pc.speed);
        }
        if (DownButtonPressed == true)
        {
            pc.rb.velocity = new Vector2(0f, -pc.speed);
        }
        if (LeftButtonPressed == true)
        {
            pc.rb.velocity = new Vector2(pc.speed, 0f);
        }
        if (RightButtonPressed == true)
        {
            pc.rb.velocity = new Vector2(-pc.speed, 0f);
        }
    }
 
    public void UpSpeedDown()
    {
        UpButtonPressed = true;
    }
    public void UpSpeedUp()
    {
        UpButtonPressed = false;
    }

    public void DownSpeedDown()
    {
        DownButtonPressed = true;
    }
    public void DownSpeedUp()
    {
        DownButtonPressed = false;
    }

    public void RightSpeedDown()
    {
        RightButtonPressed = true;       
    }
    public void RightSpeedUp()
    {
        RightButtonPressed = false;
    }

    public void LeftSpeedDown()
    {
        LeftButtonPressed = true;
    }
    public void LeftSpeedUp()
    {
        LeftButtonPressed = false;
    }

}
