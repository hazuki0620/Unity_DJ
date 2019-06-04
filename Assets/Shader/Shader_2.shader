Shader "ShaderSketches/Shader_2"
{
   Properties
   {
       _MainTex ("MainTex", 2D) = "white"{}
   }

   CGINCLUDE
   #include "UnityCG.cginc"

   float4 frag(v2f_img i) : SV_Target
   {
   		float d = distance(float2(0.5, 0.5), i.uv);
   		d=d*30;
   		d=abs(sin(d-_Time.y*10));
   		d=step(0.5,d);
   		return d;
   }

   ENDCG

   SubShader
   {
       Pass
       {
           CGPROGRAM
           #pragma vertex vert_img
           #pragma fragment frag
           ENDCG
       }
   }
}
