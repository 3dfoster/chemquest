using UnityEngine;
using UnityEngine.UI;
using System.Collections;
 
public static class GraphicExtensions
{
   /// <summary>
   /// Fade methods forUI elements;
   /// </summary>
   /// <param name="g"></param>
   public static void FadeIn(this Graphic g)
   {
    g.GetComponent<CanvasRenderer>().SetAlpha(0f);
    g.CrossFadeAlpha(1f, .15f, false);//second param is the time
   }
   public static void FadeOut(this Graphic g)
   {
    g.GetComponent<CanvasRenderer>().SetAlpha(1f);
    g.CrossFadeAlpha(0f, .15f, false);
   }
}

public class FadeTest : MonoBehaviour
{
  void Start()
  {
    gameObject.GetComponent<Graphic>().FadeIn();
  }
}