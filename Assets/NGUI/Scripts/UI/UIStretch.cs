//----------------------------------------------
//            NGUI: Next-Gen UI kit
// Copyright © 2011-2013 Tasharen Entertainment
//----------------------------------------------

using UnityEngine;

/// <summary>
/// This script can be used to stretch objects relative to the screen's width and height.
/// The most obvious use would be to create a full-screen background by attaching it to a sprite.
/// </summary>

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Stretch")]
public class UIStretch : MonoBehaviour
{
	public enum Style
	{
		None,
		Horizontal,
		Vertical,
		Both,
		BasedOnHeight,
		FillKeepingRatio, // Fits the image so that it entirely fills the specified container keeping its ratio
		FitInternalKeepingRatio // Fits the image/item inside of the specified container keeping its ratio
	}

	/// <summary>
	/// Camera used to determine the anchor bounds. Set automatically if none was specified.
	/// </summary>

	public Camera uiCamera = null;

	/// <summary>
	/// Object used to determine the container's bounds. Overwrites the camera-based anchoring if the value was specified.
	/// </summary>

	public GameObject container = null;

	/// <summary>
	/// Stretching style.
	/// </summary>

	public Style style = Style.None;

	/// <summary>
	/// Whether the operation will occur only once and the script will then be disabled.
	/// Screen size changes will still cause the script's logic to execute.
	/// </summary>

	public bool runOnlyOnce = true;
	
	//[edit] 2014.06.13
	public bool scaleFixedToOne = false;

	/// <summary>
	/// Relative-to-target size.
	/// </summary>

	public Vector2 relativeSize = Vector2.one;

	/// <summary>
	/// The size that the item/image should start out initially.
	/// Used for FillKeepingRatio, and FitInternalKeepingRatio.
	/// Contributed by Dylan Ryan.
	/// </summary>

	public Vector2 initialSize = Vector2.one;

	/// <summary>
	/// Padding applied after the size of the stretched object gets calculated. This value is in pixels.
	/// </summary>

	public Vector2 borderPadding = Vector2.zero;

	// Deprecated legacy functionality
	[HideInInspector][SerializeField] UIWidget widgetContainer;

	Transform mTrans;
	UIWidget mWidget;
	UISprite mSprite;
	UIPanel mPanel;
	UIRoot mRoot;
	Animation mAnim;
	Rect mRect;

	void Awake ()
	{
		mAnim = animation;
		mRect = new Rect();
		mTrans = transform;
		mWidget = GetComponent<UIWidget>();
		mSprite = GetComponent<UISprite>();
		mPanel = GetComponent<UIPanel>();

		UICamera.onScreenResize += ScreenSizeChanged;
	}

	void OnDestroy () { UICamera.onScreenResize -= ScreenSizeChanged; }

	void ScreenSizeChanged () { if (runOnlyOnce) Update(); }

	void Start ()
	{
		if (container == null && widgetContainer != null)
		{
			container = widgetContainer.gameObject;
			widgetContainer = null;
#if UNITY_EDITOR
			UnityEditor.EditorUtility.SetDirty(this);
#endif
		}

		if (uiCamera == null) uiCamera = NGUITools.FindCameraForLayer(gameObject.layer);
		mRoot = NGUITools.FindInParents<UIRoot>(gameObject);
		Update();
	}

	void Update ()
	{
		if (mAnim != null && mAnim.isPlaying) return;

		if (style != Style.None)
		{
			UIWidget wc = (container == null) ? null : container.GetComponent<UIWidget>();
			UIPanel pc = (container == null && wc == null) ? null : container.GetComponent<UIPanel>();
			float adjustment = 1f;

			if (wc != null)
			{
				Bounds b = wc.CalculateBounds(transform.parent);

				mRect.x = b.min.x;
				mRect.y = b.min.y;

				mRect.width = b.size.x;
				mRect.height = b.size.y;
			}
			else if (pc != null)
			{
				if (pc.clipping == UIDrawCall.Clipping.None)
				{
					// Panel has no clipping -- just use the screen's dimensions
					float ratio = (mRoot != null) ? (float)mRoot.activeHeight / Screen.height * 0.5f : 0.5f;
					mRect.xMin = -Screen.width * ratio;
					mRect.yMin = -Screen.height * ratio;
					mRect.xMax = -mRect.xMin;
					mRect.yMax = -mRect.yMin;
				}
				else
				{
					// Panel has clipping -- use it as the mRect
					Vector4 pos = pc.clipRange;
					mRect.x = pos.x - (pos.z * 0.5f);
					mRect.y = pos.y - (pos.w * 0.5f);
					mRect.width = pos.z;
					mRect.height = pos.w;
				}
			}
			else if (container != null)
			{
				Transform root = transform.parent;
				Bounds b = (root != null) ? NGUIMath.CalculateRelativeWidgetBounds(root, container.transform) :
					NGUIMath.CalculateRelativeWidgetBounds(container.transform);

				mRect.x = b.min.x;
				mRect.y = b.min.y;

				mRect.width = b.size.x;
				mRect.height = b.size.y;
			}
			else if (uiCamera != null)
			{
				mRect = uiCamera.pixelRect;
				if (mRoot != null) adjustment = mRoot.pixelSizeAdjustment;
			}
			else return;

			float rectWidth = mRect.width;
			float rectHeight = mRect.height;

			if (adjustment != 1f && rectHeight > 1f)
			{
				float scale = mRoot.activeHeight / rectHeight;
				rectWidth *= scale;
				rectHeight *= scale;
			}
			
			//[edit] 2014.06.13
			if(scaleFixedToOne)
			{
				scaleFixedToOne = false;
				relativeSize.x = 1.0f / rectWidth;
				relativeSize.y = 1.0f / rectHeight;
			}

			Vector3 size = (mWidget != null) ? new Vector3(mWidget.width, mWidget.height) : mTrans.localScale;

			if (style == Style.BasedOnHeight)
			{
				size.x = relativeSize.x * rectHeight;
				size.y = relativeSize.y * rectHeight;
			}
			else if (style == Style.FillKeepingRatio)
			{
				// Contributed by Dylan Ryan
				float screenRatio = rectWidth / rectHeight;
				float imageRatio = initialSize.x / initialSize.y;

				if (imageRatio < screenRatio)
				{
					// Fit horizontally
					float scale = rectWidth / initialSize.x;
					size.x = rectWidth;
					size.y = initialSize.y * scale;
				}
				else
				{
					// Fit vertically
					float scale = rectHeight / initialSize.y;
					size.x = initialSize.x * scale;
					size.y = rectHeight;
				}
			}
			else if (style == Style.FitInternalKeepingRatio)
			{
				// Contributed by Dylan Ryan
				float screenRatio = rectWidth / rectHeight;
				float imageRatio = initialSize.x / initialSize.y;

				if (imageRatio > screenRatio)
				{
					// Fit horizontally
					float scale = rectWidth / initialSize.x;
					size.x = rectWidth;
					size.y = initialSize.y * scale;
				}
				else
				{
					// Fit vertically
					float scale = rectHeight / initialSize.y;
					size.x = initialSize.x * scale;
					size.y = rectHeight;
				}
			}
			else
			{
				if (style != Style.Vertical)
					size.x = relativeSize.x * rectWidth;

				if (style != Style.Horizontal)
					size.y = relativeSize.y * rectHeight;
			}

			if (mSprite != null)
			{
				float multiplier = (mSprite.atlas != null) ? mSprite.atlas.pixelSize : 1f;
				size.x -= borderPadding.x * multiplier;
				size.y -= borderPadding.y * multiplier;

				if (style != Style.Vertical)
					mSprite.width = Mathf.RoundToInt(size.x);

				if (style != Style.Horizontal)
					mSprite.height = Mathf.RoundToInt(size.y);

				size = Vector3.one;
			}
			else if (mWidget != null)
			{
				if (style != Style.Vertical)
					mWidget.width = Mathf.RoundToInt(size.x - borderPadding.x);

				if (style != Style.Horizontal)
					mWidget.height = Mathf.RoundToInt(size.y - borderPadding.y);

				size = Vector3.one;
			}
			else if (mPanel != null)
			{
				Vector4 cr = mPanel.clipRange;

				if (style != Style.Vertical)
					cr.z = size.x - borderPadding.x;
				
				if (style != Style.Horizontal)
					cr.w = size.y - borderPadding.y;
				
				mPanel.clipRange = cr;
				size = Vector3.one;
			}
			else
			{
				if (style != Style.Vertical)
					size.x -= borderPadding.x;
				
				if (style != Style.Horizontal)
					size.y -= borderPadding.y;
			}
			
			if (mTrans.localScale != size)
				mTrans.localScale = size;

			if (runOnlyOnce && Application.isPlaying) enabled = false;
		}
	}
}
