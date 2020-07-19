Shader "Custom/Preview"
{
    Properties
    {
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _MainTex_eye_ST("MainTex_eye_ST", Vector) = (0, 0, 0, 0)
        _MainTex_mouth_ST("MainTex_mouth_ST", Vector) = (0, 0, 0, 0)

        _Cutoff ("Cutoff", float) = 0.5
        _PreviewVertexColors ("PreviewVertexColors", float) = 0
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 200

        CGPROGRAM
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface surf Standard fullforwardshadows alphatest:_Cutoff

        // Use shader model 3.0 target, to get nicer looking lighting
        #pragma target 3.0

        sampler2D _MainTex;
        float4 _MainTex_eye_ST;
        float4 _MainTex_mouth_ST;
        float _PreviewVertexColors;

        struct Input
        {
            float2 uv_MainTex;
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
            float4 c = tex2D (_MainTex, IN.uv_MainTex + _MainTex_eye_ST.zw + _MainTex_mouth_ST.zw);
            c = _PreviewVertexColors < 1 ? lerp(c, IN.vertColor, saturate(_PreviewVertexColors)) : float4(0, 0, 0, 1);
            o.Emission = _PreviewVertexColors >= 1 ? IN.vertColor : 0;
            o.Albedo = c.rgb;
            o.Alpha = c.a;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
