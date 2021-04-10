using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change_scene : MonoBehaviour
{
    public void ChangeBack()
    {
        SceneManager.LoadScene("scene02_diagnosis");
    }
    public void test_menu()
    {
        SceneManager.LoadScene("scene02_diagnosis");
    }
    public void game_menu()
    {
        SceneManager.LoadScene("scene06_game");
    }
    public void ChangeAlone()
    {
        SceneManager.LoadScene("scene03_alone");
    }
    public void ChangeFamily()
    {
        SceneManager.LoadScene("scene04_family");
    }
    public void go_mole1()
    {
        SceneManager.LoadScene("mole1");
    }
    public void go_mole2()
    {
        SceneManager.LoadScene("mole2");
    }
    public void ShowResult_alone()
    {
        SceneManager.LoadScene("scene05_01_test_res1");
        /*selftest_slider selftest_Slider = GameObject.Find("Main Camera").GetComponent<selftest_slider>();
        if (selftest_Slider.where == 0)
        {
            SceneManager.LoadScene("scene05_01_test_res1");
        }
        else if (selftest_Slider.where == 1)
        {
            SceneManager.LoadScene("scene05_02_test_res2");
        }
        else
        {
            SceneManager.LoadScene("scene05_01_test_res1");
            //문제 발생 나중에 꼭 수정! 원래는 메인으로 돌아가야함
            //근데 슬라이더를 안건드리면 test값이 0으로 설정되지 않아서 where이 -1로 넘어가게 됨
            //그래서 아무것도 안건드린 0점이 되었을 때 홈으로 돌아가게 되는 오류 생김
            //-1 이 발생할 만한 상황이 안건드린 상황 뿐이므로 이때는 test_res_1으로 갈것
        }*/
    }
    public void ShowResult_family()
    {
        SceneManager.LoadScene("scene05_01_test_res1");
        /*familytest_slider familytest_Slider = GameObject.Find("Main Camera").GetComponent<familytest_slider>();
        if (familytest_Slider.where == 0)
        {
            SceneManager.LoadScene("scene05_01_test_res1");
        }
        else if (familytest_Slider.where == 1)
        {
            SceneManager.LoadScene("scene05_02_test_res2");
        }
        else
        {
            SceneManager.LoadScene("scene05_01_test_res1");
        }*/
    }
}