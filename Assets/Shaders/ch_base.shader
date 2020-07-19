Shader "Pegasus/CH/CH_Base"
{
    Properties
    {
        _MainTex ("MainTex", 2D) = "white" {}
        _MainTex_eye_ST("MainTex_eye_ST", Vector) = (0, 0, 0, 0)
        _MainTex_mouth_ST("MainTex_mouth_ST", Vector) = (0, 0, 0, 0)
        
        [KeywordEnum(body,eye,mouth)] _MaterialType("MaterialType", int) = 0
        
        _OutlineWidth ("OutlineWidth", float) = 0
        _OutlineColor ("OutlineColor", Color) = (0, 0, 0, 1)
        _OutlineOffset ("OutlineOffset", float) = 0.5
        
        _HighlightColor ("HighlightColor", Color) = (1, 1, 1, 1)
        [NoScaleOffset] _ShadowColor ("ShadowColor", 2D) = "white" {}
        [NoScaleOffset] _MatCap ("MatCap", 2D) = "black" {}
        
        _AddColor ("AddColor", Color) = (0, 0, 0, 1)
        _Condition ("Condition", Color) = (0.7, 0.7, 0.7, 1)
        _Visible ("Visible", Color) = (1, 1, 1, 1)
        
        _PG_Scale ("_PG_Scale", float) = 1
        _PG_GhostGroundFadeRate ("_PG_GhostGroundFadeRate", float) = 0
        _PG_GhostOutlineGroundFadeRate ("_PG_GhostOutlineGroundFadeRate", float) = 0
        
        [NoScaleOffset] _Kamishitu("_Kamishitu", 2D) = "white" {}
        [NoScaleOffset] _HSVMaskTex("_HSVMaskTex", 2D) = "white" {}
        
        // Preview only, not used in-game
        _PreviewVertexColors ("PreviewVertexColors", float) = 0
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 200

        CGPROGRAM
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface surf Standard fullforwardshadows
        #pragma multi_compile __ _MATERIALTYPE_EYE _MATERIALTYPE_MOUTH _MATERIALTYPE_BODY

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
            float2 texCoordExtraOffset = float2(0, 0);
            
            #if _MATERIALTYPE_EYE
            texCoordExtraOffset = _MainTex_eye_ST.zw;
            #endif
            
            #if _MATERIALTYPE_MOUTH
            texCoordExtraOffset = _MainTex_mouth_ST.zw;
            #endif
            
            float4 c = tex2D (_MainTex, IN.uv_MainTex + texCoordExtraOffset);
            c = lerp(c, IN.vertColor, saturate(_PreviewVertexColors));
            o.Albedo = c.rgb;
            o.Alpha = c.a;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
