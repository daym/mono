// UnmanagedType.cs
//
// This code was automatically generated from
// ECMA CLI XML Library Specification.
// Generator: libgen.xsl [1.0; (C) Sergey Chaban (serge@wildwestsoftware.com)]
// Source file: all.xml
// URL: http://devresource.hp.com/devresource/Docs/TechPapers/CSharp/all.xml
//
// (C) 2001 Ximian, Inc.  http://www.ximian.com

//
// Copyright (C) 2004 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//


namespace System.Runtime.InteropServices {


#if NET_2_0
	[ComVisible(true)]
#endif
	public enum UnmanagedType {

		Bool = 2,
		I1 = 3,
		U1 = 4,
		I2 = 5,
		U2 = 6,
		I4 = 7,
		U4 = 8,
		I8 = 9,
		U8 = 10,
		R4 = 11,
		R8 = 12,
		Currency = 15,
		BStr = 19,
		LPStr = 20,
		LPWStr = 21,
		LPTStr = 22,
		ByValTStr = 23,
		IUnknown = 25,
		IDispatch = 26,
		Struct = 27,
		Interface = 28,
		SafeArray = 29,
		ByValArray = 30,
		SysInt = 31,
		SysUInt = 32,
		VBByRefStr = 34,
		AnsiBStr = 35,
		TBStr = 36,
		VariantBool = 37,
		FunctionPtr = 38,
		// LPVoid = 39,
		AsAny = 40,
		//RPrecise = 41,
		LPArray = 42,
		LPStruct = 43,
		CustomMarshaler = 44,
		Error = 45
	} 

} 
