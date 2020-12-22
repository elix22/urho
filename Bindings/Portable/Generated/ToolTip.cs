// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// ToolTip.cs
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

namespace Urho.Gui
{
	/// <summary>
	/// Tooltip %UI element.
	/// </summary>
	public unsafe partial class ToolTip : UIElement
	{
		unsafe partial void OnToolTipCreated ();

		[Preserve]
		public ToolTip (IntPtr handle) : base (handle)
		{
			OnToolTipCreated ();
		}

		[Preserve]
		protected ToolTip (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
			OnToolTipCreated ();
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int ToolTip_GetType (IntPtr handle);

		private StringHash UrhoGetType ()
		{
			Runtime.ValidateRefCounted (this);
			return new StringHash (ToolTip_GetType (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr ToolTip_GetTypeName (IntPtr handle);

		private string GetTypeName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (ToolTip_GetTypeName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int ToolTip_GetTypeStatic ();

		private static StringHash GetTypeStatic ()
		{
			Runtime.Validate (typeof(ToolTip));
			return new StringHash (ToolTip_GetTypeStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr ToolTip_GetTypeNameStatic ();

		private static string GetTypeNameStatic ()
		{
			Runtime.Validate (typeof(ToolTip));
			return Marshal.PtrToStringAnsi (ToolTip_GetTypeNameStatic ());
		}

		[Preserve]
		public ToolTip () : this (Application.CurrentContext)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr ToolTip_ToolTip (IntPtr context);

		[Preserve]
		public ToolTip (Context context) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(ToolTip));
			handle = ToolTip_ToolTip ((object)context == null ? IntPtr.Zero : context.Handle);
			Runtime.RegisterObject (this);
			OnToolTipCreated ();
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ToolTip_RegisterObject (IntPtr context);

		/// <summary>
		/// Register object factory.
		/// </summary>
		public new static void RegisterObject (Context context)
		{
			Runtime.Validate (typeof(ToolTip));
			ToolTip_RegisterObject ((object)context == null ? IntPtr.Zero : context.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ToolTip_Update (IntPtr handle, float timeStep);

		/// <summary>
		/// Perform UI element update.
		/// </summary>
		public override void Update (float timeStep)
		{
			Runtime.ValidateRefCounted (this);
			ToolTip_Update (handle, timeStep);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ToolTip_Reset (IntPtr handle);

		/// <summary>
		/// Hide tooltip if visible and reset parentage.
		/// </summary>
		public void Reset ()
		{
			Runtime.ValidateRefCounted (this);
			ToolTip_Reset (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ToolTip_AddAltTarget (IntPtr handle, IntPtr target);

		/// <summary>
		/// Add an alternative hover target.
		/// </summary>
		public void AddAltTarget (UIElement target)
		{
			Runtime.ValidateRefCounted (this);
			ToolTip_AddAltTarget (handle, (object)target == null ? IntPtr.Zero : target.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ToolTip_SetDelay (IntPtr handle, float delay);

		/// <summary>
		/// Set the delay in seconds until the tooltip shows once hovering. Set zero to use the default from the UI subsystem.
		/// </summary>
		private void SetDelay (float delay)
		{
			Runtime.ValidateRefCounted (this);
			ToolTip_SetDelay (handle, delay);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float ToolTip_GetDelay (IntPtr handle);

		/// <summary>
		/// Return the delay in seconds until the tooltip shows once hovering.
		/// </summary>
		private float GetDelay ()
		{
			Runtime.ValidateRefCounted (this);
			return ToolTip_GetDelay (handle);
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
		public new static StringHash TypeStatic {
			get {
				return GetTypeStatic ();
			}
		}

		public new static string TypeNameStatic {
			get {
				return GetTypeNameStatic ();
			}
		}

		/// <summary>
		/// Return the delay in seconds until the tooltip shows once hovering.
		/// Or
		/// Set the delay in seconds until the tooltip shows once hovering. Set zero to use the default from the UI subsystem.
		/// </summary>
		public float Delay {
			get {
				return GetDelay ();
			}
			set {
				SetDelay (value);
			}
		}
	}
}
