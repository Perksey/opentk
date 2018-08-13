//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2010 the Open Toolkit library.
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

using System.IO;
using System.Linq;
using Bind.Generators.Bases;
using JetBrains.Annotations;

namespace Bind.Generators.GL2
{
    /// <summary>
    /// Generates API bindings for the OpenGL 4 API.
    /// </summary>
    internal class GLCore4GeneratorSettings : OpenGLGeneratorSettingsBase
    {
        /// <inheritdoc/>
        public override string OutputSubfolder => "OpenGL4";

        /// <inheritdoc/>
        public override string Namespace => "OpenTK.Graphics.OpenGL4";

        /// <inheritdoc/>
        public override string ProfileName => "glcore";

        /// <inheritdoc/>
        [NotNull]
        public override string BaseProfileName => "gl";

        /// <inheritdoc/>
        public override string SpecificationDocumentationPath => "gl4";

        /// <summary>
        /// Initializes a new instance of the <see cref="GLCore4GeneratorSettings"/> class.
        /// </summary>
        public GLCore4GeneratorSettings()
        {
            var overrideFileDirectoryPath = Path.Combine(Program.Arguments.InputPath, "GL2", "GL");
            var extraOverrides = Directory.GetFiles(overrideFileDirectoryPath, "*.xml", SearchOption.AllDirectories);

            OverrideFiles = new[]
            {
                Path.Combine(Program.Arguments.InputPath, "GL2", "overrides.xml")
            }
            .Concat(extraOverrides);
        }
    }
}
