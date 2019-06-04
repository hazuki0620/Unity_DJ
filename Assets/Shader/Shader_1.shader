Shader "ShaderSketches/Shader_1"
{
   Properties
   {
       _MainTex ("MainTex", 2D) = "white"{}
   }

   CGINCLUDE
   #include "UnityCG.cginc"

   #define PI 3.14159265359
   float func(float2 size ,float2 st)
	{
		st = (st - float2(0.5, 0.38)) * float2(2.1, 2.8);
		return pow(st.x, 2) + pow(st.y - sqrt(abs(st.x)), 2); 
	}

   float box(float2 st, float2 size)
   {
   		float d =func(size,st);
        size = 0.5 - size * 0.5;
        st=abs(sin(d-_Time.y));
        st = step(size, st) * step(size, 1.0 - st);
  		return st.x * st.y;
   }
   float2x2 rotate(float angle)
    {
        return float2x2(cos(angle), -sin(angle),
                        sin(angle), cos(angle));
    }
    float3x3 scale(float2 scale)
	{
    return float3x3(scale.x, 0, 0,
                    0, scale.y, 0,
                    0, 0, 1);
	}
    
    float4 frag(v2f_img i) : SV_Target
	{
        float2 st = i.uv;
        float t = _Time.y;
        st -= 0.5;
        st = mul(scale(sin(t) + 1), float3(st, 1));
        st += 0.5;
        return box(st, 0.4);
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
