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
        /// [requires: v4.0 or ARB_shader_subroutine|VERSION_4_0]
        /// Query the name of an active shader subroutine
        /// </summary>
        /// <param name="program">
        /// Specifies the name of the program containing the subroutine.
        /// </param>
        /// <param name="shadertype">
        /// Specifies the shader stage from which to query the subroutine name.
        /// </param>
        /// <param name="index">
        /// Specifies the index of the shader subroutine uniform.
        /// </param>
        /// <param name="bufsize">
        /// Specifies the size of the buffer whose address is given in name.
        /// </param>
        /// <param name="length">
        /// [length: 1]
        /// Specifies the address of a variable which is to receive the length of the shader subroutine uniform name.
        /// </param>
        /// <param name="name">
        /// [length: bufsize]
        /// Specifies the address of an array into which the name of the shader subroutine uniform will be written.
        /// </param>
        [AutoGenerated(Category = "ARB_shader_subroutine|VERSION_4_0", Version = "4.0", EntryPoint = "glGetActiveSubroutineName")]
        public static void GetActiveSubroutineName(uint program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, uint index, int bufsize, [OutAttribute, CountAttribute(Count = 1)] out int length, [OutAttribute, CountAttribute(Parameter = "bufsize")] out string name)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.0 or ARB_shader_subroutine|VERSION_4_0]
        /// Query the name of an active shader subroutine
        /// </summary>
        /// <param name="program">
        /// Specifies the name of the program containing the subroutine.
        /// </param>
        /// <param name="shadertype">
        /// Specifies the shader stage from which to query the subroutine name.
        /// </param>
        /// <param name="index">
        /// Specifies the index of the shader subroutine uniform.
        /// </param>
        /// <param name="bufsize">
        /// Specifies the size of the buffer whose address is given in name.
        /// </param>
        /// <param name="length">
        /// [length: 1]
        /// Specifies the address of a variable which is to receive the length of the shader subroutine uniform name.
        /// </param>
        /// <param name="name">
        /// [length: bufsize]
        /// Specifies the address of an array into which the name of the shader subroutine uniform will be written.
        /// </param>
        [AutoGenerated(Category = "ARB_shader_subroutine|VERSION_4_0", Version = "4.0", EntryPoint = "glGetActiveSubroutineName")]
        public static unsafe void GetActiveSubroutineName(uint program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, uint index, int bufsize, [OutAttribute, CountAttribute(Count = 1)] int* length, [OutAttribute, CountAttribute(Parameter = "bufsize")] out string name)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.0 or ARB_shader_subroutine|VERSION_4_0]
        /// Query the name of an active shader subroutine uniform
        /// </summary>
        /// <param name="program">
        /// Specifies the name of the program containing the subroutine.
        /// </param>
        /// <param name="shadertype">
        /// Specifies the shader stage from which to query for the subroutine parameter. shadertype must be one of VertexShader, TessControlShader, TessEvaluationShader, GeometryShader or FragmentShader.
        /// </param>
        /// <param name="index">
        /// Specifies the index of the shader subroutine uniform.
        /// </param>
        /// <param name="bufsize">
        /// Specifies the size of the buffer whose address is given in name.
        /// </param>
        /// <param name="length">
        /// [length: 1]
        /// Specifies the address of a variable into which is written the number of characters copied into name.
        /// </param>
        /// <param name="name">
        /// [length: bufsize]
        /// Specifies the address of a buffer that will receive the name of the specified shader subroutine uniform.
        /// </param>
        [AutoGenerated(Category = "ARB_shader_subroutine|VERSION_4_0", Version = "4.0", EntryPoint = "glGetActiveSubroutineUniformName")]
        public static void GetActiveSubroutineUniformName(uint program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, uint index, int bufsize, [OutAttribute, CountAttribute(Count = 1)] out int length, [OutAttribute, CountAttribute(Parameter = "bufsize")] out string name)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.0 or ARB_shader_subroutine|VERSION_4_0]
        /// Query the name of an active shader subroutine uniform
        /// </summary>
        /// <param name="program">
        /// Specifies the name of the program containing the subroutine.
        /// </param>
        /// <param name="shadertype">
        /// Specifies the shader stage from which to query for the subroutine parameter. shadertype must be one of VertexShader, TessControlShader, TessEvaluationShader, GeometryShader or FragmentShader.
        /// </param>
        /// <param name="index">
        /// Specifies the index of the shader subroutine uniform.
        /// </param>
        /// <param name="bufsize">
        /// Specifies the size of the buffer whose address is given in name.
        /// </param>
        /// <param name="length">
        /// [length: 1]
        /// Specifies the address of a variable into which is written the number of characters copied into name.
        /// </param>
        /// <param name="name">
        /// [length: bufsize]
        /// Specifies the address of a buffer that will receive the name of the specified shader subroutine uniform.
        /// </param>
        [AutoGenerated(Category = "ARB_shader_subroutine|VERSION_4_0", Version = "4.0", EntryPoint = "glGetActiveSubroutineUniformName")]
        public static unsafe void GetActiveSubroutineUniformName(uint program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, uint index, int bufsize, [OutAttribute, CountAttribute(Count = 1)] int* length, [OutAttribute, CountAttribute(Parameter = "bufsize")] out string name)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.0 or ARB_shader_subroutine|VERSION_4_0]
        /// Query a property of an active shader subroutine uniform
        /// </summary>
        /// <param name="program">
        /// Specifies the name of the program containing the subroutine.
        /// </param>
        /// <param name="shadertype">
        /// Specifies the shader stage from which to query for the subroutine parameter. shadertype must be one of VertexShader, TessControlShader, TessEvaluationShader, GeometryShader or FragmentShader.
        /// </param>
        /// <param name="index">
        /// Specifies the index of the shader subroutine uniform.
        /// </param>
        /// <param name="pname">
        /// Specifies the parameter of the shader subroutine uniform to query. pname must be NumCompatibleSubroutines, CompatibleSubroutines, UniformSize or UniformNameLength.
        /// </param>
        /// <param name="values">
        /// [length: COMPSIZE(pname)]
        /// Specifies the address of a into which the queried value or values will be placed.
        /// </param>
        [AutoGenerated(Category = "ARB_shader_subroutine|VERSION_4_0", Version = "4.0", EntryPoint = "glGetActiveSubroutineUniformiv")]
        public static void GetActiveSubroutineUniform(uint program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, uint index, OpenTK.Graphics.OpenGL4.ActiveSubroutineUniformParameter pname, [OutAttribute, CountAttribute(Computed = "pname")] int[] values)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.0 or ARB_shader_subroutine|VERSION_4_0]
        /// Query a property of an active shader subroutine uniform
        /// </summary>
        /// <param name="program">
        /// Specifies the name of the program containing the subroutine.
        /// </param>
        /// <param name="shadertype">
        /// Specifies the shader stage from which to query for the subroutine parameter. shadertype must be one of VertexShader, TessControlShader, TessEvaluationShader, GeometryShader or FragmentShader.
        /// </param>
        /// <param name="index">
        /// Specifies the index of the shader subroutine uniform.
        /// </param>
        /// <param name="pname">
        /// Specifies the parameter of the shader subroutine uniform to query. pname must be NumCompatibleSubroutines, CompatibleSubroutines, UniformSize or UniformNameLength.
        /// </param>
        /// <param name="values">
        /// [length: COMPSIZE(pname)]
        /// Specifies the address of a into which the queried value or values will be placed.
        /// </param>
        [AutoGenerated(Category = "ARB_shader_subroutine|VERSION_4_0", Version = "4.0", EntryPoint = "glGetActiveSubroutineUniformiv")]
        public static void GetActiveSubroutineUniform(uint program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, uint index, OpenTK.Graphics.OpenGL4.ActiveSubroutineUniformParameter pname, [OutAttribute, CountAttribute(Computed = "pname")] out int values)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.0 or ARB_shader_subroutine|VERSION_4_0]
        /// Query a property of an active shader subroutine uniform
        /// </summary>
        /// <param name="program">
        /// Specifies the name of the program containing the subroutine.
        /// </param>
        /// <param name="shadertype">
        /// Specifies the shader stage from which to query for the subroutine parameter. shadertype must be one of VertexShader, TessControlShader, TessEvaluationShader, GeometryShader or FragmentShader.
        /// </param>
        /// <param name="index">
        /// Specifies the index of the shader subroutine uniform.
        /// </param>
        /// <param name="pname">
        /// Specifies the parameter of the shader subroutine uniform to query. pname must be NumCompatibleSubroutines, CompatibleSubroutines, UniformSize or UniformNameLength.
        /// </param>
        /// <param name="values">
        /// [length: COMPSIZE(pname)]
        /// Specifies the address of a into which the queried value or values will be placed.
        /// </param>
        [AutoGenerated(Category = "ARB_shader_subroutine|VERSION_4_0", Version = "4.0", EntryPoint = "glGetActiveSubroutineUniformiv")]
        public static unsafe void GetActiveSubroutineUniform(uint program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, uint index, OpenTK.Graphics.OpenGL4.ActiveSubroutineUniformParameter pname, [OutAttribute, CountAttribute(Computed = "pname")] int* values)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.0 or ARB_shader_subroutine|VERSION_4_0]
        /// Retrieve properties of a program object corresponding to a specified shader stage
        /// </summary>
        /// <param name="program">
        /// Specifies the name of the program containing shader stage.
        /// </param>
        /// <param name="shadertype">
        /// Specifies the shader stage from which to query for the subroutine parameter. shadertype must be one of VertexShader, TessControlShader, TessEvaluationShader, GeometryShader or FragmentShader.
        /// </param>
        /// <param name="pname">
        /// Specifies the parameter of the shader to query. pname must be ActiveSubroutineUniforms, ActiveSubroutineUniformLocations, ActiveSubroutines, ActiveSubroutineUniformMaxLength, or ActiveSubroutineMaxLength.
        /// </param>
        /// <param name="values">
        /// [length: 1]
        /// Specifies the address of a variable into which the queried value or values will be placed.
        /// </param>
        [AutoGenerated(Category = "ARB_shader_subroutine|VERSION_4_0", Version = "4.0", EntryPoint = "glGetProgramStageiv")]
        public static void GetProgramStage(uint program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, OpenTK.Graphics.OpenGL4.ProgramStageParameter pname, [OutAttribute, CountAttribute(Count = 1)] out int values)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.0 or ARB_shader_subroutine|VERSION_4_0]
        /// Retrieve properties of a program object corresponding to a specified shader stage
        /// </summary>
        /// <param name="program">
        /// Specifies the name of the program containing shader stage.
        /// </param>
        /// <param name="shadertype">
        /// Specifies the shader stage from which to query for the subroutine parameter. shadertype must be one of VertexShader, TessControlShader, TessEvaluationShader, GeometryShader or FragmentShader.
        /// </param>
        /// <param name="pname">
        /// Specifies the parameter of the shader to query. pname must be ActiveSubroutineUniforms, ActiveSubroutineUniformLocations, ActiveSubroutines, ActiveSubroutineUniformMaxLength, or ActiveSubroutineMaxLength.
        /// </param>
        /// <param name="values">
        /// [length: 1]
        /// Specifies the address of a variable into which the queried value or values will be placed.
        /// </param>
        [AutoGenerated(Category = "ARB_shader_subroutine|VERSION_4_0", Version = "4.0", EntryPoint = "glGetProgramStageiv")]
        public static unsafe void GetProgramStage(uint program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, OpenTK.Graphics.OpenGL4.ProgramStageParameter pname, [OutAttribute, CountAttribute(Count = 1)] int* values)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.0 or ARB_shader_subroutine|VERSION_4_0]
        /// Retrieve the index of a subroutine uniform of a given shader stage within a program
        /// </summary>
        /// <param name="program">
        /// Specifies the name of the program containing shader stage.
        /// </param>
        /// <param name="shadertype">
        /// Specifies the shader stage from which to query for subroutine uniform index. shadertype must be one of VertexShader, TessControlShader, TessEvaluationShader, GeometryShader or FragmentShader.
        /// </param>
        /// <param name="name">
        /// Specifies the name of the subroutine uniform whose index to query.
        /// </param>
        [AutoGenerated(Category = "ARB_shader_subroutine|VERSION_4_0", Version = "4.0", EntryPoint = "glGetSubroutineIndex")]
        public static uint GetSubroutineIndex(uint program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, string name)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.0 or ARB_shader_subroutine|VERSION_4_0]
        /// Retrieve the location of a subroutine uniform of a given shader stage within a program
        /// </summary>
        /// <param name="program">
        /// Specifies the name of the program containing shader stage.
        /// </param>
        /// <param name="shadertype">
        /// Specifies the shader stage from which to query for subroutine uniform index. shadertype must be one of VertexShader, TessControlShader, TessEvaluationShader, GeometryShader or FragmentShader.
        /// </param>
        /// <param name="name">
        /// Specifies the name of the subroutine uniform whose index to query.
        /// </param>
        [AutoGenerated(Category = "ARB_shader_subroutine|VERSION_4_0", Version = "4.0", EntryPoint = "glGetSubroutineUniformLocation")]
        public static int GetSubroutineUniformLocation(uint program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, string name)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.0 or ARB_shader_subroutine|VERSION_4_0]
        /// Retrieve the value of a subroutine uniform of a given shader stage of the current program
        /// </summary>
        /// <param name="shadertype">
        /// Specifies the shader stage from which to query for subroutine uniform index. shadertype must be one of VertexShader, TessControlShader, TessEvaluationShader, GeometryShader or FragmentShader.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the subroutine uniform.
        /// </param>
        /// <param name="@params">
        /// [length: 1]
        /// Specifies the address of a variable to receive the value or values of the subroutine uniform.
        /// </param>
        [AutoGenerated(Category = "ARB_shader_subroutine|VERSION_4_0", Version = "4.0", EntryPoint = "glGetUniformSubroutineuiv")]
        public static void GetUniformSubroutine(OpenTK.Graphics.OpenGL4.ShaderType shadertype, int location, [OutAttribute, CountAttribute(Count = 1)] out uint @params)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.0 or ARB_shader_subroutine|VERSION_4_0]
        /// Retrieve the value of a subroutine uniform of a given shader stage of the current program
        /// </summary>
        /// <param name="shadertype">
        /// Specifies the shader stage from which to query for subroutine uniform index. shadertype must be one of VertexShader, TessControlShader, TessEvaluationShader, GeometryShader or FragmentShader.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the subroutine uniform.
        /// </param>
        /// <param name="@params">
        /// [length: 1]
        /// Specifies the address of a variable to receive the value or values of the subroutine uniform.
        /// </param>
        [AutoGenerated(Category = "ARB_shader_subroutine|VERSION_4_0", Version = "4.0", EntryPoint = "glGetUniformSubroutineuiv")]
        public static unsafe void GetUniformSubroutine(OpenTK.Graphics.OpenGL4.ShaderType shadertype, int location, [OutAttribute, CountAttribute(Count = 1)] uint* @params)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.0 or ARB_shader_subroutine|VERSION_4_0]
        /// Load active subroutine uniforms
        /// </summary>
        /// <param name="shadertype">
        /// Specifies the shader stage from which to query for subroutine uniform index. shadertype must be one of VertexShader, TessControlShader, TessEvaluationShader, GeometryShader or FragmentShader.
        /// </param>
        /// <param name="count">
        /// Specifies the number of uniform indices stored in indices.
        /// </param>
        /// <param name="indices">
        /// [length: count]
        /// Specifies the address of an array holding the indices to load into the shader subroutine variables.
        /// </param>
        [AutoGenerated(Category = "ARB_shader_subroutine|VERSION_4_0", Version = "4.0", EntryPoint = "glUniformSubroutinesuiv")]
        public static void UniformSubroutines(OpenTK.Graphics.OpenGL4.ShaderType shadertype, int count, [CountAttribute(Parameter = "count")] uint[] indices)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.0 or ARB_shader_subroutine|VERSION_4_0]
        /// Load active subroutine uniforms
        /// </summary>
        /// <param name="shadertype">
        /// Specifies the shader stage from which to query for subroutine uniform index. shadertype must be one of VertexShader, TessControlShader, TessEvaluationShader, GeometryShader or FragmentShader.
        /// </param>
        /// <param name="count">
        /// Specifies the number of uniform indices stored in indices.
        /// </param>
        /// <param name="indices">
        /// [length: count]
        /// Specifies the address of an array holding the indices to load into the shader subroutine variables.
        /// </param>
        [AutoGenerated(Category = "ARB_shader_subroutine|VERSION_4_0", Version = "4.0", EntryPoint = "glUniformSubroutinesuiv")]
        public static void UniformSubroutines(OpenTK.Graphics.OpenGL4.ShaderType shadertype, int count, [CountAttribute(Parameter = "count")] ref uint indices)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.0 or ARB_shader_subroutine|VERSION_4_0]
        /// Load active subroutine uniforms
        /// </summary>
        /// <param name="shadertype">
        /// Specifies the shader stage from which to query for subroutine uniform index. shadertype must be one of VertexShader, TessControlShader, TessEvaluationShader, GeometryShader or FragmentShader.
        /// </param>
        /// <param name="count">
        /// Specifies the number of uniform indices stored in indices.
        /// </param>
        /// <param name="indices">
        /// [length: count]
        /// Specifies the address of an array holding the indices to load into the shader subroutine variables.
        /// </param>
        [AutoGenerated(Category = "ARB_shader_subroutine|VERSION_4_0", Version = "4.0", EntryPoint = "glUniformSubroutinesuiv")]
        public static unsafe void UniformSubroutines(OpenTK.Graphics.OpenGL4.ShaderType shadertype, int count, [CountAttribute(Parameter = "count")] uint* indices)
        {
            throw new BindingsNotRewrittenException();
        }

        [Slot(320)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe void glGetActiveSubroutineName(uint program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, uint index, int bufsize, [OutAttribute, CountAttribute(Count = 1)] int* length, [OutAttribute, CountAttribute(Parameter = "bufsize")] IntPtr name);

        [Slot(322)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe void glGetActiveSubroutineUniformName(uint program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, uint index, int bufsize, [OutAttribute, CountAttribute(Count = 1)] int* length, [OutAttribute, CountAttribute(Parameter = "bufsize")] IntPtr name);

        [Slot(321)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe void glGetActiveSubroutineUniformiv(uint program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, uint index, OpenTK.Graphics.OpenGL4.ActiveSubroutineUniformParameter pname, [OutAttribute, CountAttribute(Computed = "pname")] int* values);

        [Slot(513)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe void glGetProgramStageiv(uint program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, OpenTK.Graphics.OpenGL4.ProgramStageParameter pname, [OutAttribute, CountAttribute(Count = 1)] int* values);

        [Slot(537)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern uint glGetSubroutineIndex(uint program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, IntPtr name);

        [Slot(538)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern int glGetSubroutineUniformLocation(uint program, OpenTK.Graphics.OpenGL4.ShaderType shadertype, IntPtr name);

        [Slot(578)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe void glGetUniformSubroutineuiv(OpenTK.Graphics.OpenGL4.ShaderType shadertype, int location, [OutAttribute, CountAttribute(Count = 1)] uint* @params);

        [Slot(1200)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe void glUniformSubroutinesuiv(OpenTK.Graphics.OpenGL4.ShaderType shadertype, int count, [CountAttribute(Parameter = "count")] uint* indices);
    }
}
