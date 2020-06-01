Shader "Pegasus/GBG/GBG_Water"
{
    Properties
    {
        [Toggle(_ALPHAPREMULTIPLY_ON)] _Premultiply ("Premultiply", float) = 0
        _Hamon ("Hamon", Color) = (1,1,1,1)
        _ShorelineMargin ("ShorelineMargin", float) = 0
        _Noise ("Noise", 2D) = "white" {}
        _NoiseUVSpeed ("NoiseUVSpeed", Vector) = (0, 0, 0, 0)
        _WaterColor ("WaterColor", Color) = (1,1,1,1)
        [NoScaleOffset] _Kamishitu("_Kamishitu", 2D) = "white" {}
        [NoScaleOffset] _HSVMaskTex("_HSVMaskTex", 2D) = "white" {}
    }
    SubShader
    {
        Tags { "RenderType"="Transparent" "Queue"="Transparent" }
        LOD 200
        Blend SrcAlpha OneMinusSrcAlpha
        ZWrite Off

        CGPROGRAM
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface surf Standard fullforwardshadows alpha:premul

        // Use shader model 3.0 target, to get nicer looking lighting
        #pragma target 3.0

        float4 _WaterColor;
        
        struct Input {
            float4 vertColor : COLOR;
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
            o.Albedo = IN.vertColor.rgb;
            o.Alpha = IN.vertColor.a;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
