using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoProgressBar : MonoBehaviour, IDragHandler, IPointerDownHandler
{
    [SerializeField]
    public VideoPlayer videoPlayer = null;

    private Image progress;
    

    public void setVideoPlayer(VideoPlayer player)
    {
        if (videoPlayer != null)
        {
            progress.fillAmount = 0;
        }
        videoPlayer = player;
    }

    private void Awake()
    {
        progress = GetComponent<Image>();
    }

    private void Update()
    {
        if (videoPlayer != null)
        {
            if (videoPlayer.frameCount > 0)
                progress.fillAmount = (float)videoPlayer.frame / (float)videoPlayer.frameCount;
        }
       
    }

    public void OnDrag(PointerEventData eventData)
    {
        TrySkip(eventData);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        TrySkip(eventData);
    }

    private void TrySkip(PointerEventData eventData)
    {
        Vector2 localPoint;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(
            progress.rectTransform, eventData.position, null, out localPoint))
        {
            
            float pct = Mathf.InverseLerp(progress.rectTransform.rect.xMin, progress.rectTransform.rect.xMax, localPoint.x);
            SkipToPercent(pct);
        }
    }

    private void SkipToPercent(float pct)
    {
        var frame = videoPlayer.frameCount * pct;
        videoPlayer.frame = (long)frame;
    }
}