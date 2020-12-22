// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// UISelectable.cs
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
	/// Construct.
	/// </summary>
	public unsafe partial class UISelectable : UIElement
	{
		unsafe partial void OnUISelectableCreated ();

		[Preserve]
		public UISelectable (IntPtr handle) : base (handle)
		{
			OnUISelectableCreated ();
		}

		[Preserve]
		protected UISelectable (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
			OnUISelectableCreated ();
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int UISelectable_GetType (IntPtr handle);

		private StringHash UrhoGetType ()
		{
			Runtime.ValidateRefCounted (this);
			return new StringHash (UISelectable_GetType (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr UISelectable_GetTypeName (IntPtr handle);

		private string GetTypeName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (UISelectable_GetTypeName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int UISelectable_GetTypeStatic ();

		private static StringHash GetTypeStatic ()
		{
			Runtime.Validate (typeof(UISelectable));
			return new StringHash (UISelectable_GetTypeStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr UISelectable_GetTypeNameStatic ();

		private static string GetTypeNameStatic ()
		{
			Runtime.Validate (typeof(UISelectable));
			return Marshal.PtrToStringAnsi (UISelectable_GetTypeNameStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void UISelectable_RegisterObject (IntPtr context);

		/// <summary>
		/// Register object factory.
		/// </summary>
		public new static void RegisterObject (Context context)
		{
			Runtime.Validate (typeof(UISelectable));
			UISelectable_RegisterObject ((object)context == null ? IntPtr.Zero : context.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void UISelectable_SetSelectionColor (IntPtr handle, ref Urho.Color color);

		/// <summary>
		/// Set selection background color. Color with 0 alpha (default) disables.
		/// </summary>
		private void SetSelectionColor (Urho.Color color)
		{
			Runtime.ValidateRefCounted (this);
			UISelectable_SetSelectionColor (handle, ref color);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void UISelectable_SetHoverColor (IntPtr handle, ref Urho.Color color);

		/// <summary>
		/// Set hover background color. Color with 0 alpha (default) disables.
		/// </summary>
		private void SetHoverColor (Urho.Color color)
		{
			Runtime.ValidateRefCounted (this);
			UISelectable_SetHoverColor (handle, ref color);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.Color UISelectable_GetSelectionColor (IntPtr handle);

		/// <summary>
		/// Return selection background color.
		/// </summary>
		private Urho.Color GetSelectionColor ()
		{
			Runtime.ValidateRefCounted (this);
			return UISelectable_GetSelectionColor (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.Color UISelectable_GetHoverColor (IntPtr handle);

		/// <summary>
		/// Return hover background color.
		/// </summary>
		private Urho.Color GetHoverColor ()
		{
			Runtime.ValidateRefCounted (this);
			return UISelectable_GetHoverColor (handle);
		}

		[Preserve]
		public UISelectable () : this (Application.CurrentContext)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr UISelectable_UISelectable (IntPtr param1);

		[Preserve]
		public UISelectable (Context param1) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(UISelectable));
			handle = UISelectable_UISelectable ((object)param1 == null ? IntPtr.Zero : param1.Handle);
			Runtime.RegisterObject (this);
			OnUISelectableCreated ();
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
		/// Return selection background color.
		/// Or
		/// Set selection background color. Color with 0 alpha (default) disables.
		/// </summary>
		public Urho.Color SelectionColor {
			get {
				return GetSelectionColor ();
			}
			set {
				SetSelectionColor (value);
			}
		}

		/// <summary>
		/// Return hover background color.
		/// Or
		/// Set hover background color. Color with 0 alpha (default) disables.
		/// </summary>
		public Urho.Color HoverColor {
			get {
				return GetHoverColor ();
			}
			set {
				SetHoverColor (value);
			}
		}
	}
}
