using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ClickLoadAsyncScript : MonoBehaviour {

	public Slider loadingSlider;
	public GameObject loadingImage;
	
	private AsyncOperation async;
	
	public void ClickAsync(int level)
	{
		loadingImage.SetActive(true);
		StartCoroutine(loadLevelWithBar(level));
	}
	
	IEnumerator loadLevelWithBar (int level)
	{
		async = Application.LoadLevelAsync(level);
		while(!async.isDone)
		{
			loadingSlider.value = async.progress;
			yield return null;
		}
	}
}
