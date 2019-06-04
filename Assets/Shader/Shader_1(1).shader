Shader "Custom/Shader_1(1)" {
  Properties
   {
       _MainTex ("MainTex", 2D) = "white"{}
       _Size0 ("Distort", Float) = 0.0
   }

   CGINCLUDE
   #include "UnityCG.cginc"
   float _Size0;
   float _Size1;
   float _Size2;
   float _Size3;
   float box(float2 st, float size)
	{
    size = 0.5 + size * 0.5;
    st = step(st, size) * step(1.0 - st, size);
    return st.x * st.y;
	}

   float wave(float2 st,float size,float n){
   		st = (floor(st * n) + 0.5) / n;
   		float d = distance(0.5, st);
    	return (1 + sin(d * 3 -size)) * 0.5;

   }
   float box_wave(float2 uv,float size,float n)
   {
    	float2 st = frac(uv * n);
    	float size1 = wave(uv,size,n);
    	return box(st, size1);

   }
   float4 frag(v2f_img i) : SV_Target
   {
   		float n=10;
   		return box_wave(i.uv,_Size0,n);
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
