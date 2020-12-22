using System;
using System.Runtime.InteropServices;

namespace Urho {
	/* TBD ELI , generated
	[Flags]
	public enum MouseButton {
		Left = 1 << 0,
		Middle = 1 << 1,
		Right = 1 << 2,
		X1 = 1 << 3,
		X2 = 1 << 4,
	}
*/
/* TBD ELI , generated
	public enum Key {
		A = 'a',
		B = 'b',
		C = 'c',
		D = 'd',
		E = 'e',
		F = 'f',
		G = 'g',
		H = 'h',
		I = 'i',
		J = 'j',
		K = 'k',
		L = 'l',
		M = 'm',
		N = 'n',
		O = 'o',
		P = 'p',
		Q = 'q',
		R = 'r',
		S = 's',
		T = 't',
		U = 'u',
		V = 'v',
		W = 'w',
		X = 'x',
		Y = 'y',
		Z = 'z',
		N0 = '0',
		N1 = '1',
		N2 = '2',
		N3 = '3',
		N4 = '4',
		N5 = '5',
		N6 = '6',
		N7 = '7',
		N8 = '8',
		N9 = '9',
		Backspace = 0x00000008,
		Tab = 0x00000009,
		Return = 0x0000000d,
		Return2 = 0x4000009e,
		Kp_ENTER = 0x40000058,
		Shift = 0x400000e1,
		Ctrl = 0x400000e0,
		Alt = 0x400000e2,
		Gui = 0x400000e3,
		Pause = 0x40000048,
		Capslock = 0x40000039,
		Esc = 0x0000001b,
		Space = 0x00000020,
		PageUp = 0x4000004b,
		PageDown = 0x4000004e,
		End = 0x4000004d,
		Home = 0x4000004a,
		Left = 0x40000050,
		Up = 0x40000052,
		Right = 0x4000004f,
		Down = 0x40000051,
		Select = 0x40000077,
		PrintScreen = 0x40000046,
		Insert = 0x40000049,
		Delete = 0x0000007f,
		LeftGui = 0x400000e3,
		RightGui = 0x400000e7,
		Application = 0x40000065,
		KP_0 = 0x40000062,
		KP_1 = 0x40000059,
		KP_2 = 0X4000005A,
		KP_3 = 0x4000005b,
		KP_4 = 0x4000005c,
		KP_5 = 0X4000005D,
		KP_6 = 0X4000005E,
		KP_7 = 0X4000005F,
		KP_8 = 0X40000060,
		KP_9 = 0x40000061,
		KP_Multiply = 0x40000055,
		KP_Plus = 0x40000057,
		KP_Minus = 0x40000056,
		KP_Period = 0x40000063,
		KP_Divide = 0x40000054,
		F1 = 0x4000003a,
		F2 = 0x4000003b,
		F3 = 0x4000003c,
		F4 = 0x4000003d,
		F5 = 0x4000003e,
		F6 = 0x4000003f,
		F7 = 0x40000040,
		F8 = 0x40000041,
		F9 = 0x40000042,
		F10 = 0x40000043,
		F11 = 0x40000044,
		F12 = 0x40000045,
		F13 = 0x40000068,
		F14 = 0x40000069,
		F15 = 0x4000006a,
		F16 = 0x4000006b,
		F17 = 0x4000006c,
		F18 = 0x4000006d,
		F19 = 0x4000006e,
		F20 = 0x4000006f,
		F21 = 0x40000070,
		F22 = 0x40000071,
		F23 = 0x40000072,
		F24 = 0x40000073,
		NumlockClear = 0x40000053,
		ScrollLock = 0x40000047,
		LeftShift = 0x400000e1,
		RightShift = 0x400000e5,
		LeftCtrl = 0x400000e0,
		RightCtrl = 0x400000e4,
		LeftAlt = 0x400000e2,
		RightAlt = 0x400000e6,
	}
	*/

	public partial class Input {

		public unsafe bool TryGetJoystickState(uint idx, out JoystickState state)
		{
			Runtime.ValidateRefCounted(this);
			var x = GetJoystickByIndex(idx);
			if (x != null)
			{
				state = *x;
				return true;
			}
			state = new JoystickState();
			return false;
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Input_GetMouseButtonDown (IntPtr handle, int button);

		/// <summary>
		/// Check if a mouse button is held down.
		/// </summary>
		public bool GetMouseButtonDown (MouseButton button)
		{
			Runtime.ValidateRefCounted (this);
			return Input_GetMouseButtonDown (handle, (int)button);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Input_GetMouseButtonPress (IntPtr handle, int button);

		/// <summary>
		/// Check if a mouse button has been pressed on this frame.
		/// </summary>
		public bool GetMouseButtonPress (MouseButton button)
		{
			Runtime.ValidateRefCounted (this);
			return Input_GetMouseButtonPress (handle, (int)button);
		}

		// Dummy
		public bool Enabled;

	}
}
