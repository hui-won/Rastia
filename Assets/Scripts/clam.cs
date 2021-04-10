using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class clam : MonoBehaviour
{
  Transform gb1;
  Transform gb2;
  Transform gb3;
  Transform gb4;
  Transform gb5;
  Transform gb6;
  Transform gb7;
  Transform gb8;
  Transform gb9;
  SpriteRenderer spriteRenderer;
  SpriteRenderer spriteRenderer1;
  SpriteRenderer spriteRenderer2;
  SpriteRenderer spriteRenderer3;
  SpriteRenderer spriteRenderer4;
  SpriteRenderer spriteRenderer5;
  SpriteRenderer spriteRenderer6;
  SpriteRenderer spriteRenderer7;
  SpriteRenderer spriteRenderer8;
  public GameObject gameObject0;
  public GameObject gameObject1;
  public GameObject gameObject2;
  public GameObject gameObject3;
  public GameObject gameObject4;
  public GameObject gameObject5;
  public GameObject gameObject6;
  public GameObject gameObject7;
  public GameObject gameObject8;
  [SerializeField]
  public GameObject panel;
  private bool endend=false;
  
  public float turnspeed = 100;
  private float LimitTime = 20;
  public float time = 0f;
  private float changeTime;
  private bool trigger=true;
  public static int dataa=0;
  public List<Color> colorList = new List<Color>{Color.red,Color.black,Color.blue,Color.gray,Color.green,Color.white,Color.yellow};
  font_script font;
  public Button returnBtn;
  // Start is called before the first frame update
  void Start()
  {
    font = GameObject.Find("fontManager").GetComponent< font_script >();
    
    spriteRenderer = gameObject0.GetComponent<SpriteRenderer>();
    spriteRenderer1 = gameObject1.GetComponent<SpriteRenderer>();
    spriteRenderer2 = gameObject2.GetComponent<SpriteRenderer>();
    spriteRenderer3 = gameObject3.GetComponent<SpriteRenderer>();
    spriteRenderer4 = gameObject4.GetComponent<SpriteRenderer>();
    spriteRenderer5 = gameObject5.GetComponent<SpriteRenderer>();
    spriteRenderer6 = gameObject6.GetComponent<SpriteRenderer>();
    spriteRenderer7 = gameObject7.GetComponent<SpriteRenderer>();
    spriteRenderer8 = gameObject8.GetComponent<SpriteRenderer>();
    dataa=0;
    time=0f;
    trigger=true;
    StartCoroutine(ObjectRandomGenerator());
    panel.SetActive(endend);
    
  }
  IEnumerator ObjectRandomGenerator() {
    
    
    while(trigger) {
      int rand = Random.Range(0,colorList.Count);
      int rand1 = Random.Range(0,colorList.Count);
      int rand2 = Random.Range(0,colorList.Count);
      int rand3 = Random.Range(0,colorList.Count);
      int rand4 = Random.Range(0,colorList.Count);
      int rand5 = Random.Range(0,colorList.Count);
      int rand6= Random.Range(0,colorList.Count);
      int rand7 = Random.Range(0,colorList.Count);
      int rand8 = Random.Range(0,colorList.Count);
      List<int> checkInt = new List<int>{rand,rand1,rand2,rand3,rand4,rand5,rand6,rand7,rand8};
      for(int i=0;i<checkInt.Count;i++)
      {
        int aa=1;
        for(int k=i+1;k<checkInt.Count;k++){
          if(checkInt[i]==checkInt[k]){
            aa+=1;
            if(aa>=3){
              dataa+=1;
            }
            if(aa==3){
              break;
            }
          }
          if(aa==3){
            break;
          }
        }
      }
      spriteRenderer.material.color=colorList[rand];
      spriteRenderer1.material.color=colorList[rand1];
      spriteRenderer2.material.color=colorList[rand2];
      spriteRenderer3.material.color=colorList[rand3];
      spriteRenderer4.material.color=colorList[rand4];
      spriteRenderer5.material.color=colorList[rand5];
      spriteRenderer6.material.color=colorList[rand6];
      spriteRenderer7.material.color=colorList[rand7];
      spriteRenderer8.material.color=colorList[rand8];

      
      

      yield return new WaitForSeconds(5f);
    }
  }
    public void returnBtnOnClick()
  {
    Debug.Log("return Button Clicked");
    endend=true;
    panel.SetActive(endend);
    Time.timeScale=0;
    gameObject0.SetActive(false);
    gameObject1.SetActive(false);
    gameObject2.SetActive(false);
    gameObject3.SetActive(false);
    gameObject4.SetActive(false);
    gameObject5.SetActive(false);
    gameObject6.SetActive(false);
    gameObject7.SetActive(false);
    gameObject8.SetActive(false);
    returnBtn.interactable = false;
    font.getPannel1OriginSize();
    font.setPannel1FontSize();
  }
  public void returnyesOnClick()
  {
    SceneManager.LoadScene("line");
    Time.timeScale=1;  
      
  }
  public void returnnoOnClick()
  {
    Debug.Log("return Button Clicked");
    endend=false;
    panel.SetActive(endend);
    Time.timeScale=1;
    gameObject0.SetActive(true);
    gameObject1.SetActive(true);
    gameObject2.SetActive(true);
    gameObject3.SetActive(true);
    gameObject4.SetActive(true);
    gameObject5.SetActive(true);
    gameObject6.SetActive(true);
    gameObject7.SetActive(true);
    gameObject8.SetActive(true);
    returnBtn.interactable = true;
  } 
  private void GameOver(){
    
    trigger=false;
    StopCoroutine(ObjectRandomGenerator());
    
    

  }
  // Update is called once per frame
  void Update()
  {
      
    // LimitTime -= Time.deltaTime;
    // changeTime = Mathf.Round(LimitTime);
    
    gameObject0.transform.Rotate(Vector3.forward,turnspeed*Time.deltaTime);
    gameObject1.transform.Rotate(Vector3.forward,turnspeed*Time.deltaTime);
    gameObject2.transform.Rotate(Vector3.forward,turnspeed*Time.deltaTime);
    gameObject3.transform.Rotate(Vector3.forward,turnspeed*Time.deltaTime);
    gameObject4.transform.Rotate(Vector3.forward,turnspeed*Time.deltaTime);
    gameObject5.transform.Rotate(Vector3.forward,turnspeed*Time.deltaTime);
    gameObject6.transform.Rotate(Vector3.forward,turnspeed*Time.deltaTime);
    gameObject7.transform.Rotate(Vector3.forward,turnspeed*Time.deltaTime);
    gameObject8.transform.Rotate(Vector3.forward,turnspeed*Time.deltaTime);
    
    this.time += Time.deltaTime;
    if(this.time>LimitTime){
      gameObject0.transform.rotation=Quaternion.Euler(new Vector3(0,0,0));
      gameObject1.transform.rotation=Quaternion.Euler(new Vector3(0,0,0));
      gameObject2.transform.rotation=Quaternion.Euler(new Vector3(0,0,0));
      gameObject3.transform.rotation=Quaternion.Euler(new Vector3(0,0,0));
      gameObject4.transform.rotation=Quaternion.Euler(new Vector3(0,0,0));
      gameObject5.transform.rotation=Quaternion.Euler(new Vector3(0,0,0));
      gameObject6.transform.rotation=Quaternion.Euler(new Vector3(0,0,0));
      gameObject7.transform.rotation=Quaternion.Euler(new Vector3(0,0,0));
      gameObject8.transform.rotation=Quaternion.Euler(new Vector3(0,0,0));
      GameOver();
      SceneManager.LoadScene("sjhans");
      
    }
    






  }
}
