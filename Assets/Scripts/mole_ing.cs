using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MoleState
{
    None,Open,Idle,Close,Catch
}
/*
 None: 구멍
 Open: 반만나옴
 Idle: 다나옴
 Close: 반만나옴
 Cathch: 우는 친구
 */

public class mole_ing : MonoBehaviour
{
    public IEnumerator Wait()
    {
        MS = MoleState.None;
        Ani_count = 0;

        float wait_Time = Random.Range(1.0f, 7.0f);
        yield return new WaitForSeconds(wait_Time);

        Open_On();
    }

    public mole_game MG;
    public MoleState MS;

    public bool GoodMole = true;

    //착한 두더지
    public Texture None_Image;
    public Texture[] Open_Images;
    public Texture[] Idle_Images;
    public Texture[] Close_Images;
    public Texture[] Catch_Images;

    //나쁜 두더지

    public Texture[] Open_Images_2;
    public Texture[] Idle_Images_2;
    public Texture[] Close_Images_2;
    public Texture[] Catch_Images_2;


    public float Ani_Speed;
    public float _now_ani_time;

    int Ani_count;

    //Open
    public void Open_On()
    {
        MS = MoleState.Open;
        Ani_count = 0;

        int a = Random.Range(0, 100);

        if (a <= 80)
        {
            GoodMole = true;
        }
        else
        {
            GoodMole = false;
        }
    }

    public void Open_Ing()
    {
        if (GoodMole == true)
        {
            GetComponent<Renderer>().material.mainTexture = Open_Images[Ani_count];
            Ani_count += 1;

            if (Ani_count >= Open_Images.Length)
            {
                Idle_On();
            }
        }
        else
        {
            GetComponent<Renderer>().material.mainTexture = Open_Images_2[Ani_count];
            Ani_count += 1;

            if (Ani_count >= Open_Images_2.Length)
            {
                Idle_On();
            }
        }
    }

    //Idle
    public void Idle_On()
    {
        MS = MoleState.Idle;
        Ani_count = 0;
    }
    public void Idle_Ing()
    {
        if (GoodMole == true)
        {
            GetComponent<Renderer>().material.mainTexture = Idle_Images[Ani_count];
            Ani_count += 1;

            if (Ani_count >= Idle_Images.Length)
            {
                Close_On();
            }
        }
        else {
            GetComponent<Renderer>().material.mainTexture = Idle_Images_2[Ani_count];
            Ani_count += 1;

            if (Ani_count >= Idle_Images_2.Length)
            {
                Close_On();
            }
        }
    }

    //Close
    public void Close_On()
    {
        MS = MoleState.Close;
        Ani_count = 0;
    }
    public void Close_Ing()
    {
        if (GoodMole == true)
        {
            GetComponent<Renderer>().material.mainTexture = Close_Images[Ani_count];
            Ani_count += 1;

            if (Ani_count >= Close_Images.Length)
            {
                StartCoroutine("Wait");
            }
        }
        else
        {
            GetComponent<Renderer>().material.mainTexture = Close_Images_2[Ani_count];
            Ani_count += 1;

            if (Ani_count >= Close_Images_2.Length)
            {
                StartCoroutine("Wait");
            }
        }
    }
    //Catch
    public void Catch_On()
    {
        MS = MoleState.Catch;
        Ani_count = 0;
        if (GoodMole == true)
        {
            MG.g_cnt++;
        }
        else
        {
            MG.b_cnt++;
        }
    }
    public void Catch_Ing()
    {
        if (GoodMole == true)
        {
            GetComponent<Renderer>().material.mainTexture = Catch_Images[Ani_count];
            Ani_count += 1;

            if (Ani_count >= Catch_Images.Length)
            {
                StartCoroutine("Wait");
            }
        }
        else
        {
            GetComponent<Renderer>().material.mainTexture = Catch_Images_2[Ani_count];
            Ani_count += 1;

            if (Ani_count >= Catch_Images_2.Length)
            {
                StartCoroutine("Wait");
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Wait");
    }

    // Update is called once per frame
    void Update()
    {
        if (_now_ani_time >= Ani_Speed)
        {
            if (MS == MoleState.Open)
            {
                Open_Ing();
            }
            if (MS == MoleState.Idle)
            {
                Idle_Ing();
            }
            if (MS == MoleState.Close)
            {
                Close_Ing();
            }
            if (MS == MoleState.Catch)
            {
                Catch_Ing();
            }

            _now_ani_time = 0;
        }
        else
        {
            _now_ani_time += Time.deltaTime;
        }
    }
   
    //restart
    public void restart()
    {
        MS = MoleState.None;
        GetComponent<Renderer>().material.mainTexture = None_Image;

        StartCoroutine("Wait");
    }

    public void OnMouseDown()
    {
        if (MS == MoleState.Idle || MS== MoleState.Open)
        {
            Catch_On();
        }
    }
}
