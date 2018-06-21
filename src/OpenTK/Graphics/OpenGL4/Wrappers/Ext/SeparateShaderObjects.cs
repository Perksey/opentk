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
        /// Contains native bindings to functions in the category "SeparateShaderObjects" in the extension "Ext".
        /// </summary>
        public static partial class Ext
        {
            /// <summary>
            /// [requires: EXT_separate_shader_objects]
            /// </summary>
            /// <param name="program">
            /// </param>
            [AutoGenerated(Category = "EXT_separate_shader_objects", Version = "", EntryPoint = "glActiveProgramEXT")]
            public static void ActiveProgram(uint program)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_separate_shader_objects]
            /// Set the active program object for a program pipeline object
            /// </summary>
            /// <param name="pipeline">
            /// Specifies the program pipeline object to set the active program object for.
            /// </param>
            /// <param name="program">
            /// Specifies the program object to set as the active program pipeline object pipeline.
            /// </param>
            [AutoGenerated(Category = "EXT_separate_shader_objects", Version = "", EntryPoint = "glActiveShaderProgramEXT")]
            public static void ActiveShaderProgram(uint pipeline, uint program)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_separate_shader_objects]
            /// Bind a program pipeline to the current context
            /// </summary>
            /// <param name="pipeline">
            /// Specifies the name of the pipeline object to bind to the context.
            /// </param>
            [AutoGenerated(Category = "EXT_separate_shader_objects", Version = "", EntryPoint = "glBindProgramPipelineEXT")]
            public static void BindProgramPipeline(uint pipeline)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_separate_shader_objects]
            /// Create a stand-alone program from an array of null-terminated source code strings
            /// </summary>
            /// <param name="type">
            /// Specifies the type of shader to create.
            /// </param>
            /// <param name="@string">
            /// Specifies the number of source code strings in the array strings.
            /// </param>
            [AutoGenerated(Category = "EXT_separate_shader_objects", Version = "", EntryPoint = "glCreateShaderProgramEXT")]
            public static uint CreateShaderProgram(OpenTK.Graphics.OpenGL4.ShaderType type, string @string)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_separate_shader_objects]
            /// Create a stand-alone program from an array of null-terminated source code strings
            /// </summary>
            /// <param name="type">
            /// Specifies the type of shader to create.
            /// </param>
            /// <param name="count">
            /// Specifies the number of source code strings in the array strings.
            /// </param>
            /// <param name="strings">
            /// [length: count]
            /// Specifies the address of an array of pointers to source code strings from which to create the program object.
            /// </param>
            [AutoGenerated(Category = "EXT_separate_shader_objects", Version = "", EntryPoint = "glCreateShaderProgramvEXT")]
            public static uint CreateShaderProgram(OpenTK.Graphics.OpenGL4.ShaderType type, int count, [CountAttribute(Parameter = "count")] string[] strings)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_separate_shader_objects]
            /// Delete program pipeline objects
            /// </summary>
            /// <param name="pipelines">
            /// [length: n]
            /// Specifies an array of names of program pipeline objects to delete.
            /// </param>
            [AutoGenerated(Category = "EXT_separate_shader_objects", Version = "", EntryPoint = "glDeleteProgramPipelinesEXT")]
            public static void DeleteProgramPipeline([CountAttribute(Parameter = "n")] uint pipelines)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_separate_shader_objects]
            /// Delete program pipeline objects
            /// </summary>
            /// <param name="n">
            /// Specifies the number of program pipeline objects to delete.
            /// </param>
            /// <param name="pipelines">
            /// [length: n]
            /// Specifies an array of names of program pipeline objects to delete.
            /// </param>
            [AutoGenerated(Category = "EXT_separate_shader_objects", Version = "", EntryPoint = "glDeleteProgramPipelinesEXT")]
            public static void DeleteProgramPipelines(int n, [CountAttribute(Parameter = "n")] uint[] pipelines)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_separate_shader_objects]
            /// Delete program pipeline objects
            /// </summary>
            /// <param name="n">
            /// Specifies the number of program pipeline objects to delete.
            /// </param>
            /// <param name="pipelines">
            /// [length: n]
            /// Specifies an array of names of program pipeline objects to delete.
            /// </param>
            [AutoGenerated(Category = "EXT_separate_shader_objects", Version = "", EntryPoint = "glDeleteProgramPipelinesEXT")]
            public static void DeleteProgramPipelines(int n, [CountAttribute(Parameter = "n")] ref uint pipelines)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_separate_shader_objects]
            /// Delete program pipeline objects
            /// </summary>
            /// <param name="n">
            /// Specifies the number of program pipeline objects to delete.
            /// </param>
            /// <param name="pipelines">
            /// [length: n]
            /// Specifies an array of names of program pipeline objects to delete.
            /// </param>
            [AutoGenerated(Category = "EXT_separate_shader_objects", Version = "", EntryPoint = "glDeleteProgramPipelinesEXT")]
            public static unsafe void DeleteProgramPipelines(int n, [CountAttribute(Parameter = "n")] uint* pipelines)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_separate_shader_objects]
            /// Reserve program pipeline object names
            /// </summary>
            [AutoGenerated(Category = "EXT_separate_shader_objects", Version = "", EntryPoint = "glGenProgramPipelinesEXT")]
            public static uint GenProgramPipeline()
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_separate_shader_objects]
            /// Reserve program pipeline object names
            /// </summary>
            /// <param name="n">
            /// Specifies the number of program pipeline object names to reserve.
            /// </param>
            /// <param name="pipelines">
            /// [length: n]
            /// Specifies an array of into which the reserved names will be written.
            /// </param>
            [AutoGenerated(Category = "EXT_separate_shader_objects", Version = "", EntryPoint = "glGenProgramPipelinesEXT")]
            public static void GenProgramPipelines(int n, [OutAttribute, CountAttribute(Parameter = "n")] uint[] pipelines)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_separate_shader_objects]
            /// Reserve program pipeline object names
            /// </summary>
            /// <param name="n">
            /// Specifies the number of program pipeline object names to reserve.
            /// </param>
            /// <param name="pipelines">
            /// [length: n]
            /// Specifies an array of into which the reserved names will be written.
            /// </param>
            [AutoGenerated(Category = "EXT_separate_shader_objects", Version = "", EntryPoint = "glGenProgramPipelinesEXT")]
            public static void GenProgramPipelines(int n, [OutAttribute, CountAttribute(Parameter = "n")] out uint pipelines)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_separate_shader_objects]
            /// Reserve program pipeline object names
            /// </summary>
            /// <param name="n">
            /// Specifies the number of program pipeline object names to reserve.
            /// </param>
            /// <param name="pipelines">
            /// [length: n]
            /// Specifies an array of into which the reserved names will be written.
            /// </param>
            [AutoGenerated(Category = "EXT_separate_shader_objects", Version = "", EntryPoint = "glGenProgramPipelinesEXT")]
            public static unsafe void GenProgramPipelines(int n, [OutAttribute, CountAttribute(Parameter = "n")] uint* pipelines)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_separate_shader_objects]
            /// Retrieve the info log string from a program pipeline object
            /// </summary>
            /// <param name="pipeline">
            /// Specifies the name of a program pipeline object from which to retrieve the info log.
            /// </param>
            /// <param name="bufSize">
            /// Specifies the maximum number of characters, including the null terminator, that may be written into infoLog.
            /// </param>
            /// <param name="length">
            /// [length: 1]
            /// Specifies the address of a variable into which will be written the number of characters written into infoLog.
            /// </param>
            /// <param name="infoLog">
            /// [length: bufSize]
            /// Specifies the address of an array of characters into which will be written the info log for pipeline.
            /// </param>
            [AutoGenerated(Category = "EXT_separate_shader_objects", Version = "", EntryPoint = "glGetProgramPipelineInfoLogEXT")]
            public static void GetProgramPipelineInfoLog(uint pipeline, int bufSize, [OutAttribute, CountAttribute(Count = 1)] out int length, [OutAttribute, CountAttribute(Parameter = "bufSize")] out string infoLog)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_separate_shader_objects]
            /// Retrieve the info log string from a program pipeline object
            /// </summary>
            /// <param name="pipeline">
            /// Specifies the name of a program pipeline object from which to retrieve the info log.
            /// </param>
            /// <param name="bufSize">
            /// Specifies the maximum number of characters, including the null terminator, that may be written into infoLog.
            /// </param>
            /// <param name="length">
            /// [length: 1]
            /// Specifies the address of a variable into which will be written the number of characters written into infoLog.
            /// </param>
            /// <param name="infoLog">
            /// [length: bufSize]
            /// Specifies the address of an array of characters into which will be written the info log for pipeline.
            /// </param>
            [AutoGenerated(Category = "EXT_separate_shader_objects", Version = "", EntryPoint = "glGetProgramPipelineInfoLogEXT")]
            public static unsafe void GetProgramPipelineInfoLog(uint pipeline, int bufSize, [OutAttribute, CountAttribute(Count = 1)] int* length, [OutAttribute, CountAttribute(Parameter = "bufSize")] out string infoLog)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_separate_shader_objects]
            /// Retrieve properties of a program pipeline object
            /// </summary>
            /// <param name="pipeline">
            /// Specifies the name of a program pipeline object whose parameter retrieve.
            /// </param>
            /// <param name="pname">
            /// Specifies the name of the parameter to retrieve.
            /// </param>
            /// <param name="@params">
            /// Specifies the address of a variable into which will be written the value or values of pname for pipeline.
            /// </param>
            [AutoGenerated(Category = "EXT_separate_shader_objects", Version = "", EntryPoint = "glGetProgramPipelineivEXT")]
            public static void GetProgramPipeline(uint pipeline, OpenTK.Graphics.OpenGL4.PipelineParameterName pname, [OutAttribute] int[] @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_separate_shader_objects]
            /// Retrieve properties of a program pipeline object
            /// </summary>
            /// <param name="pipeline">
            /// Specifies the name of a program pipeline object whose parameter retrieve.
            /// </param>
            /// <param name="pname">
            /// Specifies the name of the parameter to retrieve.
            /// </param>
            /// <param name="@params">
            /// Specifies the address of a variable into which will be written the value or values of pname for pipeline.
            /// </param>
            [AutoGenerated(Category = "EXT_separate_shader_objects", Version = "", EntryPoint = "glGetProgramPipelineivEXT")]
            public static void GetProgramPipeline(uint pipeline, OpenTK.Graphics.OpenGL4.PipelineParameterName pname, [OutAttribute] out int @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_separate_shader_objects]
            /// Retrieve properties of a program pipeline object
            /// </summary>
            /// <param name="pipeline">
            /// Specifies the name of a program pipeline object whose parameter retrieve.
            /// </param>
            /// <param name="pname">
            /// Specifies the name of the parameter to retrieve.
            /// </param>
            /// <param name="@params">
            /// Specifies the address of a variable into which will be written the value or values of pname for pipeline.
            /// </param>
            [AutoGenerated(Category = "EXT_separate_shader_objects", Version = "", EntryPoint = "glGetProgramPipelineivEXT")]
            public static unsafe void GetProgramPipeline(uint pipeline, OpenTK.Graphics.OpenGL4.PipelineParameterName pname, [OutAttribute] int* @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_separate_shader_objects]
            /// Determine if a name corresponds to a program pipeline object
            /// </summary>
            /// <param name="pipeline">
            /// Specifies a value that may be the name of a program pipeline object.
            /// </param>
            [AutoGenerated(Category = "EXT_separate_shader_objects", Version = "", EntryPoint = "glIsProgramPipelineEXT")]
            public static bool IsProgramPipeline(uint pipeline)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_separate_shader_objects]
            /// Specify a parameter for a program object
            /// </summary>
            /// <param name="program">
            /// Specifies the name of a program object whose parameter to modify.
            /// </param>
            /// <param name="pname">
            /// Specifies the name of the parameter to modify.
            /// </param>
            /// <param name="value">
            /// Specifies the new value of the parameter specified by pname for program.
            /// </param>
            [AutoGenerated(Category = "EXT_separate_shader_objects", Version = "", EntryPoint = "glProgramParameteriEXT")]
            public static void ProgramParameter(uint program, OpenTK.Graphics.OpenGL4.AssemblyProgramParameterArb pname, int value)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_separate_shader_objects]
            /// Bind stages of a program object to a program pipeline
            /// </summary>
            /// <param name="pipeline">
            /// Specifies the program pipeline object to which to bind stages from program.
            /// </param>
            /// <param name="stages">
            /// Specifies a set of program stages to bind to the program pipeline object.
            /// </param>
            /// <param name="program">
            /// Specifies the program object containing the shader executables to use in pipeline.
            /// </param>
            [AutoGenerated(Category = "EXT_separate_shader_objects", Version = "", EntryPoint = "glUseProgramStagesEXT")]
            public static void UseProgramStages(uint pipeline, OpenTK.Graphics.OpenGL4.UseProgramStageMask stages, uint program)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_separate_shader_objects]
            /// </summary>
            /// <param name="type">
            /// </param>
            /// <param name="program">
            /// </param>
            [AutoGenerated(Category = "EXT_separate_shader_objects", Version = "", EntryPoint = "glUseShaderProgramEXT")]
            public static void UseShaderProgram(OpenTK.Graphics.OpenGL4.ExtSeparateShaderObjects type, uint program)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_separate_shader_objects]
            /// Validate a program pipeline object against current GL state
            /// </summary>
            /// <param name="pipeline">
            /// Specifies the name of a program pipeline object to validate.
            /// </param>
            [AutoGenerated(Category = "EXT_separate_shader_objects", Version = "", EntryPoint = "glValidateProgramPipelineEXT")]
            public static void ValidateProgramPipeline(uint pipeline)
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(0)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glActiveProgramEXT(uint program);

            [Slot(2)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glActiveShaderProgramEXT(uint pipeline, uint program);

            [Slot(26)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glBindProgramPipelineEXT(uint pipeline);

            [Slot(175)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern uint glCreateShaderProgramEXT(OpenTK.Graphics.OpenGL4.ShaderType type, IntPtr @string);

            [Slot(177)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern uint glCreateShaderProgramvEXT(OpenTK.Graphics.OpenGL4.ShaderType type, int count, [CountAttribute(Parameter = "count")] IntPtr strings);

            [Slot(202)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glDeleteProgramPipelinesEXT(int n, [CountAttribute(Parameter = "n")] uint* pipelines);

            [Slot(311)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGenProgramPipelinesEXT(int n, [OutAttribute, CountAttribute(Parameter = "n")] uint* pipelines);

            [Slot(504)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetProgramPipelineInfoLogEXT(uint pipeline, int bufSize, [OutAttribute, CountAttribute(Count = 1)] int* length, [OutAttribute, CountAttribute(Parameter = "bufSize")] IntPtr infoLog);

            [Slot(506)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetProgramPipelineivEXT(uint pipeline, OpenTK.Graphics.OpenGL4.PipelineParameterName pname, [OutAttribute] int* @params);

            [Slot(629)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern byte glIsProgramPipelineEXT(uint pipeline);

            [Slot(837)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glProgramParameteriEXT(uint program, OpenTK.Graphics.OpenGL4.AssemblyProgramParameterArb pname, int value);

            [Slot(1208)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glUseProgramStagesEXT(uint pipeline, OpenTK.Graphics.OpenGL4.UseProgramStageMask stages, uint program);

            [Slot(1209)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glUseShaderProgramEXT(OpenTK.Graphics.OpenGL4.ExtSeparateShaderObjects type, uint program);

            [Slot(1212)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glValidateProgramPipelineEXT(uint pipeline);
        }
    }
}
