Shader "Pegasus/GBG/GBG_Base"
{
    Properties
    {
        _Projection ("Projection", 2D) = "white" {}
        _Ground ("Ground", 2D) = "white" {}
        [Toggle(GROUND_WORLD)] _GroundWorld ("GroundWorld", float) = 0
        _AlBlend ("AlBlend", 2D) = "white" {}
        _MainTex ("MainTex", 2D) = "white" {}
        [Toggle(FOG)] _Fog ("Fog", float) = 0
        [Toggle(OUTLINE)] _Outline ("Outline", float) = 0
        _OutlineWidth ("OutlineWidth", float) = 0
        _OutlineColor ("OutlineColor", Color) = (0, 0, 0, 1)
        _Noize ("Noise", 2D) = "white" {}
        _YurePower ("YurePower", float) = 0
        _YureSpeed ("YureSpeed", float) = 0
        [NoScaleOffset] _ShadowColor ("ShadowColor", 2D) = "white" {}
        [NoScaleOffset] _LambertGra ("LambertGra", 2D) = "white" {}
        [NoScaleOffset] _Hatching ("Hatching", 2D) = "white" {}
        [Toggle(MOVE_OFF)] _MoveOff ("MoveOff", float) = 0
        [NoScaleOffset] _Kamishitu("_Kamishitu", 2D) = "white" {}
        [NoScaleOffset] _HSVMaskTex("_HSVMaskTex", 2D) = "white" {}
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 200

        CGPROGRAM
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface surf Standard fullforwardshadows

        // Use shader model 3.0 target, to get nicer looking lighting
        #pragma target 3.0

        sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
        };

        // Add instancing support for this shader. You need to check 'Enable Instancing' on materials that use the shader.
        // See https://docs.unity3d.com/Manual/GPUInstancing.html for more information about instancing.
        // #pragma instancing_options assumeuniformscaling
        UNITY_INSTANCING_BUFFER_START(Props)
            // put more per-instance properties here
        UNITY_INSTANCING_BUFFER_END(Props)

        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            // Albedo comes from a texture tinted by color
            fixed4 c = tex2D (_MainTex, IN.uv_MainTex);
            o.Albedo = c.rgb;
            o.Alpha = c.a;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
