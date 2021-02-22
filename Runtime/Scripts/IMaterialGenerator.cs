﻿// Copyright 2020-2021 Andreas Atteneder
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using System.Collections.Generic;

namespace GLTFast {
    using Schema;
    public interface IMaterialGenerator {

        /// <summary>
        /// Get fallback material that is assigned to nodes without a material.
        /// </summary>
        /// <returns>fallback material</returns>
        UnityEngine.Material GetDefaultMaterial();

        /// <summary>
        /// Get fallback material that is assigned to point clouds without a material.
        /// </summary>
        /// <returns>fallback material</returns>
        UnityEngine.Material GetDefaultPointsMaterial();

        UnityEngine.Material GenerateMaterial(
            Material gltfMaterial,
            ref Schema.Texture[] textures,
            ref Schema.Image[] schemaImages,
            ref Dictionary<int,UnityEngine.Texture2D>[] imageVariants
            );
    }
}
