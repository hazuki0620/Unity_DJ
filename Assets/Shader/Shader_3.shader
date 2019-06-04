Shader "Custom/Shader_3" {
 Properties
   {
       _MainTex ("MainTex", 2D) = "white"{}
   }

   CGINCLUDE
   #include "UnityCG.cginc"

   float4 frag(v2f_img i) : SV_Target
   {
   		fixed2 st=i.uv*0.5;
   		st = frac(st);
   		fixed4 pink   = fixed4(0.5,0.9,0.9,1);
    	fixed4 blue = fixed4(0.95,0.8,1,1);
    	fixed2 v = step(0,sin(50*st))*0.5;
    	st= frac(v.x+v.y)*2;
    	return lerp(pink, blue ,step(0.5, st.x))*lerp(pink, blue ,step(0.5, st.y));
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

