//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2015 Stefanos Apostolopoulos for the Open Toolkit Library
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Text;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics.OpenGL4
{
    public sealed partial class GL
    {
        /// <summary>
        /// Contains native bindings to functions in the category "ShadingLanguageInclude" in the extension "Arb".
        /// </summary>
        public static partial class Arb
        {
            /// <summary>
            /// [requires: ARB_shading_language_include]
            /// </summary>
            /// <param name="shader">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="path">
            /// [length: count]
            /// </param>
            /// <param name="length">
            /// [length: count]
            /// </param>
            [AutoGenerated(Category = "ARB_shading_language_include", Version = "", EntryPoint = "glCompileShaderIncludeARB")]
            public static void CompileShaderInclude(uint shader, int count, [CountAttribute(Parameter = "count")] string[] path, [CountAttribute(Parameter = "count")] int[] length)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_shading_language_include]
            /// </summary>
            /// <param name="shader">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="path">
            /// [length: count]
            /// </param>
            /// <param name="length">
            /// [length: count]
            /// </param>
            [AutoGenerated(Category = "ARB_shading_language_include", Version = "", EntryPoint = "glCompileShaderIncludeARB")]
            public static void CompileShaderInclude(uint shader, int count, [CountAttribute(Parameter = "count")] string[] path, [CountAttribute(Parameter = "count")] ref int length)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_shading_language_include]
            /// </summary>
            /// <param name="shader">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="path">
            /// [length: count]
            /// </param>
            /// <param name="length">
            /// [length: count]
            /// </param>
            [AutoGenerated(Category = "ARB_shading_language_include", Version = "", EntryPoint = "glCompileShaderIncludeARB")]
            public static unsafe void CompileShaderInclude(uint shader, int count, [CountAttribute(Parameter = "count")] string[] path, [CountAttribute(Parameter = "count")] int* length)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_shading_language_include]
            /// </summary>
            /// <param name="namelen">
            /// </param>
            /// <param name="name">
            /// [length: namelen]
            /// </param>
            [AutoGenerated(Category = "ARB_shading_language_include", Version = "", EntryPoint = "glDeleteNamedStringARB")]
            public static void DeleteNamedString(int namelen, [CountAttribute(Parameter = "namelen")] string name)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_shading_language_include]
            /// </summary>
            /// <param name="namelen">
            /// </param>
            /// <param name="name">
            /// [length: namelen]
            /// </param>
            /// <param name="bufSize">
            /// </param>
            /// <param name="stringlen">
            /// [length: 1]
            /// </param>
            /// <param name="@string">
            /// [length: bufSize]
            /// </param>
            [AutoGenerated(Category = "ARB_shading_language_include", Version = "", EntryPoint = "glGetNamedStringARB")]
            public static void GetNamedString(int namelen, [CountAttribute(Parameter = "namelen")] string name, int bufSize, [OutAttribute, CountAttribute(Count = 1)] out int stringlen, [OutAttribute, CountAttribute(Parameter = "bufSize")] out string @string)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_shading_language_include]
            /// </summary>
            /// <param name="namelen">
            /// </param>
            /// <param name="name">
            /// [length: namelen]
            /// </param>
            /// <param name="bufSize">
            /// </param>
            /// <param name="stringlen">
            /// [length: 1]
            /// </param>
            /// <param name="@string">
            /// [length: bufSize]
            /// </param>
            [AutoGenerated(Category = "ARB_shading_language_include", Version = "", EntryPoint = "glGetNamedStringARB")]
            public static unsafe void GetNamedString(int namelen, [CountAttribute(Parameter = "namelen")] string name, int bufSize, [OutAttribute, CountAttribute(Count = 1)] int* stringlen, [OutAttribute, CountAttribute(Parameter = "bufSize")] out string @string)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_shading_language_include]
            /// </summary>
            /// <param name="namelen">
            /// </param>
            /// <param name="name">
            /// [length: namelen]
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "ARB_shading_language_include", Version = "", EntryPoint = "glGetNamedStringivARB")]
            public static void GetNamedString(int namelen, [CountAttribute(Parameter = "namelen")] string name, OpenTK.Graphics.OpenGL4.ArbShadingLanguageInclude pname, [OutAttribute, CountAttribute(Computed = "pname")] int[] @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_shading_language_include]
            /// </summary>
            /// <param name="namelen">
            /// </param>
            /// <param name="name">
            /// [length: namelen]
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "ARB_shading_language_include", Version = "", EntryPoint = "glGetNamedStringivARB")]
            public static void GetNamedString(int namelen, [CountAttribute(Parameter = "namelen")] string name, OpenTK.Graphics.OpenGL4.ArbShadingLanguageInclude pname, [OutAttribute, CountAttribute(Computed = "pname")] out int @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_shading_language_include]
            /// </summary>
            /// <param name="namelen">
            /// </param>
            /// <param name="name">
            /// [length: namelen]
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "ARB_shading_language_include", Version = "", EntryPoint = "glGetNamedStringivARB")]
            public static unsafe void GetNamedString(int namelen, [CountAttribute(Parameter = "namelen")] string name, OpenTK.Graphics.OpenGL4.ArbShadingLanguageInclude pname, [OutAttribute, CountAttribute(Computed = "pname")] int* @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_shading_language_include]
            /// </summary>
            /// <param name="namelen">
            /// </param>
            /// <param name="name">
            /// [length: namelen]
            /// </param>
            [AutoGenerated(Category = "ARB_shading_language_include", Version = "", EntryPoint = "glIsNamedStringARB")]
            public static bool IsNamedString(int namelen, [CountAttribute(Parameter = "namelen")] string name)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_shading_language_include]
            /// </summary>
            /// <param name="type">
            /// </param>
            /// <param name="namelen">
            /// </param>
            /// <param name="name">
            /// [length: namelen]
            /// </param>
            /// <param name="stringlen">
            /// </param>
            /// <param name="@string">
            /// [length: stringlen]
            /// </param>
            [AutoGenerated(Category = "ARB_shading_language_include", Version = "", EntryPoint = "glNamedStringARB")]
            public static void NamedString(OpenTK.Graphics.OpenGL4.ArbShadingLanguageInclude type, int namelen, [CountAttribute(Parameter = "namelen")] string name, int stringlen, [CountAttribute(Parameter = "stringlen")] string @string)
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(103)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glCompileShaderIncludeARB(uint shader, int count, [CountAttribute(Parameter = "count")] IntPtr path, [CountAttribute(Parameter = "count")] int* length);

            [Slot(196)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glDeleteNamedStringARB(int namelen, [CountAttribute(Parameter = "namelen")] IntPtr name);

            [Slot(423)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetNamedStringARB(int namelen, [CountAttribute(Parameter = "namelen")] IntPtr name, int bufSize, [OutAttribute, CountAttribute(Count = 1)] int* stringlen, [OutAttribute, CountAttribute(Parameter = "bufSize")] IntPtr @string);

            [Slot(424)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetNamedStringivARB(int namelen, [CountAttribute(Parameter = "namelen")] IntPtr name, OpenTK.Graphics.OpenGL4.ArbShadingLanguageInclude pname, [OutAttribute, CountAttribute(Computed = "pname")] int* @params);

            [Slot(623)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern byte glIsNamedStringARB(int namelen, [CountAttribute(Parameter = "namelen")] IntPtr name);

            [Slot(785)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glNamedStringARB(OpenTK.Graphics.OpenGL4.ArbShadingLanguageInclude type, int namelen, [CountAttribute(Parameter = "namelen")] IntPtr name, int stringlen, [CountAttribute(Parameter = "stringlen")] IntPtr @string);
        }
    }
}
