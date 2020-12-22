//
// Copyright (c) 2008-2017 the Urho3D project.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//

#pragma once

#include "../Graphics/Camera.h"
#include "../Graphics/Material.h"
#include "../Spark/SPK_Urho3D_DEF.h"
#include "../Spark/SPK_Urho3D_Buffer.h"

#include <Core/SPK_Renderer.h>

namespace SPK {
namespace URHO {

/// The base renderer for all Urho3D renderers
class  IUrho3DRenderer : public Renderer
{
public :

    /// Destructor of IUrho3DRenderer
    virtual ~IUrho3DRenderer() {}

    virtual void setBlendMode(BlendMode blendMode) override;

    void updateView(Urho3D::Camera* camera);

    Urho3D::Material* getMaterial();
    void setMaterial(Urho3D::Material* material);

protected :

    IUrho3DRenderer(Urho3D::Context *context, bool NEEDS_DATASET = false);
    Urho3D::Context*    _context;
    Urho3D::Camera*     _camera;
    Urho3D::SharedPtr<Urho3D::Material>   _material;
};

}
}
