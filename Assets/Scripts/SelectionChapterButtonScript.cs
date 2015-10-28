using UnityEngine;
using System.Collections;

public class SelectionChapterButtonScript : MonoBehaviour {

	public GameObject loadingImage;

	public void LoadChapter()
	{
		loadingImage.SetActive(true);
		Application.LoadLevel("SelectionChapter");
	}
}
