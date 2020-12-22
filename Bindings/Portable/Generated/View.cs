// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// View.cs
// 
// Copyright 2015 Xamarin Inc. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Urho.Urho2D;
using Urho.Gui;
using Urho.Resources;
using Urho.IO;
using Urho.Navigation;
using Urho.Network;

namespace Urho
{
	/// <summary>
	/// Internal structure for 3D rendering work. Created for each backbuffer and texture viewport, but not for shadow cameras.
	/// </summary>
	public unsafe partial class View : UrhoObject
	{
		unsafe partial void OnViewCreated ();

		[Preserve]
		public View (IntPtr handle) : base (handle)
		{
			OnViewCreated ();
		}

		[Preserve]
		protected View (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
			OnViewCreated ();
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int View_GetType (IntPtr handle);

		private StringHash UrhoGetType ()
		{
			Runtime.ValidateRefCounted (this);
			return new StringHash (View_GetType (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr View_GetTypeName (IntPtr handle);

		private string GetTypeName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (View_GetTypeName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int View_GetTypeStatic ();

		private static StringHash GetTypeStatic ()
		{
			Runtime.Validate (typeof(View));
			return new StringHash (View_GetTypeStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr View_GetTypeNameStatic ();

		private static string GetTypeNameStatic ()
		{
			Runtime.Validate (typeof(View));
			return Marshal.PtrToStringAnsi (View_GetTypeNameStatic ());
		}

		[Preserve]
		public View () : this (Application.CurrentContext)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr View_View (IntPtr context);

		[Preserve]
		public View (Context context) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(View));
			handle = View_View ((object)context == null ? IntPtr.Zero : context.Handle);
			Runtime.RegisterObject (this);
			OnViewCreated ();
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool View_Define (IntPtr handle, IntPtr renderTarget, IntPtr viewport);

		/// <summary>
		/// Define with rendertarget and viewport. Return true if successful.
		/// </summary>
		public bool Define (RenderSurface renderTarget, Viewport viewport)
		{
			Runtime.ValidateRefCounted (this);
			return View_Define (handle, (object)renderTarget == null ? IntPtr.Zero : renderTarget.Handle, (object)viewport == null ? IntPtr.Zero : viewport.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void View_Render (IntPtr handle);

		/// <summary>
		/// Render batches.
		/// </summary>
		public void Render ()
		{
			Runtime.ValidateRefCounted (this);
			View_Render (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr View_GetGraphics (IntPtr handle);

		/// <summary>
		/// Return graphics subsystem.
		/// </summary>
		private Graphics GetGraphics ()
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<Graphics> (View_GetGraphics (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr View_GetRenderer (IntPtr handle);

		/// <summary>
		/// Return renderer subsystem.
		/// </summary>
		private Renderer GetRenderer ()
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<Renderer> (View_GetRenderer (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr View_GetScene (IntPtr handle);

		/// <summary>
		/// Return scene.
		/// </summary>
		private Scene GetScene ()
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<Scene> (View_GetScene (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr View_GetOctree (IntPtr handle);

		/// <summary>
		/// Return octree.
		/// </summary>
		private Octree GetOctree ()
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<Octree> (View_GetOctree (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr View_GetCamera (IntPtr handle);

		/// <summary>
		/// Return viewport camera.
		/// </summary>
		private Camera GetCamera ()
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<Camera> (View_GetCamera (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr View_GetCullCamera (IntPtr handle);

		/// <summary>
		/// Return culling camera. Normally same as the viewport camera.
		/// </summary>
		private Camera GetCullCamera ()
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<Camera> (View_GetCullCamera (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr View_GetRenderTarget (IntPtr handle);

		/// <summary>
		/// Return the rendertarget. 0 if using the backbuffer.
		/// </summary>
		private RenderSurface GetRenderTarget ()
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupRefCounted<RenderSurface> (View_GetRenderTarget (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool View_GetDrawDebug (IntPtr handle);

		/// <summary>
		/// Return whether should draw debug geometry.
		/// </summary>
		private bool GetDrawDebug ()
		{
			Runtime.ValidateRefCounted (this);
			return View_GetDrawDebug (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.IntRect View_GetViewRect (IntPtr handle);

		/// <summary>
		/// Return view rectangle.
		/// </summary>
		private Urho.IntRect GetViewRect ()
		{
			Runtime.ValidateRefCounted (this);
			return View_GetViewRect (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.IntVector2 View_GetViewSize (IntPtr handle);

		/// <summary>
		/// Return view dimensions.
		/// </summary>
		private Urho.IntVector2 GetViewSize ()
		{
			Runtime.ValidateRefCounted (this);
			return View_GetViewSize (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr View_GetOcclusionBuffer (IntPtr handle);

		/// <summary>
		/// Return the last used software occlusion buffer.
		/// </summary>
		private OcclusionBuffer GetOcclusionBuffer ()
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<OcclusionBuffer> (View_GetOcclusionBuffer (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint View_GetNumActiveOccluders (IntPtr handle);

		/// <summary>
		/// Return number of occluders that were actually rendered. Occluders may be rejected if running out of triangles or if behind other occluders.
		/// </summary>
		private uint GetNumActiveOccluders ()
		{
			Runtime.ValidateRefCounted (this);
			return View_GetNumActiveOccluders (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr View_GetSourceView (IntPtr handle);

		/// <summary>
		/// Return the source view that was already prepared. Used when viewports specify the same culling camera.
		/// </summary>
		private View GetSourceView ()
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<View> (View_GetSourceView (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void View_SetGlobalShaderParameters (IntPtr handle);

		/// <summary>
		/// Set global (per-frame) shader parameters. Called by Batch and internally by View.
		/// </summary>
		public void SetGlobalShaderParameters ()
		{
			Runtime.ValidateRefCounted (this);
			View_SetGlobalShaderParameters (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void View_SetCameraShaderParameters (IntPtr handle, IntPtr camera);

		/// <summary>
		/// Set camera-specific shader parameters. Called by Batch and internally by View.
		/// </summary>
		public void SetCameraShaderParameters (Camera camera)
		{
			Runtime.ValidateRefCounted (this);
			View_SetCameraShaderParameters (handle, (object)camera == null ? IntPtr.Zero : camera.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void View_SetCommandShaderParameters (IntPtr handle, ref Urho.RenderPathCommand command);

		/// <summary>
		/// Set command's shader parameters if any. Called internally by View.
		/// </summary>
		public void SetCommandShaderParameters (Urho.RenderPathCommand command)
		{
			Runtime.ValidateRefCounted (this);
			View_SetCommandShaderParameters (handle, ref command);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void View_SetGBufferShaderParameters (IntPtr handle, ref Urho.IntVector2 texSize, ref Urho.IntRect viewRect);

		/// <summary>
		/// Set G-buffer offset and inverse size shader parameters. Called by Batch and internally by View.
		/// </summary>
		public void SetGBufferShaderParameters (Urho.IntVector2 texSize, Urho.IntRect viewRect)
		{
			Runtime.ValidateRefCounted (this);
			View_SetGBufferShaderParameters (handle, ref texSize, ref viewRect);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void View_DrawFullscreenQuad (IntPtr handle, bool setIdentityProjection);

		/// <summary>
		/// Draw a fullscreen quad. Shaders and renderstates must have been set beforehand. Quad will be drawn to the middle of depth range, similarly to deferred directional lights.
		/// </summary>
		public void DrawFullscreenQuad (bool setIdentityProjection = false)
		{
			Runtime.ValidateRefCounted (this);
			View_DrawFullscreenQuad (handle, setIdentityProjection);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr View_FindNamedTexture (IntPtr handle, string name, bool isRenderTarget, bool isVolumeMap);

		/// <summary>
		/// Get a named texture from the rendertarget list or from the resource cache, to be either used as a rendertarget or texture binding.
		/// </summary>
		public Texture FindNamedTexture (string name, bool isRenderTarget, bool isVolumeMap = false)
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<Texture> (View_FindNamedTexture (handle, name, isRenderTarget, isVolumeMap));
		}

		public override StringHash Type {
			get {
				return UrhoGetType ();
			}
		}

		public override string TypeName {
			get {
				return GetTypeName ();
			}
		}

		[Preserve]
		public static StringHash TypeStatic {
			get {
				return GetTypeStatic ();
			}
		}

		public static string TypeNameStatic {
			get {
				return GetTypeNameStatic ();
			}
		}

		/// <summary>
		/// Return graphics subsystem.
		/// </summary>
		public Graphics Graphics {
			get {
				return GetGraphics ();
			}
		}

		/// <summary>
		/// Return renderer subsystem.
		/// </summary>
		public Renderer Renderer {
			get {
				return GetRenderer ();
			}
		}

		/// <summary>
		/// Return scene.
		/// </summary>
		public Scene Scene {
			get {
				return GetScene ();
			}
		}

		/// <summary>
		/// Return octree.
		/// </summary>
		public Octree Octree {
			get {
				return GetOctree ();
			}
		}

		/// <summary>
		/// Return viewport camera.
		/// </summary>
		public Camera Camera {
			get {
				return GetCamera ();
			}
		}

		/// <summary>
		/// Return culling camera. Normally same as the viewport camera.
		/// </summary>
		public Camera CullCamera {
			get {
				return GetCullCamera ();
			}
		}

		/// <summary>
		/// Return the rendertarget. 0 if using the backbuffer.
		/// </summary>
		public RenderSurface RenderTarget {
			get {
				return GetRenderTarget ();
			}
		}

		/// <summary>
		/// Return whether should draw debug geometry.
		/// </summary>
		public bool DrawDebug {
			get {
				return GetDrawDebug ();
			}
		}

		/// <summary>
		/// Return view rectangle.
		/// </summary>
		public Urho.IntRect ViewRect {
			get {
				return GetViewRect ();
			}
		}

		/// <summary>
		/// Return view dimensions.
		/// </summary>
		public Urho.IntVector2 ViewSize {
			get {
				return GetViewSize ();
			}
		}

		/// <summary>
		/// Return the last used software occlusion buffer.
		/// </summary>
		public OcclusionBuffer OcclusionBuffer {
			get {
				return GetOcclusionBuffer ();
			}
		}

		/// <summary>
		/// Return number of occluders that were actually rendered. Occluders may be rejected if running out of triangles or if behind other occluders.
		/// </summary>
		public uint NumActiveOccluders {
			get {
				return GetNumActiveOccluders ();
			}
		}

		/// <summary>
		/// Return the source view that was already prepared. Used when viewports specify the same culling camera.
		/// </summary>
		public View SourceView {
			get {
				return GetSourceView ();
			}
		}
	}
}
